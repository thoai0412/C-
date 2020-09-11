using System;

namespace Operators
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            /*
             * Operators
             * toán tử trong c# là một công cụ thao tác với dữ liệu
             * một toán tử là một ký hiệu dùng để đại diện cho một thao tác cụ thể được thực hiện trên dữ liệu
             * có 6 loại toán tử cơ bản:
             * toán tử toán học 
             * toán tử quan hệ
             * toán tử logic
             * toán tử khởi tạo và gán
             * toán tử so sánh trên bit
             * toán tử khác
             */
            /*
             * arithmetic toán tử học 
             * lưu ý : a++ là a được + thêm 1 đơn vị
             * ++a là tăng giá trị biến lên 1 đơn vị rồi mới sử dụng biến a để thực hiện biểu thức. tương tự 
             */
            int j = 5, i = 5;
            Console.WriteLine(i++);
            Console.WriteLine(++j);
            /*
             * comparison toán tử quan hệ
             * các toán tử quan hệ này chỉ áp dụng cho số hoặc ký tự.
             * hai toán hạng hai bên phải cùng loại 
             * bản chất của việc so sánh 2 ký tự với nhau là so sánh mã ascII của các ký tự đó 
             * so sánh a và b bản chất là so sánh số 1 với số 2
             * không nên sử dụng các toán tử trên để so sánh các chuỗi với nhau vì bản chất việc so sánh chuỗi là so sánh từng ký tự tương ứng với nhau mà so sánh ký tự là so sánh mã ascII của ký tự đó như vậy ký tự 'k' sẽ khác ký tự 'K'. Để so sánh hai chuỗi người ta thường dùng hàm so sánh chuỗi đã được hỗ trợ sẵn
             */
             /*
              * toán tử logic
              * các toán tử && và || có thể áp dụng đồng thời nhiều toán hạng.
              * các toán hạng trong biểu thức chứa toán tử logic phải trả về true hoặc false.
              */
              /*
               * assignment operator
               * toán tử khởi tạo và gán
               * toán tử khởi tạo gán thường được sử dụng nhằm mục đích lưu lại giá trị cho một biến nào đó.
               */
               /*
                * toán tử so sánh trên bit
                * các toán tử so sánh trên bit cũng it gặp nên mình chỉ giới thiệu qua cho các bạn tham khảo thôi chứ chúng ta không giới thiệu rõ phần này.
                * giả sử a có giá trị bằng 10 và b có giá trị bằng 9 giá trị biến đổi ra nhị phân là 1010 và giá trị b biến đổi ra nhị phân là 1001.
                */
                /*
                 * toán tử khác
                 * ngoài những toán tử đã giới thiệu ở trên chúng ta vẫn còn nhiều toán tử khác cũng hay sử dụng
                 */
        }
    }
}
