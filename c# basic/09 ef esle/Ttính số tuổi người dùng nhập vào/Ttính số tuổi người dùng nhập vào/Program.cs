using System;

namespace Ttính_số_tuổi_người_dùng_nhập_vào
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA;
            int A;
            int today = 2020;
            int age ;
            Console.WriteLine(" Tinh so tuoi nguoi dung nhap vao");
            Console.Write("moi nhap vao nam sinh cua ban: ");
            strA = Console.ReadLine();
            if (int.TryParse(strA, out A) == false || A > today == true || A < 1930 == true)
            {
                Console.WriteLine("nhap sai xin moi nhap lai");
            }
            else
            {
                age = today - A;
                Console.WriteLine("\n tuoi cua ban la: {0}", age);
                if (age < 16 == true)
                {
                    Console.WriteLine("\n tuoi cua ban la tuoi vi thanh nien");
                }
                else if (age >= 18 == true)
                {
                    Console.WriteLine("\n ban da qua gia");
                }
                else
                {
                    Console.WriteLine("\n tuoi cua ban la tuoi truong thanh");
                }
            }
            

        }
    }
}
