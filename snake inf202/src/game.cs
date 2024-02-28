using Raylib_cs;

namespace gra
{
    class Game
    {

        private Grid grid;
        private Snake snake;

        private Snack snack;

        private int cellSize;

        public int points;
        bool game_over;
        bool starer;
        bool game_completed;

        public Game(int width,int height, int cellSize)
        {
            points = 0;
            grid = new Grid(width,height,cellSize);
            snake = new Snake();
            snack = new Snack();
            this.cellSize = cellSize;
            game_over = false;
            starer = true;
            game_completed = false;
        }

        private void eaten()
        {
            if(snake.GetHeadPosition().x == snack.GetSnackPosition().x && snake.GetHeadPosition().y == snack.GetSnackPosition().y)
            {
                points += 10;
                snake.appendSegment(snack);

                while(!snake.ValidGenerated(snack.GetSnackPosition()))
                    snack.setPosition(snack.GetRandomPosition());

            }

            
        }

        private void PrintScore(int x, int y)
        {
            Raylib.DrawText($"Score : {points}", x, y, 40, Color.Yellow);
        }

        public void Refresh()
        {
            if(game_over)
            {   
                grid.draw();
                snake.draw(cellSize);
                snack.setPosition(snack.GetSnackPosition());
                snack.draw(cellSize);
                Raylib.DrawText("GAME OVER", 262, 200, 52, Color.Yellow);
                Raylib.DrawText($"Press anyting to play again", 210, 260, 30, Color.Yellow);
                PrintScore(315,310);
                
                //350 310
                
            }

            if(starer)
            {   
                string content = File.ReadAllText("highest.txt");

                points = Convert.ToInt32(content);

                grid.draw();
                Raylib.DrawText("SNAKE GAME", 112, 185, 92, Color.Yellow);
                Raylib.DrawText($"Press anyting to start game", 200, 280, 30, Color.Yellow);
                Raylib.DrawText($"AUTHOR : ADAM KWIATKOWSKI", 7, 516, 20, Color.Yellow);
                Raylib.DrawText($"HIGHEST SCORE: {points}", 595, 516, 20, Color.Yellow);

                if(Raylib.GetKeyPressed() != 0)
                {
                    starer = false;
                    points = 0;
                }
                    
            }

            if(game_over && Raylib.GetKeyPressed() != 0)
            {
                game_over = false;
                snake.reset();
                points = 0;
            }

            if(!game_over && !starer && !game_completed) {
                
                grid.draw();
                snake.draw(cellSize);
                
                snake.HandleInput();
                
                
                eaten();

                snake.Move();
                snack.draw(cellSize);
                PrintScore(20,20);

                if(snake.getSnakeSize() == 502)
                {
                    game_completed = true;
                }

                if(snake.Crash()) {
                    game_over = true;
                }

            }

            if(game_completed)
            {
                if(Raylib.GetKeyPressed() != 0)
                {
                    game_completed = false;
                    points = 0;
                    snake.reset();
                    snack.setPosition(snack.GetSnackPosition());
                }

                grid.draw();
                snake.draw(cellSize);
                

                Raylib.DrawText("YOU WON", 290, 200, 52, Color.Yellow);
                Raylib.DrawText($"Press anyting to play again", 210, 260, 30, Color.Yellow);
                PrintScore(315,310);
            }
                
        }

        public int UpdateHighScore(int highScore)
        {
            int score = 0;

            

            return score;
        }
    }

    

    struct Position
    {
        public int x;
        public int y;
    }
}