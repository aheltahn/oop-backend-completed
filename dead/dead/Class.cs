﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Text.Json;

namespace projekt
{
    [Serializable]
    public class Class : Department
    {
        /// <summary>
        /// Đại diện cho một Lớp Học, gồm nhiều Học Sinh.
        /// 
        /// </summary>

        public string ClassID { get; set; }
        
        public List<Student> students = new List<Student>();

        public Class(int departmentID,  string id)
            : base(departmentID)
        {
            this.ClassID = id;
        }
    }
}
