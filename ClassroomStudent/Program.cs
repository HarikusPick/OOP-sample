using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomStudent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(1, " ahmet");
            Student s1 = new Student(2, " mehmet");
            Student s2 = new Student(3, " ali");
            Student s3 = new Student(4, " veli");

            Classroom c = new Classroom("sınıf1");
            c.addStudent(s);
            c.addStudent(s1);
            c.addStudent(s2);
            c.addStudent(s3);

            c.printList();
            School sc = new School("okul1");
            sc.printClassList();
            sc.getClasses()[0].addStudent(s);
            sc.getClasses()[0].addStudent(s1);
            sc.getClasses()[0].addStudent(s2 );

            sc.printClassList();

            //c = null;

            Console.ReadLine();
        }
    }
}
