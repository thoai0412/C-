using System;

namespace bao_keo_bua_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int random = r.Next(1, 4);
            int n;
            do
            {
                Console.WriteLine("moi cac ban chon {0} - Keo, {1} - bua, {2} -bao", 1, 2, 3);
                n = int.Parse(Console.ReadLine());
                if (n < 0 || n > 3)
                {
                    Console.WriteLine("ban nhap khong du");
                    Console.WriteLine("moi cac ban chon:{0} - Keo, {1} - bua, {2} - Bao", 1, 2, 3);
                    n = int.Parse(Console.ReadLine());
                }
                else
                {
                    if (n == 1)
                    {
                        Console.WriteLine("nguoi ra keo");
                        break;
                    }
                    else if(n == 2)
                    {
                        Console.WriteLine("nguoi ra bua");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("nguoi ra bao");
                        break;
                    }
                } 
            }
            while (n != 0);
            if (random == 1)
            {
                Console.WriteLine("may ra keo");
            }
            else if (random == 2)
            {
                Console.WriteLine("may ra bua");
            }
            else
            {
                Console.WriteLine("may ra bao");
            }
            if ((n == 1 && random == 1) || (n == 2 && random == 2) || (n == 3 && random == 3))
            {

                Console.WriteLine("May va nguoi hoa");

            }

            if ((n == 1 && random == 2) || (n == 2 && random == 3) || (n == 3 && random == 1))
            {

                Console.WriteLine("May thang");

            }

            if ((n == 1 && random == 3) || (n == 2 && random == 1) || (n == 3 && random == 2))
            {

                Console.WriteLine("Nguoi thang");

            }
        }
    }
}
