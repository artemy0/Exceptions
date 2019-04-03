using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            Worker worker1 = new Worker("Zhenya", "Manager");
            Worker worker2 = new Worker("Ilya", "Courier", -8);
            Worker worker3 = new Worker("Gleb", "");
            
            Worker[] workers = new Worker[] { worker1, worker2, worker3 };

            //Attempt to display information about workers
            foreach (Worker worker in workers)
            {
                try
                {
                    worker.PrintInfoInConsole();
                }
                catch (IncorrectPersonalInformationException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine();
                }
            }

            Console.ReadKey();
        }
    }
}
