using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    // Lớp Lecturer (Giảng viên)
    public class Lecturer : Human
    {
        public string Id { get; set; } 
        public string Name { get; set; } 
        public string Education { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
            Console.WriteLine($"DepartmentID: {DepartmentID}");
            Console.WriteLine($"CourseID: {CourseID}");
        }
    }
}

