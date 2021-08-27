using System;
using System.Linq;
using System.Text;

namespace MemoryStuff
{
    class Program
    {
        static void Main(string[] args)
        {

            var x = "Fido";
            var y = x;

            y = "Tacos";

            Console.WriteLine(x);

            Console.WriteLine(ChangeTheDog(x));

            Console.WriteLine(x);

            string ChangeTheDog(string p)
            {
                p = "Rover";
                return p.ToUpper();
            }

        }
    }
}
