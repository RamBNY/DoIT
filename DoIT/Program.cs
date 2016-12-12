using System;

namespace DoIT
{
    class Program
    {
        static String location;
        static DateTime time;

        static void Main(string[] args)
        {
            //string multipleThree = "Buzz";
            //string multipleFive = "Fizz";
            //string multipleThreeFive = "FizzBuzz";

            //for(int number = 1; number <= 100; number++)
            //{
            //    if((number % 3 == 0) && (number % 5 == 0))
            //    {
            //        Console.WriteLine("{0}", multipleThreeFive);
            //    }
            //    else if(number % 3 == 0)
            //    {
            //        Console.WriteLine("{0}", multipleThree);
            //    }
            //    else if(number % 5 == 0)
            //    {
            //        Console.WriteLine("{0}", multipleFive);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0}", number);
            //    }   
            //}

            if (location == null)
            {
                Console.WriteLine("location is null");
            }
            else
            {
                Console.WriteLine(location);
            }

            if (time == null)
            {
                Console.WriteLine("time is null");
            }
            else
            {
                Console.WriteLine(time.ToString());
            }
            Console.ReadKey();
        }

        
    }
}
