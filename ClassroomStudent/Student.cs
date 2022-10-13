using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomStudent
{
    internal class Student
    {
        private int stdID;
        private string name;

        public Student(int stdID, string name)
        {
            this.stdID = stdID;
            this.name = name;
        }
        public override string ToString()
        {
            return this.stdID + this.name;
        }
    }
}
