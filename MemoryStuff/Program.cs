using System;
using System.Linq;
using System.Text;

namespace MemoryStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            var content = new StringBuilder();

            foreach(var x in Enumerable.Range(1,10000))
            {
                content.Append(x + ",");
            }

            Console.WriteLine(content);


        }
    }
}
