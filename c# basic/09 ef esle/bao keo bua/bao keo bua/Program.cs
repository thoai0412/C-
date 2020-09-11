using System;

namespace bao_keo_bua
{
    class Program
    {
        static void Main(string[] args)
        {
            string you, computer = "";
            Random random = new Random();
            int num = random.Next(3);

            Console.WriteLine("Ban chon: ");
            you = Console.ReadLine();
            if ((you != "Bua") && (you != "Keo") && (you != "La"))
            {
                Console.WriteLine("Nhap sai, moi nhap lai");
            }
            if (num == 0)
            {
                computer = "Bua";
            }
            if (num == 1)
            {
                computer = "La";
            }
            if (num == 2)
            {
                computer = "Keo";
            }
            Console.WriteLine("May chon: {0}", computer);
            if (you == computer)
            {
                Console.WriteLine("Hoa");
            }
            else if (computer == "Bua")
            {
                if (you == "Keo")
                {
                    Console.WriteLine("ban thua");
                }
                else
                {
                    Console.WriteLine("Ban thang");
                }
            }
            else if (computer == "La")
            {
                if (you == "Keo")
                {
                    Console.WriteLine("ban thang");
                }
                else
                {
                    Console.WriteLine("Ban thua");
                }
            }
            else if (computer == "Keo")
            {
                if (you == "La")
                {
                    Console.WriteLine("ban thua");
                }
                else
                {
                    Console.WriteLine("Ban thang");
                }
            }
            Console.ReadKey();
        }
    }
}
