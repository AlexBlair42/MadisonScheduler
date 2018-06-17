using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class Program
    {
        static void Main(string[] args)
        {
            

            Console.Out.WriteLine("Hello C#");
            // Testing for Kinder
            Kindergarten Kinder = new Kindergarten();
            Kinder.print_Teacher_info();

            // Testing for Factory Methods
            Factory Fac = new Factory();
            /*
            for (int i = 0; i < max_K; i++)
            {
                Fac.Create_Teacher(Kindergarten);
            }
            */



        }
    }
}
