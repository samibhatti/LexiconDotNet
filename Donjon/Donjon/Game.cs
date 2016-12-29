using System;

namespace Donjon
{
    internal class Game //3
    {
        private Map map;
        private Hero hero; //11
      //  private Monster monster;

        //private int height;
        //private int width;

        public Game(int width, int height)
        {
            map = new Map(width, height); //5
        }

        internal void Run()
        {
            // init game
            //var hero = new Hero(health: 100); //4
            hero = new Hero(health: 100);     //12
           //monster = new Monster();
            PopulateMap();
            // game loop 8
            do
            {

                Console.Clear();
                PrintMap();
                //process actions
                PrintStatus();
                ConsoleKey key = GetInput();

                switch (key)
                {
                    case ConsoleKey.UpArrow:
                        if (hero.Y > 0) hero.Y -= 1;
                        break;
                    case ConsoleKey.DownArrow:
                        if (hero.Y < map.Height - 1) hero.Y += 1;
                        break;
                    case ConsoleKey.LeftArrow:
                        if (hero.X > 0) hero.X -= 1;
                        break;
                    case ConsoleKey.RightArrow:
                        if (hero.X < map.Width - 1) hero.X += 1;
                        break;

                    default:
                        break;
                }
            } while (true);

            // game over
        }

        private void PopulateMap()
        {
            map.Cells[7, 4].Monster = new Goblin();
            map.Cells[4, 7].Monster = new Goblin();
            map.Cells[9, 7].Monster = new Orc();
            map.Cells[7, 9].Monster = new Orc();
        }

        private void PrintStatus()
        {
            Console.WriteLine();
            Console.WriteLine($"Health: {hero.Health} hp");
        }

        private ConsoleKey GetInput()
        {
            Console.WriteLine("Press a key");
            var keyInfo = Console.ReadKey(intercept: true); //???
            var key = keyInfo.Key;
            return key;
        }

        private void PrintMap()
        {
            for (int y = 0; y < map.Height; y++)
            {
                for (int x = 0; x < map.Width; x++)
                {
                    var cell = map.Cells[x, y]; //9
                    Console.Write(" ");
                    if ((hero.X) == x && hero.Y == y)
                    {
                        Console.Write("H");
                    }
                    else if (cell.Monster != null)
                    {
                        Console.ForegroundColor = cell.Monster.Color;
                        Console.Write(cell.Monster.MapSymbol);
                        Console.ResetColor();
                    }
                    else
                    {
                        Console.Write(".");
                    }
                }
           
                    Console.WriteLine();
            }
        }   
    }
}