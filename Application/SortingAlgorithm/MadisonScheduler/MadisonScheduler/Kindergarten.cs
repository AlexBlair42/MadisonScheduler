using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class Kindergarten : Teacher
    {
        // Constrained member variables for Kindergarten
        protected const int lunch_min = 45;
        protected bool physStatus = false;
        protected bool lunchStatus = false;
        protected bool libStatus = false;
        protected bool musicStatus = false;
        protected bool socStatus = false;
        protected bool litFitreq = true;

        // Function for printing type of teacher to screen.
        public void print_teacher_info() => Console.WriteLine("This is a Kindergarten Teacher!");
    }
}
