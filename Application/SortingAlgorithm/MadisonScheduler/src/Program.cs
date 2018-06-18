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

            FirstGrade First = new FirstGrade();
            First.print_Teacher_info();

            SecondGrade Second = new SecondGrade();
            Second.print_Teacher_info();
        



        }
    }
}
