using System;
public class Assessment2
{
    public static void Main()
    {
        string str;
        int alphabet, digit, specialchar, i, l;
        alphabet = digit = specialchar = i = 0;

   
        str = Console.ReadLine();
        l = str.Length;

        while (i < l)
        {
            if ((str[i] >= 'a' && str[i] <= 'z') || (str[i] >= 'A' && str[i] <= 'Z'))
            {
                alphabet++;
            }
            else if (str[i] >= '0' && str[i] <= '9')
            {
                digit++;
            }
            else
            {
                specialchar++;
            }

            i++;
        }

        Console.WriteLine(alphabet);
        Console.WriteLine( digit);


        Console.ReadLine();
    }
}