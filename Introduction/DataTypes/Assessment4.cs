using System;

namespace DataTypes
{
    public class Assessment4
    {
        public static void Main(string[] args)
        {
            string givenString = Console.ReadLine();
            System.Console.WriteLine("The word in lower case: " + givenString.ToLower());
            System.Console.WriteLine("The word in upper case: " + givenString.ToUpper());
        }    
    }
}