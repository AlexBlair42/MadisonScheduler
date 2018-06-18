using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class Kindergarten : Teacher
    {
        public void print_Teacher_info()
        {
            Console.Out.WriteLine("This is a Kindergarten Teacher!");
        }

        private const int lunchMin = 45;

    }
}
