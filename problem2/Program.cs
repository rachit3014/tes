using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace problem2
{
    class Student
    {
        private int rollno;
        private string name;
        private string course;
        private int feepaid;
        private static double servicetax = 12.3;
        public Student(int rollno, string name, string course)
        {
            this.rollno = rollno;
            this.name = name;
            this.course = course;
        }

        public void payment(int amount)
        {
            feepaid = feepaid + amount;
        }

        public void display()
        {
            Console.WriteLine(rollno);
            Console.WriteLine(name);
            Console.WriteLine(course);
            Console.WriteLine(feepaid);
        }

        public int dueAmount
        {

            get
            {
                return totalFee - feepaid;
            }
        }



        public static double ServiceTax
        {
            get
            {
                return servicetax;
            }
            set
            {
                servicetax = value;
            }
        }
    }

    class UseStudent
    {

        public static void Main()
        {

            Student s = new Student(2, "def", "c#");

            s.display();
            Console.WriteLine(s.dueAmount);
            Console.ReadKey();

        }
    }
}
