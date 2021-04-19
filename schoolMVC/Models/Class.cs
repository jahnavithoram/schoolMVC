using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace schoolMVC.Models
{
    public class Class: BaseModel
    {
        public int Class_std { get; set; }
        public string Section { get; set; }
        public int NoOf_students { get; set; }
        public string Class_Teacher { get; set; }
    }
}
