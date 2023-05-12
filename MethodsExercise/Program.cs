using System.ComponentModel;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        
        {
        var answer = num1 + num2;
            return answer; 

}
        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }

        public static int Subtract(int num1, int num2)
        {
            return num1 - num2;
        }

        public static int Divide(int num1, int num2)
        {
            return num1 / num2;
        }

        public static int Modulous(int num1, int num2)
        {
            return num1 % num2;
        }

        static void Main(string[] args)
        {

            var amountOfCars = Sum(2, 6);
            var whatever = Multiply(60, 2, 5);
            var applesLeft = Subtract(100, 25);
            var halves = Divide(25, 5);
            var last = Modulous(17, 4);

            Console.WriteLine($"Add:{amountOfCars},Multiply:{whatever},Subtract:{applesLeft},Divide:{halves},Modulous:{last}");

            //Exercise 1
            //Your name: Dana
            //Favorite Color: Green
            //Favorite Animal:Raccoon 
            //Favorite Band: All time Low 
            
            Console.WriteLine("Hi there! What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} What is your favorite color?");
            var Color = Console.ReadLine();

            Console.WriteLine($"{Color} is a great color, what, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Awesome! Now, what is your favorite band?");
            var band = Console.ReadLine();

            Console.WriteLine($"Thanks {userName}! Here is your Profile :)");
            Console.WriteLine("----------------------------------------------");

            Console.WriteLine($"Name:{userName}");
            Console.WriteLine($"Favorite Color:{Color}");
            Console.WriteLine($"Favorite Animal:{animal}");
            Console.WriteLine($"Favorite Band:{band}");


            //Exercise 2

        }
    }
}
