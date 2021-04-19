using System;
using System.Collections.Generic;
using System.Text;

namespace schoolMVC.Models
{
    public class StudentModel : BaseModel
    {
        
       
        public string FirstName { get; set; }

        
        public string LastName { get; set; }

        public int Class { get; set; }

        public int Gpa { get; set; }

    }
}
