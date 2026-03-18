using Raylib_cs;

namespace gra
{
    
    class Snake
    {
        List<Position> snake = new List<Position>();
        DIR currentDir;
        private double eventOccurence;
        private double movingInterval;

        public Snake()
        {
            snake.Add(GetRandomPosition());
            Spawn();
            currentDir = DIR.RIGHT;
            eventOccurence = 0;
            movingInterval = 0.2;
        }

        public void reset()
        {
            snake.Clear();
            snake.Add(GetRandomPosition());
            Spawn();
            currentDir = DIR.RIGHT;
            eventOccurence = 0;
        }

        public int getSnakeSize()
        {
            return snake.Count;
        }
        
        
        public bool Crash() 
        {
            
            if(0 > snake[0].x || snake[0].x >= 28)
                return true;

            if(0 > snake[0].y || snake[0].y >= 18)
                return true;

            

            for(int i = 2; i < snake.Count; ++i) {
                if(snake[i].x == snake[0].x && snake[i].y == snake[0].y)
                    return true;
            }

            return false;
        }

        public Position GetHeadPosition()
        {
            return snake[0];
        }

        public void appendSegment(Snack snack)
        {
            snake.Insert(0, snack.GetSnackPosition());
        }

        public bool ValidGenerated(Position snackPos)
        {
            foreach(Position pos in snake)
            {
                if(pos.x == snackPos.x && pos.y == snackPos.y)
                    return false;
            }

            return true;
        }

        public void Spawn()
        {
            Position pos = snake[0];
            for(int i = 0; i < 3; ++i) {
                pos.x--;
                snake.Add(pos);
            }

        }

        public void draw(int cellSize)
        {
            foreach (Position pos in snake)
            {
                Raylib.DrawRectangle(pos.x * cellSize + 1, pos.y * cellSize + 1, cellSize - 1, cellSize - 1, Color.Red);
            }
        }

        private Position GetRandomPosition()
        {
            Random randomX = new Random();
            Random randomY = new Random();

            Position pos = new Position();
            pos.x = randomX.Next(9,19);
            pos.y = randomY.Next(6,13);

            return pos;
        }

        public void HandleInput()
        {   
            int key = Raylib.GetKeyPressed();
            if(key != 0) {
                switch(key)
                {
                    case 265:
                    if(currentDir == DIR.LEFT || currentDir == DIR.RIGHT)
                        currentDir = DIR.UP; 
                    break;//UP
                    case 264:
                    if(currentDir == DIR.LEFT || currentDir == DIR.RIGHT)
                        currentDir = DIR.DOWN;
                    break;//DOWN
                    case 263: 
                    if(currentDir == DIR.DOWN || currentDir == DIR.UP)
                        currentDir = DIR.LEFT;
                    break;//LEFT
                    case 262:
                    if(currentDir == DIR.DOWN || currentDir == DIR.UP) 
                        currentDir = DIR.RIGHT;
                    break;//RIGHT
                }
            }
        }

        public void Move()
        {   
            double time = Raylib.GetTime();

            if(time - eventOccurence >= movingInterval)
            {   
                eventOccurence = time; 

                for(int i = snake.Count - 1; i > 0; --i)
                {
                    snake[i] = snake[i - 1];
                }

                switch(currentDir)
                {
                    case DIR.UP: moveUp(); break;//UP
                    case DIR.DOWN: moveDown(); break;//DOWN
                    case DIR.LEFT: moveLeft();break;//LEFT
                    case DIR.RIGHT: moveRigth();break;//RIGHT
                }
                
                

            }

            
        }

        private void moveUp()
        {
            Position pos = snake[0];
            pos.y -= 1;
            snake[0] = pos;
            currentDir = DIR.UP;
        }
        private void moveDown()
        {
            Position pos = snake[0];
            pos.y += 1;
            snake[0] = pos;
            currentDir = DIR.DOWN;
        }
        private void moveRigth()
        {
            Position pos = snake[0];
            pos.x += 1;
            snake[0] = pos;
            currentDir = DIR.RIGHT;
        }
        private void moveLeft()
        {
            Position pos = snake[0];
            pos.x -= 1;
            snake[0] = pos;
            currentDir = DIR.LEFT;
        }

        

        enum DIR
        {
            UP,
            DOWN,
            RIGHT,
            LEFT
        }
    }

    
}