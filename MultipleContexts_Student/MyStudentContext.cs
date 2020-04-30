using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleContexts_Student
{
    public class MyStudentContext : DbContext
    {
        public MyStudentContext() : base("name=DbContext") { }
        public virtual DbSet<Student> Students { get; set; }
    }
}
