using System;

namespace Switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            int k = 10;
            switch (k)
                // bieu thuc la gia tri k truyen vao
            {
                case 3:
                    // gia tri cua k truyen vao neu thoa man thi
                    Console.WriteLine("king dep trai");
                    // in ra ket qua
                    break;
                    // pha vo vong lap
                case 9:
                    Console.WriteLine("king dep trai vcl");
                    break;
                case 10:
                    Console.WriteLine("dinh cua dinh");
                    break;

                    // ngoai ra 
                    // neu tat ca case khong thoa man duoc thi switch se chay vao default
                default:
                    Console.WriteLine(" king is god");
                    break;
            }

        }
    }
}
