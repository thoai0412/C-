using System;


namespace Ép_kiểu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * ép kiểu là biến đổi dữ liệu thuộc kiểu dữ liệu này thành kiểu dữ liệu khác.
             * tại sao phải ép kiểu?
             * để chuyển dữ liệu sang một kiểu dữ liệu mong muốn phục vụ cho việc thao tác xử lý.
             * đưa dữ liệu về định dạng mà mình mong muốn (ví dụ chuyển kiểu ngày tháng bên mỹ sang dạng ngày tháng bên vn)
             * có mấy loại ép kiểu? cách sử dụng từng loại
             * trong c#, ép kiểu có 4 loại:
             * chuyển đổi kiểu ngầm định implicit.
             * chuyển đổi kiểu tường minh explicit
             * sử dụng phương thức, lớp hỗ trợ sẵn:
             * - dùng phương thức parse(), tryparse().
             * - dùng lớp hỗ trợ (convert).
             * người dùng tự định nghĩa kiểu chuyển đổi
             * chuyển đổi kiểu ngầm định (implicit)
             * việc chuyển đổi này được thực hiện bởi trình viên dịch và chúng ta không cần tác động gì.
             * được thực hiện khi chuyển kiểu từ
             * kiểu dữ liệu nhỏ sang kiểu dữ liệu lớn hơn 
             * chuyển từ lớp con đến lớp cha 
             * ví dụ
             */
            int intValue = 10;
            long longValue = intValue;
            // chuyển kiểu ngầm định vì kiểu long có miền giá trị lớp hơn kiểu int nên có thể chuyển từ int sang long
            float floatValue = 10.9f;
            double doubleValue = floatValue;
            // tương tự kiểu double có miền giá trị lớn hơn kiểu float nên có thể chuyển từ float sang double
            /*
             * chuyển đổi kiểu tường minh (explicit)
             * chuyển đổi kiểu tường minh là việc chuyển kiểu một cách rõ ràng và dùng từ khóa chỉ định chứ không dùng phương thức.
             * thường dùng để chuyển đổi giữa các kiểu dữ liệu có tính chất tương tự nhau.
             * hỗ trợ trong việc boxing và unboxing đôi tượng
             * cú pháp ngắn gọn do không sử dụng phương thức.
             * chỉ khi chúng ta biết rõ biến đó thuộc kiểu dữ liệu nào mới thực hiện chuyển đổi. Ngược lại có thể lôi khi chạy chương trình.
             */
            /*cứ pháp 
             * (<kiểu dữ liêu>) <biến cần ép kiểu>
             * <kiểu dữ liệu> là kiểu dữ liệu mà mình muốn chuyển sang.
             * <kiểu cần ép kiểu > là biến chưa dữ liệu cần ép kiểu.
             * phải có cặp dấu ngoặc tròn().
             * ý nghĩa:
             * ép kiểu của <biến cần ép kiểu> về <kiểu dữ liệu> nếu thành công sẽ trả ra giá trị kết quả ngược lại sẽ báo lỗi chương trình. đặc biệt đối với số:
             * ta có thế thực hiện kiểu dữ kiệu lớn hơn về kiểu dữ liệu nhỏ hơn mà không thông báo lỗi.
             * nếu dữ liệu cần ép kiểu dữ liệu lớn hơn về kiểu dữ liệu nhỏ hơn mà không báo lỗi.
             * nếu dữ liệu cần ép kiểu vượt quá miền giá trị của kiểu muốn ép kiểu về thì chương trình sẽ tự cắt bit cho phù hợp với khả năng chứa dữ liệu đó (cắt từ bên trái qua bên phải)
             * ví dụ:
             */
            int i = 300;
            byte b = (byte)i;
            Console.WriteLine("i=" + i);
            Console.WriteLine("b=" + b);
            /*
             * kết quả khi chạy chương trình trên
             */
            double d = 2 / 3;
            double k = (double)2 / 3;
            double t = 1.0 * 2 / 3;
            Console.WriteLine("d = {0} \n k = {1} \n t = {2}", d, k, t);
            /*
             * sử dụng phương thức, lơp hỗ trợ sẵn
             * phương thức parse(), TryParse()
             * Parse()
             * <kiểu dữ liệu>.Parse(<dữ liệu cần chuyển đổi>);
             * < kiểu dữ liệu> là kiểu dữ liệu cơ bản mình muốn chuyển đổi sang.
             * <dũ liệu cần chuyển đổi> là dữ liệu thuộc kiểu chuỗi, có thể là chuyển kiểu chuỗi hoặc giá trị hằng kiểu chuỗi (giá trị hằng đã giải thích trong bài hằng trong c#
             * Ý nghĩa
             * chuyển đổi một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
             * phương thức trả về giá trị kết quả chuyển kiểu nếu chuyển kiểu thành công. ngược lại sẽ báo lỗi chương trình.
             */
            string stringValue = "10";
            int aValue = int.Parse(stringValue);
            // chuyển đổi stringvalue sang kiểu int và lưu giá trị vào biến 
            double Kingdaica = double.Parse("10.9");
            // chuyển chuỗi giá trị hằng 10.9 sang kiểu int và lưu giá trị vào biến 
            /*
             * TryParse()
             * chuyển một chuỗi sang một kiểu dữ liệu cơ bản tương ứng.
             * phương thức sẽ trả về true nếu chuyển kiểu thành công và giá trị kết quả chuyển kiểu sẽ lưu vảo <biến chứa kết quả>.
             * Ngược lại sẽ trả về false và biến chưa kết quả sẽ mang giá trị 0
             */
            int Result;
            bool isSuccess;
            string Data1 = "10", Data2 = "king";
            isSuccess = int.TryParse(Data1, out Result);
            Console.Write(isSuccess == true ? " Succes !" : "Failed !");
            Console.WriteLine(" Result = " + Result);

            // data1 có thể ép kiểu về int nên kết quả thành công và in ra giá trị. 

            isSuccess = int.TryParse(Data2, out Result);
            Console.Write(isSuccess == true ? " Success !" : "Failed ! ");
            Console.WriteLine(" Result = " + Result);

            // data 2 không thể ép về kiểu int nên ko thể in ra kết quả và trả về 0.
            /*
             * lưu ý khi sử dụng parsel() và Tryparse():
             * tham số truyền vào phải là một chuỗi.
             * cả 2 phương thức được gọi thông qua tên kiểu dữ liệu.
             * parse() trả về giá trị kết quả ép kiểu nên ép kiểu không thành công thì sẽ báo lỗi. còn Tryparse() trả về xem ép kiểu có thành công hay không
             * ngoài TryParse() ra thì vẫn có một cách ép kiểu không thông báo lỗi chương trình. Đó là sử dụng toán tử as:
             * trong bài toán tử trong c# chúng ta có giới thiệu toán tử as là dùng để ép kiểu mà không gây ra lỗi. nếu ép kiểu không thành công sẽ trả về null.
             * chỉ áp dụng cho việc chuyển kiểu giữa các kiểu tham chiếu tương thích(thường kà các kiểu có quan hệ kế thừa) hoặc kiểu nullable (là các kiểu có thẻ chứa giá trị null)
             */
             /*
              * lớp hỗ trợ sẵn (convert)
              * Convert là lớp tiện ích được C# hỗ trợ sẵn cung cấp cho ta nhiều phương thức chuyển đổi kiểu dữ liệu.
              * các đặc điểm của các phương thức trong lớp convert:
              * tham sô truyền vào của các phương thức không nhất thiết là chuỗi ( có thể là int, bool,..)
              * Nếu tham số truyền vào là null thì các phương thức sẽ trả vef giá trị mặc định của kiểu dữ liệu.
              * các trường hợp thanh số truyền vào sai định dạng hoặc vượt quá giới hạn thì chương trình sẽ báo lỗi như phương thức parse()
              * một số phương thức chuyển kiểu mà convert có :
              * các phương thức chuyển kiểu trong lớp convert đều có thể nhận các kiểu dữ liệu cơ bản(int, bool, byte,..) tham số truyền vào.
              * ở bảng trên mình chỉ kiệt kê nhưng phương thức hay dùng. để tìm hiểu thêm các phương thức chuyển kiểu khác các bạn có thể sử dụng tính năng gọi ý của visual studio
              */

        }
    }
}
