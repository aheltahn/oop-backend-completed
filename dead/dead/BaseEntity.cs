using projekt;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace projekt
{
    public class BaseEntity : IENTITY
    {
        public string Id { get; set; }  
        public string Name { get; set; }
    }
}
