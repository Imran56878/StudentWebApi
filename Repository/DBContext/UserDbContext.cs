using Microsoft.EntityFrameworkCore;
using Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.DBContext
{
    public class UserDbContext : DbContext
    {
        public UserDbContext(DbContextOptions<UserDbContext> option) :base(option)
        {

        }
        public DbSet<Student> StudentTable { get; set; }
        public DbSet<Faculty> FacultyTable { get; set; }
    }
}
