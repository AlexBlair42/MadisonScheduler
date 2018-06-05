using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class Teacher
    {
        protected string name;
        protected bool status;
        protected int grade;
        protected int time;

        // Methods
        public virtual string Name {get;set;}
        public virtual bool Status {get;set;}
        public virtual int Grade {get; set;}
        public virtual int Time {get; set;}

        public Teacher CreateTeacher()
        {
            return new Teacher();
        }

    }
}
