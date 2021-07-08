using System;

namespace Controle_Statements{
    public class Assessment3{
        public static void Main(string[] args)
        {
            char givenChar = Convert.ToChar(Console.ReadLine());
            if ((givenChar >='a' && givenChar <= 'z') || (givenChar >= 'A' && givenChar <= 'Z'))
                {
                    System.Console.WriteLine("The given char is a Character");
                }else if(givenChar>='0' && givenChar<='9'){
                    System.Console.WriteLine("The given char is a Number");
                }
        }
    }
}