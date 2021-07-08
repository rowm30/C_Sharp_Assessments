using System;

namespace Controle_Statements{
    public class Assessment3{
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (var i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            System.Console.WriteLine(sizeOfArr(arr,n));
        }
        public static int sizeOfArr(int[] arr,int n){
            int numberOfElements = 0;

            for (var i = 0; i < n; i++)
            {
                if (arr[i] > 0)
                {
                    numberOfElements++;
                }
            }
            return numberOfElements;
        }
    }
}