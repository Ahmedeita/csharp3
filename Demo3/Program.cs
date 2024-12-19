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





            #endregion

        }
    }
}
