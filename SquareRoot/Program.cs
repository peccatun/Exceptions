using System;

namespace SquareRoot
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                double result = SquareRoot(Console.ReadLine());
                Console.WriteLine(result);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Good bye!");
            }

            
        }

        public static double SquareRoot(string number)
        {
            int num = 0;

            try
            {
                num = int.Parse(number);
            }
            catch (ArgumentException ae)
            {

                throw new ArgumentException("Invalid number",ae);
            }
            catch (FormatException fe)
            {
                throw new FormatException("Invalid number",fe);
            }
            if (num < 0)
            {
                throw new InvalidOperationException("Invalid number");
            }
            return Math.Sqrt(num);
        }
    }
}
