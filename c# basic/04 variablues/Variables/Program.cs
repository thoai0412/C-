using System;

namespace Variables
{
    class Program
    {
        static void Main(string[] args)
        {
            int aNum = 5; 
            int bNum = 100;
            int cNum = aNum + bNum;
            Console.WriteLine("a + b= c: {0}+{1}={2}", aNum, bNum, cNum);
            Console.ReadKey();

            /*
             * là một giá trị dữ liệu có thể thay đổi được
             * là tên gọi tham chiếu đến một vùng nhớ nào đó trong bộ nhớ.
             * là thành phần cốt lõi của một ngôn ngữ lập trình.
             */
             // tại sao phải sử dụng biến ?
             /*
              * lưu trữ dữ liệu và tái sử dụng: ví dụ hãy tưởng tượng nếu bạn yêu cầu người nhập vào tuổi của họ, nhưng bạn không lưu trữ lại thì đến khi bạn muốn sử dụng thì chẳng biết lấy đâu ra để sử dụng cả.
              * Thao tác với bộ nhớ một cách dễ dàng:
              * Cấu trúc của bộ nhớ boa gồm nhiều ô nhớ liên tiếp nhau, mỗi ô nhớ có một địa chỉ riêng (địa chỉ ô nhớ thường mã hex(thập lục phân)).
              * khi muốn sử dụng ô nhớ nào (cấp phát, hủy, lấy giá trị,...) bạn phải thông qua địa chỉ của chúng. Điều này làm cho việc lập trình trở nên khó khăn hơn.
              * Thay vào đó bạn có thể khai báo một biến và cho nó tham chiếu đến ô nhớ bạn cần quản lý rồi khi sử dụng bạn sẽ dùng tên biến bạn đặt chứ không cần dùng địa chỉ của ô nhớ đó nữa.
              * khai báo sử dụng biến 
              * Cú pháp:
              * <kiểu dữ liệu> <tên biến>;
              * Trong đó kiểu dữ liệu là dữ liệu cơ bản
              * tên biến là tên biến do người dùng đặt
              * phải tuân thủ quy tắc đặt tên
              * int KieuSoNguyen
              * float KieuSOThuc
              * String KieuChuoi
              * bool KieuLuanLy
              * Char KieuKyTu
              * Trong đó:
              * Kiểu dữ liệu là: int, float, string, bool, char
              * Tên biến là: KieuSoNguyen, KieuSoThu...bla bla
              * sử dụng:
              * để sử dụng biến ta cần phải gán giá trị cho nó trước. Có 2 cách gán giá trị:
              * Khởi tạo giá trị lúc khai báo:
              * int BienKiéuoNguyen =10;
              * string BienKieuChuoi = "kingdeptrai";
              * gán giá trị theo cú pháp
              * <tên biến> = <giá trị>;
              * khi bạn muốn gọi ra một biến ra để lấy giá trị thì bạn chỉ cần gọi tên của nó ra là được. Ví dụ:
              * console.WriteLine(BienKieuSoNguyen);
              * hoặc int a = 1, b = 2;
              * int c = a +b;
              * hoặc int a = 1, b = 2;
              * int c = a + b;
              * biến a và biến b được gọi để lấy giá trị sau đó cộng chúng lại rồi gán cho biến c.
              * Quy tắc đặt tên biến
              * một số quy tắc khi đặt tên biến cũng như là các định danh khác:
              * tên biến là một chuỗi ký tự liên kết không có khoảng trắng và không chứa ký tự đặc biệt.
              * tên biến không được đặt bằng tiếng việt có đâu.
              * tên không được bắt đầu bằng số.
              * tên biến không được trùng nhau.
              * tên biến không được trùng với từ khóa:
              * dưới đây là danh sách các từ khóa trong c#, các bạn chỉ cần nắm để tránh đặt tên trùng với từ khóa còn việc mặt ý nghĩa từ khóa sẽ được trình bày trong suốt các bài học sau này.
              * ngoài ra các lập trình viên cũng đưa ra một số quy tắc chung trong việc đặt tên để dễ quản lý và giúp cho người khác có thể dễ dàng đọc code của mình
              * quy tắc lạc đà
              * viết thường chữ cái đầu tiên và viết hoa chữ cái đầu tiên của những từ tiếp theo
              * thường được dùng để đặt tên cho các biến có phạm vi truy cập là private hoặc protected ( phạm vi truy cập sẽ được trình bày chi tiết trong class ) và các tham số của hàm.
              * Qhy tắc Pascal viết hoa chữ cái đầu tiên của mỗi từ.
              * thường được dùng để đặt tên cho những thành phần còn lại như hàm, interface, enum, sự kiện
              * một số lưu ý khi đặt tên biến:
              * nên đặt tên gắn gọn dễ hiểu, thể hiện rõ mục đích của biến.
              * không đặt tên biến bằng một ký tự như i, k, m.. như vậy sau này khi xem lại code hoặc đưa code cho người khác đọc thì chúng ta sẽ không hiểu biến này dùng để làm gì. Trừ những trường hợp đặc biệt.
              * C# có phân biệt chữ hoa chữ thường. Ví dụ biến a khác biến A hoặc tập lệnh Console.Writeline() khác lệnh console.WRITELINE().
              */
        }
    }
}
