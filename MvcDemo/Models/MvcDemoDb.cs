using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    public class MvcDemoDb : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}