using System;

namespace Controle_Statements{
    public class Assessment3{
        public static void Main(string[] args)
        {
            int[] arr = new int[10];
            for (int i = 0; i < 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 10; i++)
            {
                System.Console.Write(arr[i]+" ");
            }
        }

    }
}