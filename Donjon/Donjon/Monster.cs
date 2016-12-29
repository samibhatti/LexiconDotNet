using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Donjon
{
    public abstract class Monster
    {
        public string MapSymbol { get; }
        public int Health { get; set; }
        public string Name { get; set; }
        public ConsoleColor Color { get; set; } = ConsoleColor.Red;

        protected int Damage = 20;
        private string v1;
        private int v2;
        
        public Monster(string mapSymbol, string name, int health)
        {
            MapSymbol = mapSymbol;
            Name = name;
            Health = health;
        }

    }

    public class Goblin : Monster
    {
        public Goblin() : base("G", "goblin", 20) {
            Color = ConsoleColor.Green;
        }
    }

    public class Orc : Monster
    {
        public Orc() : base("O", "orc", 40) {
            Damage = 40;
        }
    }
}
