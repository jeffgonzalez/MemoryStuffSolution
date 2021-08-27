using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace MemoryStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            var sw = new Stopwatch();
            var listOfThings = new List<Thingy>();
            sw.Start();
            foreach(var t in Enumerable.Range(1, 100000))
            {
                listOfThings.Add(new Thingy(t));
            }
            sw.Stop();
            Console.WriteLine($"All Done! - that took {sw.ElapsedMilliseconds} Milliseconds!");

            Console.Write("Hit Enter to Take Out The Trash");
            Console.ReadLine();
            listOfThings.Clear();
            GC.Collect();
            Console.WriteLine("All Done.");

           
        }
    }

    public class Thingy
    {
        private readonly int id;

        public Thingy(int id)
        {
            this.id = id;
        }

        ~Thingy()
        {
            Console.WriteLine($"Thingy {id}'s Destructor is Running");
        }
    }
}
