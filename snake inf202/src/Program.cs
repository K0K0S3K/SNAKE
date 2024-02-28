using Raylib_cs;



namespace gra
{
    class Program {         

        public static void Main()
        {
            Raylib.SetTargetFPS(60);    

            int maxScore = Convert.ToInt32(File.ReadAllText("highest.txt"));

            Raylib.InitWindow(841, 541, "Hello World");

            Game game = new Game(28,18,30);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);
                game.Refresh();
                maxScore = Math.Max(maxScore,game.points);
                Raylib.EndDrawing();
            }

            File.WriteAllText("highest.txt", maxScore.ToString());
            
            Raylib.CloseWindow();
        }
    }
}


//right 262
//left  263
//up 265
//down 264