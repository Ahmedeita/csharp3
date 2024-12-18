using System.ComponentModel;
using System.Transactions;
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
            //int Num1, Num2, Num3, Max, Min ;
            //Console.Write("Enter the first number: ");
            //Num1 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the second number: ");
            //Num2 = int.Parse(Console.ReadLine());
            //Console.Write("Enter the third number: ");
            //Num3 = int.Parse(Console.ReadLine());

            // Max = Num1 > Num2 ? (Num1 > Num3 ? Num1 : Num3) : (Num2 > Num3 ? Num2 : Num3);
            // Min = Num1 < Num2 ? (Num1 < Num3 ? Num1 : Num3) : (Num2 < Num3 ? Num2 : Num3);

            //Console.WriteLine( $"Max is {Max}");
            //Console.WriteLine($"Min is {Min}");
            #endregion

            #region Q4
            //4- Write a program that allows the user to insert an integer number then check If a number is even or odd.
            //Console.Write("Enter a Number : ");
            //Console.WriteLine( int.Parse(Console.ReadLine()) % 2 == 0 ? "even" : "odd" );

            #endregion

            #region Q5
            //Write a program that takes character from the user then if it is a vowel chars (a,e,I,o,u) then print (vowel) otherwise print (consonant).
            //Console.Write("Enter Character : ");
            //char Character = char.Parse(Console.ReadLine());
            //switch (char.ToLower(Character))
            //{
            //    case 'a':
            //    case 'e':
            //    case 'i':
            //    case 'o':
            //    case 'u':
            //        Console.WriteLine("Vowel");
            //        break;
            //    default:
            //        Console.WriteLine("consonant");
            //        break;
            //}


            #endregion

            #region Q6-Number7-
            //7- Write a program that allows the user to insert an integer then print a multiplication table up to 12.
            //Console.Write("ENTER THE NUMBER : ");

            //int Num = int.Parse(Console.ReadLine());

            //int i = 1;
            //while (i <= 12)
            //    Console.WriteLine($"{Num} * {i} = {Num*i++}");



            #endregion

            #region Q7-Number9-
            //9- Write a program that takes two integers then prints the power.
            //Console.Write("Enter the Number : ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter the exponent x : ");
            //int x = int.Parse(Console.ReadLine());

            //int result=1;
            //int i = 0;
            //while (i < x)
            //{
            //    result *= num;
            //    i++;
            //}
            //Console.WriteLine($"{num} ^ {x} = {result} ");

            #endregion

            #region Q8-Number10-
            //10- Write a program to enter marks of five subjects and calculate total, average and percentage.
            //Console.Write("Mark of Subject 1");
            //int Subject1 = int.Parse(Console.ReadLine());
            //Console.Write("Mark of Subject 2");
            //int Subject2 = int.Parse(Console.ReadLine());
            //Console.Write("Mark of Subject 3");
            //int Subject3 = int.Parse(Console.ReadLine());
            //Console.Write("Mark of Subject 4");
            //int Subject4 = int.Parse(Console.ReadLine());
            //Console.Write("Mark of Subject 5");
            //int Subject5 = int.Parse(Console.ReadLine());

            //int Total = Subject1 + Subject2 + Subject3 + Subject4 + Subject5;

            //Console.WriteLine($"Total is {Total}");
            //Console.WriteLine($"Average is {Total / 5}");
            //Console.WriteLine($"Percentage is {Total / 5} %");

            #endregion

        }
    }
}
