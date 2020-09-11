using System;

namespace struct_trong_cshrap
{
    struct SinhVien
    {
        public int MaSo;
        public string HoTen;
        public double DiemToan;
        public double DiemLy;
        public double DiemVan;
    }

    private static void NhapThongTinSinhVien(out SinhVien SV)
    {
        Console.Write(" Ma so: ");
        SV.MaSo = int.Parse(Console.ReadLine());
        Console.Write(" Ho ten: ");
        SV.HoTen = Console.ReadLine();
        Console.Write(" Diem toan: ");
        SV.DiemToan = Double.Parse(Console.ReadLine());
        Console.Write(" Diem ly: ");
        SV.DiemLy = Double.Parse(Console.ReadLine());
        Console.Write(" Diem van: ");
        SV.DiemVan = Double.Parse(Console.ReadLine());
    }

    static void XuatThongTinSinhVien(SinhVien SV)
    {
        Console.WriteLine(" Ma so: " + SV.MaSo);
        Console.WriteLine(" Ho ten: " + SV.HoTen);
        Console.WriteLine(" Diem toan: " + SV.DiemToan);
        Console.WriteLine(" Diem ly: " + SV.DiemLy);
        Console.WriteLine(" Diem van: " + SV.DiemVan);
    }

    static double DiemTBSinhVien(SinhVien SV)
    {
        return (SV.DiemToan + SV.DiemLy + SV.DiemVan) / 3;
    }

    /*
     * với khai báo này ta có 1 kiểu dữ liệu mới tên là SinhVien. Có thể khai báo biến
     * sử dụng nó như sử dụng các kiểu dữ liệu khác.
     * Nếu như kiểu int có thể chưa số nguyrn, kiểu double có thể chứa số thực thì kiểu SinhVien vueà khai báo có thể chứa 5 trường thông tin con trong SinhVien
     */
    // Bên trong vẫn còn 2 khai báo chưa được nhắc đến đó là:
    // constructor (hàm khởi tạo) và các phương thức mà mình muốn cung cấp để hỗ trợ người dùng khi thao tác với dữ liệu trong struct.
    static void Main(string[] args)
        {
        // struct là kiểu dữ liệu có cấu trúc, được kết hợp từ các kiểu dữ liệu nguyên thủy do người lập trình định nghĩa để thuận tiện trong việc quản lýdữ liệu và lập trình.
        // là kiểu dữ liệu tham trị dùng để đóng gói các trường dữ liệu khác nhau nhưng có liên quan đến nhau
        // bên trong struct ngoài các biến có dữ liệu cơ bản còn có các phương thức, các struct khác.
        // muốn sử dụng phải khởi tạo cấp phát vùng nhớ cho đối tượng thông qua toán từ new
        // struct không được phép kế thừa
        /*
         * Khai báo và sử dụng
         * struct <tên struct >
         * { public <danh sách các biến>;
         * Trong đó < tên struct là kiểu dữ liệu do mình tự đặt và tuân thủ theo quy tắc đặt tên
         * <danh sách các biến> là danh sách các biến thành phần được khai báo như khai báo biến bình thường
         * từ khóa public là từ khóa chỉ định phạm vi truy cập. có thể hiểu từ khóa này giúp cho người khác có thể truy xuất được để sử dụng
         */
        SinhVien SV1 = new SinhVien();
        Console.WriteLine(" Nhap thong tin sinh vien: ");
        /*
         * Đây là hàm hỗ trợ nhập thông tin sinh viên.
         * Sử dụng từ khoá out để có thể cập nhật giá trị nhập được ra biến SV1 bên ngoài 
         * khi kết thúc gọi hàm (có thể xem lại bài Hàm trong C#).
         */
        NhapThongTinSinhVien(out SV1);
        Console.WriteLine("*********");
        Console.WriteLine(" Thong tin sinh vien vua nhap la: ");
        XuatThongTinSinhVien(SV1);
        Console.WriteLine(" Diem TB cua sinh vien la: " + DiemTBSinhVien(SV1));

        Console.ReadLine();
        }
    }
}
