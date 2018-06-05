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

            Teacher Teach = new Teacher();
            Teach.Name = "Fred";
            // Testing for Kinder
            Kindergarten Kinder = new Kindergarten();
            Kinder.print_Teacher_info();
        }
    }
}
