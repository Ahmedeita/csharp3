using System.Xml.Linq;

namespace Demo3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Value Type Casting

            #region Implicit Casting - safe casting
            //int X =4 ; //4 Bytes
            //  long Y = X;
            // long y = /*(long)*/X; //ملهاش لازمة اضيف كاست هنا 
            //safe casting 

            #endregion

            #region Explicit Casting - Unsafe Casting
            //long X = 4154255541541541521; // 8 Bytes
            //int Y;
            //Checked
            //{
            // Y =(int) X; //OverFlow Exception //Runtime Error
            // }
            //Console.WriteLine(Y);

            //double X =88.8;
            //int Y = (int)X;
            //Console.WriteLine(Y); // will print without Fractions



            #endregion

            #region Parse [Convert from String To any DataType]
            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User");
            //Console.WriteLine("Enter Name : ");
            //String Name = Console.ReadLine();
            //Console.WriteLine("Enter Age : ");
            //int Age =int.Parse( Console.ReadLine());
            //Console.WriteLine("Enter Salary : ");
            //double Salary =double.Parse( Console.ReadLine());

            //Console.Clear();
            //Console.WriteLine("Name : " + Name);

            #endregion

            #region Convert [From Any to Any DataType]

            //int Number = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter Data User");
            //Console.WriteLine("Enter Name : ");
            //String Name = Console.ReadLine();
            //Console.WriteLine("Enter Age : ");
            //int Age =Convert.ToInt32( Console.ReadLine());
            //Console.WriteLine("Enter Salary : ");
            //double Salary =Convert.ToDouble( Console.ReadLine());



            #endregion


            #endregion

            #region Oprators
            #region Unary Operators [++, --]

            int x = 5;
            //X++; 

            //++X;
            //Console.WriteLine(++X); 

            //Console.WriteLine(X);

            //Console.WriteLine(--X);
            //Console.WriteLine(X); 

            //Console.WriteLine(X);

            #endregion

            #region Binary Operator
            //int Sum, Mul, Sub, Div, Mod; 

            //int A = 8;
            //int B = 5;

            //Sum = A + B; // 15
            //Sub = A - B; // 5
            //Div = A / B; // 2 
            //Mul = A * B; // 50
            //Mod = A % B; // 3
            //Console.WriteLine(Sum); 

            #endregion

            #region Assignment Operator
            //int X = 10; 

            //X += 10; // X = X + 10
            //X -= 10; // X = X - 10
            //X *= 10; // X = X * 10
            //X /= 10; // X = X / 10
            //X %= 10; // X = X % 10
            #endregion

            #region Relational Operators
            //int A = 5;
            //int B = 10;

            //Console.WriteLine(A < B); 
            #endregion

            #region Logical Operators [short circuit]
            //Console.WriteLine(!true); 

            //Console.WriteLine(true && false);
            // True && True => True
            // True && False => False
            // False && True => False
            // False && False => False

            //Console.WriteLine(true || false);
            // True || True => True
            // True || False => True
            // False || True => True
            // False || False => False
            #endregion

            #region Bitwise Operators [long circuit]
            //Console.WriteLine(true & false);
            // True & True => True
            // True & False => False
            // False & True => False
            // False & False => False

            //Console.WriteLine(true || false);
            // True | True => True
            // True | False => True
            // False | True => True
            // False | False => False
            #endregion

            #region Ternary Operator [Conditional Operator]

            //int X = 3;

            //string Message = X > 4 ? "X Greater Than 4" : "X Less than Or Equal 4";
            //Console.WriteLine(Message);

            #endregion

            #endregion

            #region Operator Periority
            /*
             * Unary Operator prefix
             * ( )
             * * / %
             * + -
             */
            //int A = 20;
            //int B = 15;
            //int C = 10;
            //int D = 5;

            //int Result = (A + B) * C / D;
            //Result = A ++ * C;
            ////Result = A * C;

            //Console.WriteLine( Result);
            #endregion

            #region String Formatting

            // Equation = X + Y = Result 
            // Equation = 10 + 5 = 15 

            //int X = 5;
            //int Y = 10;
            //int Result = X + Y;

            //Console.WriteLine("Equation : " + X + "+" + Y + "=" + Result); 

            // String => Immutable Datatype
            //string Name = "Ahmed";
            //Name = "Ali"; 

            #region 1. Composite Format
            //string Message = string.Format("Equation = {0} + {1} = {2}", X, Y, Result);

            //Console.WriteLine(Message);
            //Console.WriteLine("Equation = {0} + {1} = {2}", X, Y, Result);

            #endregion

            #region 2. String Manipolition 
            // string Interpolation => $

            // Console.WriteLine($"Equation = {X} + {Y} = {Result}");

            #endregion

            #endregion


            #region IF - Switch
            //Console.WriteLine("Enter Month Number");
            //int MonthNumber = int.Parse(Console.ReadLine());

            //// 1 => Month is Jan
            //// 2 => Month is Feb
            //// 3 => Month is Mar
            //// Invalid Input

            //if (MonthNumber == 1)
            //{
            //    Console.WriteLine("Month is Jan");
            //}
            //else if (MonthNumber == 2)
            //{
            //    Console.WriteLine("Month is Feb");
            //}
            //else if (MonthNumber == 3)
            //{
            //    Console.WriteLine("Month is Mar");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid Input");
            //}



            //switch (MonthNumber)
            //{
            //    case 1:
            //        Console.WriteLine("Month is Jan");
            //        break;
            //    case 2:
            //        Console.WriteLine("Month is Feb");
            //        break;
            //    case 3:
            //        Console.WriteLine("Month is Mar");
            //        break;
            //    default:
            //        Console.WriteLine("Invalid Input");
            //        break;
            //}


            //Console.WriteLine("Enter Name");
            //string Name = Console.ReadLine();

            //if (Name == "Mostafa")
            //{
            //    Console.WriteLine("Hello Mostafa");
            //}
            //else if (Name == "Aliaa")
            //{
            //    Console.WriteLine("Hello Aliaa");
            //}
            //else if (Name == "Ahmed")
            //{
            //    Console.WriteLine("Hello Ahmed");
            //}


            //switch (Name)
            //{
            //    case "Mostafa":
            //        Console.WriteLine("Hello Mostafa");
            //        break;
            //    case "Aliaa":
            //        Console.WriteLine("Hello Aliaa");
            //        break;
            //    case "Ahmed":
            //        Console.WriteLine("Hello Ahmed");
            //        break;

            //}


                    #endregion



            }
    }
}
