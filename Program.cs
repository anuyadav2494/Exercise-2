using System;

namespace Exercise_2
{
    class Program
    {
        static void Main(string[] args)
        { 

            int age;
            int height;
            // Max Heart rate is equal to 220-age


            age = 24;
            height = 155;
            int maxheartrate;
            maxheartrate = 220 - age;
            Console.WriteLine("I am " + age + " years old, my max heart rate is  " + maxheartrate + " and I am " + height + " cms tall.");
            Console.ReadLine();
        }
    }
}
