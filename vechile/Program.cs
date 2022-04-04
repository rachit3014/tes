using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vechile
{
    class vchle
    {
        string make;
        string model;
        int year;

        public void display()
        {
            Console.WriteLine(" enter make");
            make = Console.ReadLine();
            Console.WriteLine(" enter model");
            model = Console.ReadLine();
            year = int.Parse(Console.ReadLine());
        }
        public void Accelerate()
        {

        }
        public void decclerate()
        {

        }
        public void drive()
        {

        }
        public void start()
        {

        }
        public void stop()
        {

        }

        public class Minivan
        {
            int cargo_Net;
            bool dual_Sliding;

            public bool HasCargoNet() { return true; }
            public bool HasDualSliding() { return dual_Sliding; }



        }
        public class Van : vchle { }
        class car : vchle { }
        class sportscar : car { }
        public class Excursionvan : Van { }
        class TestVechile
        {
            static void Main(String[] args)
            {

            }


        }



    }
}
