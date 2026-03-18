using Raylib_cs;

namespace gra
{
    class Grid
    {
        private int width;
        private int height;
        private int cellSize;

        public Grid(int width = 28, int height = 18, int cellSize = 30)
        {
            this.width = width;
            this.height = height;
            this.cellSize = cellSize;
        }

        public void draw()
        {
            for(int row = 0; row < width; ++row)
            {
                for(int col = 0; col < height; ++col)
                {       
                    int posX = 1 + row * cellSize;
                    int posY = 1 + col * cellSize;

                    Raylib.DrawRectangle(posX,posY,cellSize - 1,cellSize - 1,Color.Black);
                }
            }
        }
    }

}