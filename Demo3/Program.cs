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

        }
    }
}
