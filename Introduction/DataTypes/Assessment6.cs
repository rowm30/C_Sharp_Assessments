using System;

namespace Datatypes{
    public class Assessment6{
        public static void Main(string[] args)
        {
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());

            // num1 and num 2 swap integers
            func3(num1,num2);
            System.Console.Write("The number after swaped: ");
            System.Console.WriteLine(num1 + " and " + num2);

            System.Console.WriteLine("The numbers after first operation: " + func1(num1,num2));
            System.Console.Write("The numbers after second operation: " + func2(num1,num2));
        }

        public static int func1(int num1,int num2){
            num2 = ++num1;
            return num1;
        }

        public static int func2(int num1,int num2){
            num2 = num1++;
            return num1;
        }
        public static void func3(int num1,int num2){
            int temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}