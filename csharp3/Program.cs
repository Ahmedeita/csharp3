using System.ComponentModel;
using System.Xml.Linq;

namespace Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            //1. Write a program that takes a number from the user then print yes if that number can be divided by 3 and 4 otherwise print no.
            //Console.Write("Enter Number : ");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num % 3 == 0 && Num % 4 == 0)
            //    Console.WriteLine("Yes");
            //else
            //    Console.WriteLine("No");

            #endregion

            #region Q2
            //Write a program that allows the user to insert an integer then print negative if it is negative number otherwise print positive.
            //Console.Write("Enter Integer Number : ");
            //int Num = int.Parse(Console.ReadLine());

            //if (Num < 0)
            //    Console.WriteLine("Negative");
            //else if (Num > 0)
            //    Console.WriteLine("Positive");
            //else
            //    Console.WriteLine("Zero");

            #endregion

            #region Q3
            //3 - Write a program that takes 3 integers from the user then prints the max element and the min element.
            int Num1, Num2, Num3, Max, Min ;
            Console.Write("Enter the first number: ");
            Num1 = int.Parse(Console.ReadLine());
            Console.Write("Enter the second number: ");
            Num2 = int.Parse(Console.ReadLine());
            Console.Write("Enter the third number: ");
            Num3 = int.Parse(Console.ReadLine());

             Max = Num1 > Num2 ? (Num1 > Num3 ? Num1 : Num3) : (Num2 > Num3 ? Num2 : Num3);
             Min = Num1 < Num2 ? (Num1 < Num3 ? Num1 : Num3) : (Num2 < Num3 ? Num2 : Num3);

            Console.WriteLine( $"Max is {Max}");
            Console.WriteLine($"Min is {Min}");
            #endregion
        }
    }
}
