using System;

namespace DataTypes
{
    class Assessment1
    {
        static void Main(string[] args){
            System.Console.Write("Enter the side of the square: ");
            int a = Convert.ToInt32(Console.ReadLine());
            System.Console.Write    ("The area of the square is: ");
            Console.WriteLine(a * a);
        }
    }
}