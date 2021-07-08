using System;

namespace Controle_Statements{
    public class Assessment3{
        public static void Main(string[] args)
        {
            System.Console.Write("Enter the size of the array: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            int[] newArr = new int[n];

            for (int i = n-1,j=0; i >= 0&& j<n; i--,j++)
            {
                newArr[j] = arr[i];
            } 
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(newArr[i]+" ");
            }
        }
    }
}