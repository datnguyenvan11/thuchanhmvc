using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace thuchanh2.Models
{
    [DbConfigurationType(typeof(MySql.Data.Entity.MySqlEFConfiguration))]
    public class DBContext : DbContext
    {
        public DBContext() : base("name=MyContext")
        {

        }
        public System.Data.Entity.DbSet<thuchanh2.Models.Exam> Exams { get; set; }

        public System.Data.Entity.DbSet<thuchanh2.Models.ClassRoom> ClassRooms { get; set; }

        public System.Data.Entity.DbSet<thuchanh2.Models.ExamSubject> ExamSubjects { get; set; }

        public System.Data.Entity.DbSet<thuchanh2.Models.Faculty> Faculties { get; set; }
    }
}