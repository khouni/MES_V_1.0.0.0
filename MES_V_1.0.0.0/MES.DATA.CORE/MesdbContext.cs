using System;
using System.Linq;
using MES.DATA.MODEL;
using MES.DATA.MODEL.Entity;
using Microsoft.EntityFrameworkCore;

namespace data.core
{
    public class MesDbContext : DbContext
    {
        public DbSet<Machine> Machines { get; set; }
        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            => optionsBuilder
                .UseMySql(@"Server=localhost;database=MESDataBase;uid=root;pwd=root;");

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Machine>()
                 .HasIndex(u => u.Code).IsUnique();
        }

        public override int SaveChanges()
        {
            var modifiedEntries = ChangeTracker.Entries()
                .Where(x => x.Entity is IAuditableEntity
                    && (x.State == EntityState.Modified || x.State == EntityState.Added));
            foreach (var entry in modifiedEntries)
            {
                IAuditableEntity entity = entry.Entity as IAuditableEntity;
                if (entity != null)
                {
                    string identityName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                    DateTime now = DateTime.UtcNow;
                    if (entry.State == EntityState.Added)
                    {
                        entity.CreatedBy = identityName;
                        entity.CreatedDate = now;
                    }
                    else
                    {
                        Entry(entity).Property(x => x.CreatedBy).IsModified = false;
                        Entry(entity).Property(x => x.CreatedDate).IsModified = false;
                    }
                    entity.UpdatedBy = identityName;
                    entity.UpdatedDate = now;
                }
            }
            return base.SaveChanges();
        }
    }
}
