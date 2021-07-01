using System;

namespace DataTypes
{
    public class Assessment2{
        public static void Main(){
            System.Console.Write("Write the desired string: ");
            string givenString = Console.ReadLine();
            int numberOfAlphabets = 0;
            int numberOfDigit = 0;
            int numberOfSpecialChars = 0;

            for (var i = 0; i < givenString.Length; i++)
            {
                if ((givenString[i]>='a' && givenString[i] <= 'z') || (givenString[i] >= 'A' && givenString[i] <= 'Z'))
                {
                    numberOfAlphabets++;
                }else if(givenString[i]>='0' && givenString[i]<='9'){
                    numberOfDigit++;
                }else
                {
                    numberOfSpecialChars++;
                }
            }
            Console.Write("The number of alphabets in the string: ");
            System.Console.WriteLine(numberOfAlphabets);
            Console.Write("The number of digits in the string: ");
            System.Console.WriteLine(numberOfDigit);
            Console.Write("The number of special characters in the string: ");
            System.Console.WriteLine(numberOfSpecialChars);
            
        }
    }
}