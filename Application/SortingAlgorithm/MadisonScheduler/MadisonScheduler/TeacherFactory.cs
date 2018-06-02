using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MadisonScheduler
{
    enum TeacherType
    {
        Kindergarten,
        FirstGrade
    };

    class TeacherFactory
    {
        public Teacher Create_Teacher(TeacherType type)
        {
            if (type == Kindergarten)
            {
                return new Kindergarten();
            }
        }
    }
}
