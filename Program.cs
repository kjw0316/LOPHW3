using System;

namespace minority
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int input;

            int divCount = 0;
            int minorCount = 0;

            while (true)
            {
                Console.Write("입력:");
                input = int.Parse(Console.ReadLine());

                if (input >= 2 && input <= 10000) break;
            }

            Console.Write("소수 목록 : ");

            for(int i = 2; i <= input; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (i % j == 0) divCount++;
                }
                
                if (divCount == 2)
                {
                    Console.Write("{i} ");
                    
                    minorCount++;
                }

                divCount = 0;
            }

            Console.WriteLine("");
            Console.WriteLine("소수 갯수 : " + minorCount);
        }
    }
}
