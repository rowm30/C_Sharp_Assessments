using System;

namespace Controle_Statements{
    public class Assessment2{
        public static void Main(String[] args){
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            
            int temp = num1;

            int num1_units = temp%10;
            temp = temp/10;
            int num1_tens = temp%10;
            temp = temp/10;
            int num1_hundreds = temp%10;
            temp = temp/10;
            int num1_thousands = temp%10;
            

            if (num2 == num1_units)
            {
                System.Console.WriteLine("Second number is present in units place of first number");
            }
            else if (num2 == num1_tens)
            {
                System.Console.WriteLine("Second number is present in tens place of first number");
            }
            else if (num2 == num1_hundreds)
            {
                System.Console.WriteLine("Second number is present in hundreds place of first number");
            }
            else if (num2 == num1_thousands)
            {
                System.Console.WriteLine("Second number is present in Hundreds place of first number");
            }            
        }
    }
}