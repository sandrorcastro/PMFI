//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Domain.Entities;
using Infra.EntitiesConfigurations;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using Domain.Entities;
using Infra.EntitiesConfigurations;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Claims;

namespace Infra.Context
{
     public class ApplicationDbContext : DbContext //IdentityDbContext
    //public class ApplicationDbContext : 
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }
        public DbSet<Uf> dbUfs { get; set; }
        public DbSet<Pais> dbPaises { get; set; }
        public DbSet<Cidade> dbCidades { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new UfConfiguration());
            builder.ApplyConfiguration(new CidadeConfiguration());
            builder.ApplyConfiguration(new PaisConfiguration());
            //builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDbContext).Assembly);

        }
       /* public override int SaveChanges()
        {
            BeforeSaveChanges().ConfigureAwait(false).GetAwaiter().GetResult();
            var result = base.SaveChanges();

            return result;
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            await BeforeSaveChanges();
            var result = await base.SaveChangesAsync(cancellationToken);

            return result;
        }
        private async Task BeforeSaveChanges()
        {
            try
            {
                var login = HttpContext?.HttpContext?.User?.FindFirst(ClaimTypes.Email)?.Value;
                ChangeTracker.DetectChanges();

                foreach (var entry in ChangeTracker.Entries())
                {
                    if (entry.Entity is Base auditable)
                    {
                        auditable.UpdateDate(entry.State);
                    }

                    if (entry.Entity is Entities.Audit || entry.State is EntityState.Detached or EntityState.Unchanged)
                    {
                        continue;
                    }

                    var auditEntry = new AuditEntry(entry) { TableName = entry.Entity.GetType().Name, UserId = login };

                    foreach (var property in entry.Properties)
                    {
                        var propertyName = property.Metadata.Name;

                        if (property.Metadata.IsPrimaryKey())
                        {
                            auditEntry.KeyValues[propertyName] = property.CurrentValue;

                            continue;
                        }

                        switch (entry.State)
                        {
                            case EntityState.Added:
                                auditEntry.AuditType = AuditType.Create;
                                auditEntry.NewValues[propertyName] = property.CurrentValue;

                                break;
                            case EntityState.Deleted:
                                auditEntry.AuditType = AuditType.Delete;
                                auditEntry.OldValues[propertyName] = property.OriginalValue;

                                break;
                            case EntityState.Modified:
                                if (property.IsModified)
                                {
                                    auditEntry.ChangedColumns.Add(propertyName);
                                    auditEntry.AuditType = AuditType.Update;
                                    auditEntry.OldValues[propertyName] = property.OriginalValue;
                                    auditEntry.NewValues[propertyName] = property.CurrentValue;
                                }

                                break;
                        }

                        await Audits.AddAsync(auditEntry.ToAudit());
                    }
                }
            }
            catch (Exception ex)
            {
                Serilog.Log.Error(ex, "Error saving audit");
            }
        }*/
    }
}