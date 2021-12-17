using System;
using System.Collections.Generic;
using System.Text;

namespace HomeWorkPractice1
{
    public class Problems
    {
        public void Problem1()
        {
            DateTime dt = new DateTime(2021, 12, 13); //hard coded monday date but can use = DateTime.Now to be current to computers datetime system
            
            if (dt.DayOfWeek == DayOfWeek.Monday)
            {
                Console.WriteLine("Bleh");
            }

            else if (dt.DayOfWeek == DayOfWeek.Saturday)
            {
                Console.WriteLine("WooHoo!");
            }

        }

        public void Problem2()
        {
            for (int i = -100; i <= 100; i++)
            {
                Console.WriteLine(i);
            }
        }

        public void Problem3()
        {
            //Problem 3
            Console.WriteLine("Even numbers from 0 to 1000");

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Problem4()
        {
            //Problem 4
            Console.WriteLine("Odd numbers from 0 to 1000");

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Problem5()
        {
            //Problem 5
            Console.WriteLine("Every 10 numbers from 0 to 100");

            for (int i = 0; i <= 100; i++)
            {
                if (i % 10 == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

        public void Problem6()
        {
            //Problem 6
            Console.WriteLine("Solution to Problem 6");

            int i = 0;

            while (i <= 5)
            {
                Console.WriteLine("Hey howdy!!");
                i++;
            }
        }

        public void Problem7()
        {
            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
