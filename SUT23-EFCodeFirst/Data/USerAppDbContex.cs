using Microsoft.EntityFrameworkCore;
using SUT23_EFCodeFirst.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SUT23_EFCodeFirst.Data
{
    internal class USerAppDbContex : DbContext
    {

        public DbSet<User> Users { get; set; }
        public DbSet<Student> Studenst { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data source = LAPTOP-ASDGP29P;Initial Catalog = SUT23CodeFirstDB;Integrated Security=True;");
        }
    }
}
