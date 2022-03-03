using System;

namespace Basic_Input
{
    class Program
    {
        static void Main(string[] args)
        {
           
            
            //Philip Graham 
            //March 2nd 2022

            

            
            int age;
            int currentYear;
            string name;
        
            //Greetings 
            


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
            secondNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter a third number");
            thirdNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The total of the the three numbers is {firstNumber + secondNumber + thirdNumber}. ");



            //Distance 
            double firstDistance;
            double secondDistance;
            double thirdDistance;


            Console.WriteLine("Please enter the distance that is between you and your friend's house in kilometers");
            firstDistance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the distance between your house and the White House in kilometers");
            secondDistance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the distance between your house and the International Space Station in Kilometers");
            thirdDistance = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The average in kilometers of the three distances you entered is {Math.Round((firstDistance + secondDistance + thirdDistance) / 3 ,2)} ");




            //Hypotenuese 
            double sideOne;
            double sideTwo;
            double sideThree;

            Console.WriteLine("What is the length of side 1 on your right triangle?");
            sideOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What is the lenght of side 2 on your right triangle?");
            sideTwo = Convert.ToInt32(Console.ReadLine());
            sideThree = ((sideOne * sideOne) + (sideTwo * sideTwo)) ;
            Console.WriteLine($"The hypotenuese of your triangle is {Math.Round((Math.Sqrt(sideThree)), 2)} cm");



           

















        }
    }
}
