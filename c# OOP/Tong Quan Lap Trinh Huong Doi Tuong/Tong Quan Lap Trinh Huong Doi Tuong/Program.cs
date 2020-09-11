using System;

namespace Tong_Quan_Lap_Trinh_Huong_Doi_Tuong
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * sự tiên hóa của phương pháp lập trình
             * lập trình sơ khai là lập trình không có cấu trúc
             * là chương trình mà các lập trình viên viêt tât cả vào 1 hàm main duy nhất
             * ngôn ngữ sử dụng phương pháp này là assembly 
             * nhược điểm của phương pháp này là chỉ sử dụng biến toàn cục dẫn đến rất tốn bộ nhớ
             * vì có những đoạn cần sử dụng đi sử dụng lại nên dẫn đến lạm dụng lệnh goto.
             * nhược điểm là khó hiểu, khó bảo trì và không thể tái sử dụng
             * khó phát triển ứng dụng lớn.
             * tiếp theo đó là lập trình có cấu cúc
             * người ta chia nhỏ chưa trình ra theo từng hàm
             * nhược điểm điểm là module hóa, dễ hiểu, dễ bảo trì.
             * dễ dàng tạo ra các thư viện phần mềm.
             * nhược điểm là:
             * dữ liệu xử lý tách rời
             * khi cấu trúc dữ liệu thay đổi sẽ dẫn đến thuật toán bị thay đổi.
             * không tự động hóa khởi tạo, giải phóng dữ liệu tự động
             * không mô tả được đầy đủ, trung thực hệ thống trong thực tế.
             */
             /*
              * khái niệm lập trình hướng đối tượng
              * một đối tượng bao gồm 2 thông tin: thuộc tính và phương thức
              * thuộc tính chính là những thông tin, đặc điểm của đối tượng. 
              * phương thức là những thao tác hành đọng mà đối tượng đó có thể thực hiện.
              */
              /*
               * class , lớp 
               * lớp là đối tượng có các đặc tính tương tự nhau được gom lại thành một lớp đối tượng.
               * bên trong lớp cũng có 2 thành phần chính đó là thuộc tính và phương thức/
               * ngoài ra, lớp còn được dùng để định nghĩa ra kiểu dữ liệu mới
               */
               /* sử khác nhau giữa đối tượng và lớp
                * lớp là một khuôn mẫu còn đối tượng là một thể hiện cụ thể dựa trên khuôn mẫu đó.
                * các đặc điẻm của lập trình hướng đối tượng
                * Tính đóng gói:
                * các dữ liệu và phương thức có liên quan với nhau được đóng gói thành các lớp để tiện cho việc quản lý và sử dụng.
                * ngoài ra đóng gói còn để che giấu một số thông tin và chi tiết cài đặt nội bộ để bên ngoài không thể nhìn thấy.
                * Tính trừu tượng:
                * khi viết chương trình theo phong cách hướng , việc thiết kế các đối tượng ta cần rút tỉa ra những đặc điểm chung của chúng rồi trừu tượng thành các interface và thiết kế xem chúng sẽ tương tác với nhau như thế nào.
                * Tính kế thừa: lớp cha có thể chia sẽ dữ liệu và phương thức cho các lớp con, các lớp con khỏi phải định nghĩa lại, giúp chương trình ngắn gọn.
                * tính đa hình: là hiện tượng các đối tượng thuộc các lớp khác nhau có thể hiểu cùng một thông điệp theo các cách khác nhau
                */
        }
    }
}
