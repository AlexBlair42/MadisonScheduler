using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class ThirdGrade : Teacher
    {
        public void print_Teacher_info()
        {
            Console.Out.WriteLine("This is a Third Grade Teacher!");
        }

        private const int lunchMin = 45;

    }
}
