using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception_handling
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Task6_1
            double dividend;
            double divisor;
            double result = 0;

            try
            {
                Console.Write("Enter dividend: ");
                dividend = double.Parse(Console.ReadLine());
                Console.Write("Enter divisor: ");
                divisor = double.Parse(Console.ReadLine());
                result = Div(dividend,divisor);
            }
            catch (DivideByZeroException ex)
            {
                Console.Error.WriteLine("Error: " + ex.Message);
            }
            catch (FormatException)
            {
                Console.Error.WriteLine("Invalid double number!");
            }
            catch (OverflowException)
            {
                Console.Error.WriteLine(
                   "The number is too big to fit in double!");
            }

            if (result != 0)
            {
                Console.WriteLine($"\nReult division = {result}");
            }
            Console.WriteLine("\nPress any key");
            Console.ReadKey();
            #endregion
        }

        public static double Div(double dividend, double divisor)
        {
            if (divisor == 0)
                throw new System.DivideByZeroException(
                   "Division by Zero not posible");

            return dividend / divisor;
        }
    }
}
