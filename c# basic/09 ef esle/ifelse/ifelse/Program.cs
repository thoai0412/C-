using System;

namespace ifelse
{
    class Program
    {
        static void Main(string[] args)
        {
            //string King = "KingDepTrai";

            //if (King == "KingDepTrai" ? true : false)
            //{
            //    Console.WriteLine("welcome to home king");
            //}    
            //else
            //{
            //    Console.WriteLine("comback later");
            //}
            //Console.ReadLine();
            string strA, strB;
            int A, B;
            double Nghiem;
            Console.Write("moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write(" moi nhap vao so B: ");
            strB = Console.ReadLine();
            if (int.TryParse(strA, out A) == false || int.TryParse(strB, out B) == false)
            {
                Console.WriteLine(" Du lieu nhap sai !");

            }
            else
            {
                Console.WriteLine("\n Phuong trinh cua ban vua nhap la: {0}x + {1} =0", A, B);
                if (A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem");
                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x = 0");

                }
                else
                {
                    Nghiem = (double)-B / A;
                    Console.WriteLine("\n phuong trinh co nghiem x = {0}", Nghiem);
                }
            }    

        }
    }
}
