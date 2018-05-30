using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    class Teacher
    {
        // Protected member variables with 
        protected String name;
        protected bool status;
        protected int grade;
        protected int time;

        // Public Methods
        public virtual string Name
        {
            get { return name; }
            set { Name = name; }
        }

        public virtual bool Status
        {
            get { return status; }
            set { Status = status; }
        }

        public virtual int Grade
        {
            get { return grade; }
            set { Grade = grade; }
        }

        public virtual int Time
        {
            get { return time; }
            set { Time = time; }
        }

        public Teacher()
        {
            name = "Teacher";
            status = false;
            grade = 0;
            time = 0;
        }

    }
}
