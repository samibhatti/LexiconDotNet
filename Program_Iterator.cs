using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iterator
{
    class Program
    {
        static void Main(string[] args)
        {

            /*// Explicity loop
            var enumerator = Naturals().GetEnumerator();
            Console.WriteLine(enumerator.Current);
            while (enumerator.MoveNext())
            {
                Console.WriteLine(enumerator.Current);
                Console.ReadLine();
            }
            /*var naturals = Naturals();
            foreach (var item in naturals)
            {
                Console.WriteLine(item);
              //  Console.ReadKey();
            }*/
            var backPack = new LimitedList<string>(10);
            bool added;
            int count = 0;
            do
            {
                count += 1;
                added = backPack.Add($"item {count}" );
            } while (added);
          
            /*backPack.Add(4);
            backPack.Add(2);
            backPack.Add(6);
            backPack.Add(8);
            backPack.Add(0);*/

            foreach (var item in backPack)
            {
                Console.WriteLine(item);
            }

            Console.ReadKey();

            count = 0;
            string remove = null;
            foreach (var item in backPack)
            {
                if (count == 3)
                {
                    remove = item;
                }
                count += 1;
            }
            backPack.Remove(remove);

            foreach (var item in backPack)
            {
                Console.WriteLine(item);
            }
        }

        static IEnumerable Naturals()
        {
            int i = 0;
            while (true)
            {
                // int i = Int32.MaxValue - 10;
                //i = Int32.MaxValue - 10;
                yield return i;
                i++;
            }
        }
    }

    class LimitedList<T> : IEnumerable<T> where T : class
    {
        private T[] elements;

        public int Capacity { get; }
        public int Count { get; private set; }

        public T Current
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public LimitedList(int capacity)
        {
            Capacity = capacity;
            elements = new T[capacity];
        }

        public bool Add(T element)
        {
            if (Count >= Capacity) return false;

            // foreach (var e in elements)
            for (int i = 0; i < Capacity; i++)
            {
                if(elements[i] == null)
                {
                    elements[i] = element;
                    Count += 1;
                    return true;
                }
            }
            return false;
/*            elements[Count] = element;
            Count += 1;
            return true;*/
        }

        public T Remove(T element)
        {
            for (int i = 0; i < Capacity; i++)
            {
                if (elements[i].Equals(element))
                {
                   // elements[i] = default(T);
                    elements[i] = null;
                    Count -= 1;
                    return element;
                }
            }
            return default(T);
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = 0; i < Count; i++)
            {
                yield return elements[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
               
    }
}  
