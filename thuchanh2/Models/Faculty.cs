using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace thuchanh2.Models
{
    public class Faculty
    {
        public int id { get; set; }
        public string FacultiName { get; set; }
        public virtual ICollection<Exam> Exams { get; set; }

    }
}