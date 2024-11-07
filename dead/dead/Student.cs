using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace projekt
{
    [Serializable]
    public class Student : Human, IENTITY
    {
        public string Id { get; set; } //Thuộc tính từ IENTITY
        public string Name { get; set; } //Thuộc tính từ IENTITY
        public double GPA { get; set; }
        public double ĐRL { get; set; }
        public string SchoolYear { get; set; }
        public string ClassID { get; set; }
        public List<string> classIDs = new List<string>();

        public string CourseID { get; set; }
        public List<string> courseIDs = new List<string>();

        public string DepartmentID { get; set; }
        public List<string> DepartmentIDs = new List<string>();

        public override void DisplayInfo()
        {
            // Cá nhân
            Console.WriteLine($"ID: {ID}");
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Gender: {Gender}");
            Console.WriteLine($"Bday: {Bday}");
            Console.WriteLine($"ClassID: {string.Join(", ", classIDs)}");
            Console.WriteLine($"CourseID: {CourseID}");
            Console.WriteLine($"DepartmentID: {DepartmentID}");

            // Học tập
            Console.WriteLine($"SchoolYear: {SchoolYear}");
            Console.WriteLine($"GPA: {GPA}");
            Console.WriteLine($"ĐRL: {ĐRL}");

            // Liên lạc
            Console.WriteLine($"Email: {Email}");
            Console.WriteLine($"Phone: {PhoneNumber}");
        }
    }
}


