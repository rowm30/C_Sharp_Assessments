using System;

namespace Controle_Statements{
    public class Assessment1{
        public static void Main(string[] args)
        {
            string givenString = Console.ReadLine();
            System.Console.WriteLine(isPalindrome(givenString));
        }

        public static bool isPalindrome(string str){
            int l = 0;
            int h = str.Length - 1;
            while (l <= h)
            {
                if (str[l++] != str[h--])
                {
                    return false;
                }
            }
            return true;
        }
    }
}