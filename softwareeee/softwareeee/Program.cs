using System;

namespace softwareeee
{
    class Program
    {
        static void Main(string[] args)
        {
            float height;
            float weight;
            float bmi;
            string test;

            Console.WriteLine("BMI CALCULATION");

            Console.WriteLine("Enter your Name:");
            string name = Console.ReadLine();

            Console.WriteLine("Height in meter: ");
            height = Single.Parse(Console.ReadLine().Trim());



            Console.WriteLine("Weight in kg: ");

           weight = Single.Parse(Console.ReadLine().Trim());



            Console.WriteLine("Enter m for male and w for women");
            Console.WriteLine();
            test = Console.ReadLine();

            bmi = weight / (height * height);
            Console.WriteLine(" Your BMI is " + bmi);

            
            if (test == "m")
            {
                Console.WriteLine();
                Console.WriteLine("You are male");
                Console.WriteLine();

            }

            if (bmi < 20.7)

                Console.WriteLine("You are underweight");


            else if (bmi >= 20.7 && bmi < 26.4)
            {
                Console.WriteLine("You are in normal range");

            }
            else if (bmi >= 26.4 && bmi < 27.8)

                Console.WriteLine("You are marginally overweight");

            else if (bmi >= 27.3 && bmi < 31.1)

                Console.WriteLine("You are  overweight");

            else if (bmi > 31.1 && bmi <= 35)

                Console.WriteLine("You are  overweight or obese");

            else
            {
                if (bmi >= 35 && bmi < 40)

                    Console.WriteLine("You are severely obese");

                else if (bmi >= 40 && bmi < 50)

                    Console.WriteLine("You are morbidy obese");

                else if (bmi >= 50 && bmi < 60)

                    Console.WriteLine("You are super obesed");

                else
                    Console.WriteLine(" you are boulder");
            }
        }
    }
}
