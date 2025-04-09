using System.Numerics;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");            
            int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number m: ");           
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Addition(number1, number2));
            Console.WriteLine("Division");
            Console.WriteLine("Enter your number:");
            int divide = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Total number of divisions:{Divisions(divide)}");
           
        }
        

        public static int Addition(int a, int b)
        {
            if( a == b)
            {
                return a;
            }
            else
            {
                return a+Addition(a+1, b);
            }
                
        }
        
        public static int Divisions(int a, int count = 0)
        {
            if (a%2 != 0)
            {
                return count;
            }
            else
            {
                count++;
                return Divisions(a/2, count);
            }
        }
    } 
}
