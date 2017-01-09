using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsFL
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Util.Max(4,5));
            Console.WriteLine(Util.Max(4.1,5.2));
            Console.WriteLine(Util.Max(4,5.2));
            Console.WriteLine(Util.Max(4.2,5));
            Console.WriteLine(Util.Max("2","10"));
            Console.WriteLine(Util.Max(true, false));
            Console.WriteLine(Util.Max("<", ">"));
            Console.WriteLine(Util.Max("{", "}"));

            var isopair = new Pair<float>(4.3f, 1.9f); // create childclass with type float
            var pair = new Pair<int, string>(5, "hej");
            var first = pair.First;
            var second = pair.Second;

        }
    }

    class Util
    {
        public static T Max<T>(T a, T b) where T : IComparable<T>
        {
            if (a.CompareTo(b) > 0) return a;
            return b;

        }
    }

    class Pair<TFirst, TSecond>
    {
        //Properties
        //public object First { get; set; }
        public TFirst First { get; set; }
        public TSecond Second { get; set; }
        //Constructor
        //public Pair(object first, object second)
        public Pair(TFirst first, TSecond second)
        {
            First = first;
            Second = second;
        }
    }

    class Pair<T> : Pair<T, T>
    {
        public Pair(T first, T second) : base(first, second)
        {

        }
    }
}
