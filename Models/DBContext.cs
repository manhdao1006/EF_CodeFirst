using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EF_CodeFirst.Models
{
    public class DBContext : DbContext
    {
        public DBContext() : base("MyConnectionString") { }
        public DbSet<Khoa> khoas { get; set; }
        public DbSet<Lop> lops { get; set; }
        public DbSet<SinhVien> sinhViens { get; set; }
    }
}