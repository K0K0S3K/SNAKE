using Raylib_cs;

namespace gra
{
    class Snack
    {
        
        Position snackPosition;

        public Snack()
        {
            snackPosition = GetRandomPosition();
        }

        public void draw(int cellSize)
        {
            Raylib.DrawRectangle(snackPosition.x * cellSize + 1, snackPosition.y * cellSize + 1, cellSize - 1, cellSize - 1,  Color.Lime);
        }

        
        public Position GetRandomPosition()
        {
            Position pos = new Position();

            Random rand = new Random();

            pos.x = rand.Next(0,28);
            pos.y = rand.Next(0,17);

            return pos;
        }

        public void setPosition(Position pos)
        {
            snackPosition = pos;
        }

        public Position GetSnackPosition()
        {
            return snackPosition;
        }
    }
}
