namespace FibonacciSeq;

class Program
{
    public static void Main()
    {
        string num1 = ""; // Declare variable as empty

        Console.WriteLine("Enter the number to check"); // Ask the user for input
        num1 = Console.ReadLine();

        if (int.TryParse(num1, out int num2) && num2 >= 0) //parse num1 to an integer and returns true if successful
        {

            if (isFibonacci(num2))
            {
                Console.WriteLine(num1 + " is a Fibonacci number.");
                nextThreeNumbers(num2);
            }
            else
            {
                Console.WriteLine(num1 + " is not a Fibonacci number.");
            }
        }
        else
        {
            Console.WriteLine("Input needs to be a POSITIVE WHOLE NUMBER!"); //writes this line if input is not a positive whole number
        }
    }

    public static bool isPerfectSquare(int x) //A perfect square is 2 identical integers multiplied together to form a number Ex. 4,9,16
    {
        int s = (int)Math.Sqrt(x); //s = 2, x = 4
        return (s * s == x);
    }

    public static bool isFibonacci(int n) // // A number is Fibonacci if one or both of (5 * n^2 + 4) or (5 * n^2 - 4) is a perfect square
    {
        return isPerfectSquare(5 * (n * n) + 4) ||
            isPerfectSquare(5 * (n * n) - 4);
    }

    public static void nextThreeNumbers(int num) //If N is multiplied by ((1 + sqrt(5)) / 2) and round it, the result will be the next fibonacci number
    {
        double x = 1;
        double y = 1;
        double z = 2;

        if (num != 0)
        {
            x = Math.Round(num * (1 + Math.Sqrt(5)) / 2);
            y = Math.Round(x * (1 + Math.Sqrt(5)) / 2);
            z = Math.Round(y * (1 + Math.Sqrt(5)) / 2);
        }
        
        Console.WriteLine($"{x}, {y}, {z} are the next 3 Fibonacci numbers.");
    }
}

