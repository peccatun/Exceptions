using System;
using System.Collections.Generic;

namespace EnterNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = 0;
            int end = 0;
            List<int> numbersList = new List<int>();
            int index = -1;
            while (numbersList.Count < 10)
            {
                try
                {
                    if (index < 0)
                    {
                        Console.Write("Enter start num: ");
                        start = int.Parse(Console.ReadLine());
                        if (start <= 1)
                        {
                            throw new Exception("start must be bigger than one");
                        }
                        ChekStart(start);
                        Console.Write("Enter end num: ");
                        end = int.Parse(Console.ReadLine());
                        if (end >= 100)
                        {
                            throw new Exception("end must be smaller than one hundred");
                        }

                        if (start + 10 > end)
                        {
                            throw new Exception("the numbers must have difference bigger than ten");
                        }

                        ChekEnd(end);

                        int firstNum = ReadNumber(start, end);
                        if (firstNum < start || firstNum > end)
                        {
                            throw new Exception($"Number must be between {start} - {end}");
                        }
                        numbersList.Add(firstNum);
                        index++;
                    }

                    int currentNum = ReadNumber(start, end);
                    if (currentNum < start || currentNum > end)
                    {
                        throw new Exception($"Number must be between {start} - {end}");
                    }
                    if (currentNum > numbersList[index])
                    {
                        numbersList.Add(currentNum);
                        index++;
                    }
                    else
                    {
                        throw new Exception("Number must be smaller than the previous one");
                    }
                }
                catch (Exception ex)
                {
                    index = -1;
                    numbersList = new List<int>();
                    Console.WriteLine(ex.Message);
                }
            }

        }

        public static int ReadNumber(int start, int end)
        {

            bool IsValidStart = ChekStart(start);
            bool IsValidEnd = ChekEnd(end);

            if (IsValidStart && IsValidEnd)
            {
                try
                {
                    int currentNumber = int.Parse(Console.ReadLine());
                    return currentNumber;
                }
                catch (FormatException fe)
                {
                    throw new FormatException("Invalid number", fe);
                }

            }

            throw new ArgumentException("Invalid number");

        }

        public static bool ChekStart(int start)
        {
            if (start <= 1)
            {
                throw new ArgumentException("Invalid number");
            }
            else if (start >= 100)
            {
                throw new ArgumentException("Invalid number");
            }
            return true;
        }

        public static bool ChekEnd(int end)
        {
            if (end <= 1)
            {
                throw new ArgumentException("Invalid number");
            }
            else if (end >= 100)
            {
                throw new ArgumentException("Invalid number");
            }

            return true;
        }
    }
}
