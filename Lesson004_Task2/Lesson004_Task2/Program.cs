using System;

namespace Lesson004_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter month of experience :");
            int exp_month = int.Parse(Console.ReadLine());

            if (exp_month <= 3)
                Console.WriteLine("Trainee");
            else if (exp_month > 3 && exp_month <= 6)
                Console.WriteLine("Low Junior");
            else if (exp_month > 6 && exp_month <= 12)
                Console.WriteLine("Junior");
            else if (exp_month > 12 && exp_month <= 18)
                Console.WriteLine("Strong Junior");
            else if (exp_month > 18 && exp_month <= 24)
                Console.WriteLine("Low Middle");
            else if (exp_month > 24 && exp_month <= 36)
                Console.WriteLine("Middle");           
            else if (exp_month > 36 && exp_month <= 48)
                Console.WriteLine("Strong Middle");
            else if (exp_month > 48 && exp_month <= 60)
                Console.WriteLine("Low Senior");
            else if (exp_month > 60 && exp_month <= 72)
                Console.WriteLine("Senior");
            else if (exp_month > 72 && exp_month <= 96)
                Console.WriteLine("Strong Senior");
            else if (exp_month > 96)
                Console.WriteLine("Proffesional");
        }
    }
}
