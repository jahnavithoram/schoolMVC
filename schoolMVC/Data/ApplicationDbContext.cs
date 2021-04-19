using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using schoolMVC.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace schoolMVC.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Class> Class{ get; set; }
        public DbSet<StudentModel> StudentModel { get; set; }
        public DbSet<SubjectModel> SubjectModel { get; set; }
    }
}
