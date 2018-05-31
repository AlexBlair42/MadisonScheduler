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
            Teacher Teach = new Teacher();
            Console.WriteLine(Teach.Name);

            Kindergarten Kin = new Kindergarten();
            Kin.print_teacher_info();

            Console.ReadLine();
        }
    }
}
