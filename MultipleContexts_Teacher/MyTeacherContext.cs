using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultipleContexts_Teacher
{
    public class MyTeacherContext : DbContext
    {
        public MyTeacherContext() : base("name=DbContext") { }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}
