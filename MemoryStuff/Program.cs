using System;
using System.Linq;

namespace MemoryStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            var content = "";

            foreach(var x in Enumerable.Range(1,10000))
            {
                content += x + ",";
            }

            Console.WriteLine(content);


        }
    }
}
