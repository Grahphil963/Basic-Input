using System;

namespace Basic_Input
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;
            int currentYear;
            string name;
        
            //Greetings 
            //Philip


            Console.WriteLine("Hi, What is your name?");
            name = Console.ReadLine();
            Console.WriteLine($"{name}, How old are you? ");
            age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What Year is it currently?");
            currentYear = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"{name} your are {age} years old and you were born in {currentYear - age} ");





            //Adder

            int firstNumber;
            int secondNumber;
            int thirdNumber;
            Console.WriteLine("Please enter a number");
            firstNumber= Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a second number");
            Console.WriteLine("Please enter a third number");

           




            



        }
    }
}
