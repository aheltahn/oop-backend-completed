﻿using System;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Security.Principal;

namespace projekt
{
    // Giao diện cho các thực thể có ID và Name
    /* Tăng tính nhất quán giữa các lớp trong hệ thống.
       Tạo sự linh hoạt khi xử lý các đối tượng khác loại(như Student, Lecturer) qua cùng một giao diện.
       Dễ dàng mở rộng và tái sử dụng mã khi thêm các lớp mới có cùng cấu trúc cơ bản.*/
    public interface IENTITY
    {
        string Id { get; set; }
        string Name { get; set; }
    }
   
}