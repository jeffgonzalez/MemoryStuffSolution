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

            var conn = new TylersSuperOptimizedSqlConnection();

            conn.Open();

            Console.WriteLine(conn.RunCommand("SELECT password from users"));

            conn.Close(); // destructor is gone...

            // 60 lines of code later

            conn.Open();

            conn.RunCommand("oh yeah, that thing");

            // and they forget to close it.


            conn.Dispose(); // I am so DONE with this, I PROMISE I won't touch it again.

            // IF You create an object that has a dispose method, call that method when you are done with it.

            // 30 lines of code later.

            conn.Open();
        }
    }

    public class TylersSuperOptimizedSqlConnection : IDisposable
    {

        private bool isOpen = false;
        public void Open()
        {
            isOpen = true;
            // tyler will put some code here that opens a socket connection to a SQL server on port 1433, and negotiate using the TDS protocol of SQL blah blah blah
        }

        public string RunCommand(string sql)
        {
            if(!isOpen)
            {
                throw new Exception("Open the Connection First, Bonehead");
            }
            // using the open connection send this command and return the results...
            return "Command ran";
        }

        public void Close()
        {
            isOpen = false;
            // close the socket to the database...

         
        }

        public void Dispose()
        {
            if(isOpen)
            {
                Close();
            }
            GC.SuppressFinalize(this); // Take that flag down. Don't run the destructor. I've done everything I will do there, so we are cool.
        }

        ~TylersSuperOptimizedSqlConnection()
        {
            if(isOpen)
            {
                Close();
            }
        }
    }
}
