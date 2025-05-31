DTO (Data Transfer Object) là một class trung gian, 
chỉ chứa dữ liệu cần thiết để truyền từ tầng này sang
tầng khác (ví dụ: từ DAL sang GUI) mà không dính logic
hay ràng buộc của cơ sở dữ liệu (EF).

Trong Entity Framework (EF), các class như Message, Employee là entity đại diện cho bảng trong CSDL.
Khi bạn cố gắng thêm thuộc tính như ReceiverName (chỉ dùng để hiển thị) vào Message, EF không hiểu, 
vì bảng thật không có cột đó => lỗi.

Vì vậy ta dùng DTO để chứa dữ liệu tạm thời như:

Tên người gửi/người nhận (FullName)

Tên phòng ban

Tổng số tin nhắn

Dữ liệu kết hợp nhiều bảng