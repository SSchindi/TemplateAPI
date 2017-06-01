using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace WebAPITemplate.Models
{
    public class TemplateContext : DbContext
    {

        //public TemplateContext()
        //{
        //}

        public TemplateContext(DbContextOptions<TemplateContext> options)
            : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    modelBuilder.Entity<User>().ToTable("Users");
        //}
    }

   


}