using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    abstract class Teacher
    {
        // Member Variables
        protected string name = "";
        protected bool status;
        protected int grade;
        protected int time;

        // Methods

        // members should be mutable in case a teacher is assigned a new grade
        public virtual string Name {get;set;}
        public virtual bool Status {get;set;}
        public virtual int Grade {get; set;}
        public virtual int Time {get; set;}

    }
}
