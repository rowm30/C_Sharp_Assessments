using System;

namespace DataTypes
{
    public class Assessment3
    {
        public static void Main(){
            String givenString = Console.ReadLine();
            char[] arr = new char[givenString.Length];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = givenString[i];    
            }
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i]++;
            }
            for (var i = 0; i < arr.Length; i++)
            {
                System.Console.Write(arr[i]);
            }
        }
    }
}