using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace projekt
{
    [Serializable]
    public class Department: BaseEntity
    {
        /// <summary>
        /// Khoa, vd Khoa BIT, Ngân hàng,...
        /// Trong một Khoa sẽ có nhiều giảng viên cùng tham gia giảng dạy
        /// có nhiều Lớp Học trực thuộc
        /// </summary>

        public int DepartmentID { get; set; }
        public List<Lecturer> Lecturers { get; set; }
        public List<Class> Classes { get; set; }

        public Department(int departmentID)
        {
            DepartmentID = departmentID;
           
        }
    }
}
