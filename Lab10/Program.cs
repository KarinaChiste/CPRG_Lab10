using System.Numerics;

namespace Lab10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Addition");
            Console.WriteLine("Enter number n: ");
            string a = Console.ReadLine();
            int number1 = Convert.ToInt32(a);
            Console.WriteLine("Enter number m: ");
            string b = Console.ReadLine();
            int number2 = Convert.ToInt32(b);
            Console.WriteLine(Addition(number1,number2));
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

        public static int Divisions(int a)
        {
            return 0;
        }
    } 
}
