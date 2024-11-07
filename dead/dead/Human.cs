using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text.Json;

namespace projekt
{
    // Lớp Human (Giảng viên, Sinh viên)
    public abstract class Human
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Bday { get; set; }
        public Boolean Gender { get; set; }
        public string CourseID { get; set; }
        public string DepartmentID { get; set; }

        public abstract void DisplayInfo();
    }
}

