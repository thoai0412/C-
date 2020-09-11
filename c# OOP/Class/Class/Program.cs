using System;

namespace Class
{
    class Animal
    {
        public double Weight;
        public double Height;
        public void Info()
        {
            // các phương thức bên trong lớp có thể gọi đến các thành phần khác
            // giá trị các thuộc tính này có thể được khỏi tạo đâu đó trong lớp hoặc từ bên ngoài truyền vào 
            Console.WriteLine("Height: " + Height + " Weight: " + Weight);
            // các phương thức bên trong lớp có thể gọi đến các thành phần khác trong lớp đó
        }
    }
    class Cat
    {
        public double Weight;
        public double Height;
       
        public Cat()  // Khởi tạo constructor không có tham số
        {
            Weight = 800;
            Height = 100;
        }
        public Cat (int w, int h) // constructor có tham số
        {
            
            Weight = w;
            Height = h;
            // mọi đối tượng đều có 3 thành phần
            // sài constructor
            //class có class mang thuộc tính gồm chiều cao và chiều dài
        }
        public void Info()
        {
            Console.WriteLine("Height: " + Height + " Weight: " + Weight);
            // và 1 phương thức la run để hiển thị ra
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            //Animal Dog = new Animal();
            //// khoi tao mot object
            //Dog.Weight = 20;
            //// truyen gia tri cho object
            //Dog.Height = 50;
            //Dog.Info();
            ////goi phuong thuc cua doi tuong
            Cat BlackCat = new Cat();
            BlackCat.Info();

            Cat WhiteCat = new Cat(1200, 30);
            // gọi đến constructor có tham số và truyền vào tham số cho nó
            // yêu cầu phải truyền đủ tham số w và h được khai báo trên constructor
            WhiteCat.Info();
            Console.ReadKey();
        }
    }
}
