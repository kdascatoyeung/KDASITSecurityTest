using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ITSecurityTest.Models
{
    public class ITSecurityTestEntities : DbContext
    {
        public ITSecurityTestEntities() : base()
        {
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Group> Groups { get; set; }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Department>()
                .Property(d => d.Code).IsRequired();
            modelBuilder.Entity<Department>()
                .Property(d => d.Name).IsRequired();

            modelBuilder.Entity<Group>()
                .Property(g => g.Name).IsRequired();

            modelBuilder.Entity<User>()
                .HasOne<Group>(u => u.Group)
                .WithMany(g => g.Users)
                .HasForeignKey(u => u.GroupId);

            modelBuilder.Entity<User>()
                .HasOne<Department>(u => u.Department)
                .WithMany(d => d.Users)
                .HasForeignKey(u => u.DepartmentId);
        }

        public virtual void Commit()
        {
            this.SaveChanges();
        }
    }
}
