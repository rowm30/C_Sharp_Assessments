using System;

namespace DataTypes{
    public class Assessment5{
        public static void Main(String[] args){
            string givenString = Console.ReadLine();
            char[] arr = new char[givenString.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = givenString[i];    
            }

            System.Console.Write("The reversed string: ");

            for (var i = arr.Length-1; 0 <=i ; i--)
            {
                System.Console.Write(arr[i]);
            }

            System.Console.WriteLine("");
            System.Console.Write("The extracted string is: ");

            for (var i = 1; i < arr.Length; i++)
            {
                System.Console.Write(arr[i]);
            }

            System.Console.WriteLine("");
            System.Console.Write("The replaced charater string is: ");

                System.Console.Write("$");
            for (var i = 1; i < arr.Length; i++)
            {
                System.Console.Write(arr[i]);
            }

            System.Console.WriteLine("");
            System.Console.Write("The modified string is: ");

                System.Console.Write("N");
            for (var i = 1; i < arr.Length; i++)
            {
                System.Console.Write(arr[i]);
            }

            System.Console.WriteLine("");
            System.Console.Write("The original string: ");
            System.Console.Write(givenString);
        }
    }
}