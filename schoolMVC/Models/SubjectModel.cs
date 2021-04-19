using System;
using System.Collections.Generic;
using System.Text;

namespace schoolMVC.Models

{
    public class SubjectModel : BaseModel
    {
        

        public string Subject_Name { get; set; }

        public string Subject_code { get; set; }
        public string Subject_Teacher { get; set; }

    }
}
