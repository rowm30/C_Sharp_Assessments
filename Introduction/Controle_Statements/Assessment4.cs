using System;

namespace Controle_Statements
{
    public class Assessment4
    {
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            int numberOfOccurance = 0;

            for (var i = 0; i < num1.ToString().Length; i++)
            {
                if (num2.ToString()[0] == num1.ToString()[i])
                {
                    numberOfOccurance++;
                }
            }
            Console.WriteLine(numberOfOccurance);
        }
    }
}