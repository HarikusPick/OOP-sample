using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomStudent
{
    internal class School
    {
        private Teacher head; //assosiation
        private List<Classroom> classes; //COMPOSİTİON
        string name;
        public School(string name)
        {
            this.name = name;
            classes = new List<Classroom>();
            Classroom r1 = new Classroom("a1");classes.Add(r1);
            Classroom r2 = new Classroom("a2");classes.Add (r2);
            Classroom r3 = new Classroom("a3"); classes.Add(r3);
            Classroom r4 = new Classroom("a4"); classes.Add(r4);

        }
        
        public List<Classroom> getClasses()
        {
            return classes;
        }

        public void printClassList()
        {
            foreach (Classroom r in classes)
                Console.WriteLine(r);
        }
    }
}
