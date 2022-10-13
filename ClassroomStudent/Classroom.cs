using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomStudent
{
    internal class Classroom
    {
        private Teacher teacher;  ///ASSOSİATİON **********************************************************
        public List<Student> stdList; //AGGREGATİON
        private string name;

        public Classroom(string name)
        {
            this.name = name;
            stdList = new List<Student>(1);
            
        }

        public void addStudent(Student s)
        {
            stdList.Add(s);
        }

        public void printList()
        {
            if (stdList == null) return;
            foreach (Student s in stdList)
                Console.WriteLine(s);
        }
        public override string ToString()
        {
            string text = "class name= "+ this.name;
            foreach (Student s in stdList)
                text += s;
            return text;
        }
    }
}
