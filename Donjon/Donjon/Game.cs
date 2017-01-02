using System;

namespace Donjon
{
    internal class Game //3
    {
        private Map map;
        private Hero hero; //11
        private string log;

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
                PrintVisible();
                //PrintLog();

                Console.WriteLine("What do you do?");
                ConsoleKey key = GetInput();

                // process actions
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
                    case ConsoleKey.Spacebar:
                        var monster = map.Cells[hero.X, hero.Y].Monster;
                        if (monster != null) Fight(monster);
                        break;

                    default:
                        break;
                }
            } while (true);

            // game over
        }

        /*private void PrintLog()
        {
            throw new NotImplementedException();
        }*/

        private void Fight(Monster monster)
        {
            Log(hero.Fight(monster));

            // log += hero.Fight(monster) + "\n";
            //string result = hero.Fight(monster);
            Console.WriteLine(hero.Fight(monster));
            if (monster.Health > 0)
            {
                //   result = monster.Fight(hero);
                // Console.WriteLine(monster.Fight(hero));
                Log(monster.Fight(hero));
            }
        }

        private void Log(string message)
        {
            log += message + "\n"; //use string builder instead
        }

        private void PrintVisible()
        {
            var cell = map.Cells[hero.X, hero.Y];
            var monster = cell.Monster;
            //if (monster != null)
            if (monster != cell.Monster)
            {
                Console.WriteLine();
                Console.WriteLine($"You see a {monster.Name} ({monster.Health} hp)");
            }
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

                    Creature creature = null; //a
                    if ((hero.X) == x && hero.Y == y)
                    {
                        creature = hero; //c
                        //Console.Write("H"); //b
                    }
                    else if (cell.Monster != null)
                    {
                        creature = cell.Monster; //d
                    }
                    else
                    {
                        Console.Write(".");
                    }

                    if (creature != null)                                                 //e
                    {
                        Console.ForegroundColor = creature.Color;
                        Console.Write(creature.MapSymbol);
                        Console.ResetColor();
                    }
                }
           
                    Console.WriteLine();
            }
        }   
    }
}