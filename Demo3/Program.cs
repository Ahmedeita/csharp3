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


            #endregion

        }
    }
}
