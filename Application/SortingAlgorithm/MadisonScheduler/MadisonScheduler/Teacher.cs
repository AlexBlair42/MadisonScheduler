using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    enum TeacherTypes
    {
        Kinder,
        First,
        Second
    }

    class Teacher
    {
        protected String name;
        protected bool status;
        protected int grade;
        protected int Time;

        public virtual string get_name();

        public static Teacher CreaTeacher(TeacherTypes Type)
        {
            if (Type == Kind)
        }

    }
}
