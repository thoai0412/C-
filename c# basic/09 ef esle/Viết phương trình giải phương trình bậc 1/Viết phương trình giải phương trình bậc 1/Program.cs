using System;

namespace Viết_phương_trình_giải_phương_trình_bậc_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string strA, strB;
            // khai báo dữ liệu nhập vào
            int A, B;
            //biến để lưu dữ liệu đã được chuyển đổi
            double Nghiem;
            //biến lưu kết quả
            // double kiểu số thực chấm động 8bytes
            Console.Write("moi nhap so A: ");
            strA = Console.ReadLine();
            Console.Write("moi nhap so B: ");
            strB = Console.ReadLine();
            if (int.TryParse(strA, out A) == false || int.TryParse(strB,out B)== false)
                // sử dụng TryParse để ép kiểu dữ liệu
                //chuyển đổi một chuổi sang một kiểu dữ liệu tương ứng
                // chuyển kiểu dữ liệu nhập vào là string sang kiểu dũ liệu là int
                // nếu là fasle thì in ra là sai
            {
                Console.WriteLine(" du lieu nguoi dung nhap sai !");

            }
            else
            {
                //nếu nhập vào là đúng thì ta bắt đầu tính giá trị nhập vào
                Console.WriteLine("\n Phuong trinh cua ban vua nhap la: {0}x {1}=0", A, B);
                if (A == 0)
                {
                    Console.WriteLine("\n Phuong trinh co vo so nghiem !");

                }
                else if (B == 0)
                {
                    Console.WriteLine("\n Phuong trinh co nghiem x=0");

                }
                else
                {
                    Nghiem = (double)-B / A;
                    Console.WriteLine("\n Phuong trinh co nghiem x={0}", Nghiem);
                }
            }
        }
    }
}
