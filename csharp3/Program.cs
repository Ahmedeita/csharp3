using System.ComponentModel;
using System.Drawing;
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

            #region Q9-NUMBER 11
            //11- Write a program to input the month number and print the number of days in that month.


            /*  // WE CAN USE ARRAY 
              int [] DaysInMonths ={ 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
             Console.Write("Enter The Month : ");
             Console.WriteLine(DaysInMonths[int.Parse(Console.ReadLine())-1]); 
            */

            //We Can Use Switch
            //Console.Write("Enter The Month : ");
            //int Month = int.Parse(Console.ReadLine());
            //switch (Month)
            //{
            //    case 1:
            //    case 3:
            //    case 5:
            //    case 7:
            //    case 8:
            //    case 10:
            //    case 12:
            //        Console.WriteLine("31");
            //        break;
            //    case 2:
            //        Console.WriteLine("28 if leap year it's 29 ");
            //        break;
            //    case 4:
            //    case 6:
            //    case 9:
            //    case 11:
            //        Console.WriteLine("30");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid input");
            //        break;
            //}
            #endregion

            #region Q10 - Number - 17
            //17- Create a program that asks the user to input three points (x1, y1), (x2, y2), and (x3, y3), and determines whether these points lie on a single straight line.
            //Console.Write("Enter x1: ");
            //double x1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y1: ");
            //double y1 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x2: ");
            //double x2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y2: ");
            //double y2 = double.Parse(Console.ReadLine());
            //Console.Write("Enter x3: ");
            //double x3 = double.Parse(Console.ReadLine());
            //Console.Write("Enter y3: ");
            //double y3 = double.Parse(Console.ReadLine());


            //String Message = ((y2 - y1) / (x2 - x1)) == (y3 - y2) / (x3 - x2) ? "The points lie on a single straight line." : "The points do not lie on a single straight line.";

            //Console.WriteLine(Message);
            #endregion

            #region Q11 - Number - 18
            /*
             *18- Within a company, the efficiency of workers is evaluated based on the duration required to complete a specific task. A worker's efficiency level is determined as follows: 
                - If the worker completes the job within 2 to 3 hours, they are considered highly efficient. 
                - If the worker takes 3 to 4 hours, they are instructed to increase their speed. 
                - If the worker takes 4 to 5 hours, they are provided with training to enhance their speed. 
                - If the worker takes more than 5 hours, they are required to leave the company. 
                To calculate the efficiency of a worker, the time taken for the task is obtained via user input from the keyboard.
 
             */
            //Console.Write("Enter the time taken for the task: ");
            //double time = double.Parse(Console.ReadLine());

            //if (time >=2 && time <3 )
            //    Console.WriteLine("highly efficient");
            //else if (time >= 3 && time < 4)
            //    Console.WriteLine("increase your speed");
            //else if (time >= 4 && time < 5)
            //    Console.WriteLine("training to enhance your speed.");
            //else if (time >= 5)
            //    Console.WriteLine("leave the company.");
            //else Console.WriteLine("Invalid !!! " );



            #endregion

            #region Q12 - Number - 21
            //21-	Write C# program that Assigning one value type variable to another and modifying the value of one variable and mention what will happen
            //int x = 12;
            //int y = x; // Make a copy of x at y 
            //Console.WriteLine($"before Modification X is {x} , Y is {y}");
            //x = 50;
            //Console.WriteLine($"After Modification X is {x} , Y is {y}");

            /*what happened
             * in value type when you modify variable don't affect on the other one
             */
            #endregion

            #region Q13 - Number - 22
            //22-	Write C# program that Assigning one reference type variable to another and modifying the object through one variable and mention what will happen
            //point R1 = new point(); // Define 1st Variable
            //point R2 = R1;                       // Define 2nd Variable and assign variable 1 to variable 2

            //Console.WriteLine("values before modifications");  // Print before modifications
            //Console.WriteLine("Variable 1: " + R1.x);
            //Console.WriteLine("Variable 2: " + R2.x);


            //R1.x = 524;                // Modify 1st Variable

            //Console.WriteLine("values after modifications"); // Print after modifications
            //Console.WriteLine("Variable 1: " + R1.x);
            //Console.WriteLine("Variable 2: " + R2.x);

            ////Modifications will reflect on the both Variables because both refer to the same address as a reference type
            #endregion
        }
    }

    class point
    {//Q13 - 21
        public int x;
    }
}
