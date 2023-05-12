namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Exercise 1
            //Your name: Dana
            //Favorite Color: Green
            //Favorite Animal:Raccoon 
            //Favorite Band: All time Low 
            
            Console.WriteLine("What is your name?");
            var userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName} What is your favorite color?");
            var Color = Console.ReadLine();

            Console.WriteLine($"{Color} is a great color, what, what is your favorite animal?");
            var animal = Console.ReadLine();

            Console.WriteLine($"Awesome! Now, what is your favorite band?");
            var band = Console.ReadLine();
        }
    }
}
