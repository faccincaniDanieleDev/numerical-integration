namespace rectangles_method
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a;
            double b;
            double n;

            //user input
            Console.WriteLine("Enter a value of a: ");
            while(!double.TryParse(Console.ReadLine(), out a))
            {
                Console.WriteLine("Invalid input. Enter a valid number: ");
            }

            Console.WriteLine("Enter a value of b: ");
            while(!double.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Invalid input. Enter a valid number: ");
            }

            Console.WriteLine("Enter a value of n: ");
            while(!double.TryParse(Console.ReadLine(), out n))
            {
                Console.WriteLine("Invalid input. Enter a valid number: ");
            }

            //calculate and print the area
            double area = rectanglesMethod(a,b,n);
            Console.WriteLine("The approximate area is: " + area.ToString("F4"));
        }


        // Function to evaluate f(x) = x^2 + 3
        public static double f(double x)
        {
            return x * x + 3;
        }

        // Rectangle method - approximates the integral of f(x) in [a, b] using n rectangles
        public static double rectanglesMethod(double a, double b, double n)
        {
            // Width of each rectangle
            double h = (b - a) / n;
            double S = 0;

            for(int i = 0; i < n; i++)
            {
                // Left endpoint of each rectangle
                double x = a + i * h;

                // Add rectangle area to sum
                S+=f(x);
            }

            return h * S;
        }
    }
}
