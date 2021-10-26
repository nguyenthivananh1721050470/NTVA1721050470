using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace NTVA1721050470.Models
{
    public partial class baitapDbcontext : DbContext
    {
        public baitapDbcontext()
            : base("name=baitapDbcontext")
        {
        }
        public virtual DbSet<Person> People { get; set; }
        public virtual DbSet<Student>  Students { get; set; }
        public virtual DbSet<Lecture>  Lectures { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
