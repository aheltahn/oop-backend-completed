using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class Class : Department
    {
        /// <summary>
        /// Đại diện cho một Lớp Học, gồm nhiều Học Sinh.
        /// 
        /// </summary>

        public string ClassID { get; set; }
        public List<Student> students = new List<Student>();

        public Class(int departmentID, string departmentName, string id)
            : base(departmentID, departmentName)
        {
            this.ClassID = id;
        }
    }
}
