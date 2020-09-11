using System;

namespace Data_Types
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data types Kiểu dữ liệu trong c#");
            /* là tập hợp các nhóm dữ liệu có cùng đặc tính, cách lưu trữ và thao tác xử lý trên trường dữ liệu đó.
             * là một tín hiệu để trình biên dịch nhận biết kích thước của một biến và khả năng của nó
             * là thành phần cốt lõi của một ngôn ngữ lập trình.
             * tại sao lại có kiểu dữ liệu
             * như trong dịnh nghĩa đã trình bày, phải có kiểu dữ liệu dể nhận biết kích thước và khả năng của một biến.
             * nhằm mục đích phân loại dữ liệu. Nếu như không có kiểu dữ liệu ta rất khó xử lý vì không biết biến này kiểu chuỗi hay kiểu số nguyên hay kiểu số thực,..
             * Phân loại kiểu dữ liệu và ý nghĩa của từng kiểu dữ liệu
             * Trong c# kiểu dữ liệu được chia thành 2 tập hợp kiểu dữ liệu chính:
             * kiểu dữ liệu dựng sẵn (built - in) mà ngôn ngữ cung cấp.
             * Kiểu dữ liệu do người dùng định nghĩa (user - defined).
             * một tâp hợp kiễu dữ liệu trên lại phân thành 2 loại:
             * Kiểu dữ liệu value ( giá trị):
             * một variables khi khai báo data types value thì vùng nhớ của variable của biến đó sẽ chưa giá trị của dữ liệu và được lưu trữ trong bộ nhớ stack.
             * Một số kiểu dữ liệu thuộc kiểu giá trị:bool, byte, char, decimal, double, enum, float, int, long, sbyte, short, struct, unit, ulong, ushort. (các kiểu dữ liệu này sẽ được trình bày ngay sau đây)
             * kiểu dữ liệu reference (kiêu dữ liệu tham chiếu)
             * đối tượng khi khai báo kiểu dự liệu tham chiếu thì vùng nhớ của variable đó chỉ chứa địa chỉ của đối tượng dữ liệu và lưu trong bộ nhớ stack
             * đối tượng dữ liệu thực sự được lưu trong bộ nhớ Heap.
             * Một số kiểu dữ liệu thuộc kiểu tham chiếu: object, dynamic, string và tất cả các kiểu dữ liệu do người dùng định nghĩa.
             * stack:
             * là vùng nhớ được cấp phát khi chương trình biên dịch.
             * được sử dụng cho việc thực thi thread khi gọi hàm các biến cục bộ kiểu giá trị và tự động giải phóng khi không còn sử dụng nữa.
             * kích thước vùng nhớ stack là cố định và chúng ta không thể thay đổi.
             * khi vùng nhớ này không còn đủ dùng thì sẽ gây ra hiện tượng tràn bộ nhớ(stack overflow). Hiện tượng này xảy ra khi nhiều hàm lồng vào nhau hoặc gọi đệ quy nhiều lần dẫn đến không đủ vùng nhớ.
             * heap:
             * vùng nhớ được cấp phát khi chạy chương trình.
             * vùng nhớ heap được dùng cho cấp phát bộ nhớ động
             * bình thường vùng nhớ trong heap do người dùng tự giải phóng nhưng trong c# điều này được hỗ trợ mạnh mẽ bởi tự động thu gom rác. Vì thế việc giải phóng vùng nhớ sẽ được thực hiện tự động. kích thước vùng nhớ Heap có thể thay đổi được. khi không đủ vùng nhớ để cấp phát thì hệ điều hành sẽ tự động tăng kích thước vùng nhớ Heap lên.
             * Các kiểu dữ liệu dựng sẵn cơ bản:
             * Kiểu số nguyên: byte, sbyte,short, ushort, int, uint, long, ulong,
             * kiểu ký tự: char,
             * kiểu logic:bool
             * Kiểu số thực: float, double decimal
             * khác với những kiểu dữ liệu trên, string là kiểu dữ liệu tham chiếu và dùng để lưu chuỗi ký tự.
             * một sô lưu ý
             * kiễu dữ liệu có miền giá trị lớn hơn sẽ chứa được kiểu dữ liệu có miền giá trị nhỏ hơn. như vậy biến kiểu dữ liệu nhỏ hơn có thể gán giá trị qua biến kiểu dữ liệu lớn hơn
             * giá trị của kiểu char sẽ nằm trong dấu ''
             * giá trị của kiểu string sẽ nằm trong dấu ""
             * giá trị của biến kiểu float phải có chữ f Hoặc F làm hậu tố.
             * giá trị của biến kiểu decimal phải có chữ m hoắc M làm hậu tố.
             * trừ kiểu string, tất cả kiểu dữ liệu trên đều không được có giá trị null:
             * null là giá trị rỗng, không tham chiếu đến vùng nhớ nào.
             * để có thể gán giá trị null cho biến thì ta thêm ký tự? vào sau tên kiểu dữ liệu là được. Ví dụ: int? hay bool?
             */
            byte bienByte = 10;
            short bienShort = 10;
            int bienInt = 10;
            long bienLong = 10;
            float bienFloat = 10.9f;
            double bienDouble = 10.9;
            decimal bienDecimal = 10.9m;
            char bienChar = 'K';
            string bienString = "King";
            Console.ReadKey();
            Console.WriteLine("bienLong = " + bienLong);
            bienLong = bienInt;
            Console.WriteLine("bienLong = {0}", bienLong);

        }
    }
}
