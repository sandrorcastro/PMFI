//using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Internal;
using PMFI.Seguranca.Configurations;
using PMFI.Seguranca.Context;
using PMFI.Seguranca.Enums;
using PMFI.Seguranca.Models;
using Sample.Audit.Persistence;
using Sample.Audit.Persistence.Configurations;
using System.Diagnostics;
using System.Net.Http;
using System.Security.Claims;

namespace PMFI.Seguranca.Context
{
    //public class SegurancaDbContext : IdentityDbContext<ApplicationUser, ApplicationRole>

    public class SegurancaDbContext
    : IdentityDbContext<
        ApplicationUser, ApplicationRole, string,
        ApplicationUserClaim, ApplicationUserRole, ApplicationUserLogin,
        ApplicationRoleClaim, ApplicationUserToken>


    {
        public IHttpContextAccessor HttpContext { get; }

        public SegurancaDbContext(DbContextOptions<SegurancaDbContext> options, IHttpContextAccessor httpContext)
            : base(options)
        {
            HttpContext = httpContext;
        }

        public DbSet<Auditoria> Audits { get; set; }
        public DbSet<Company> Companies { get; set; }
        //public DbSet<Cidade> Cidades { get; set; }
        //public DbSet<Uf> Ufs { get; set; }
        //public DbSet<Pais> Paises { get; set; }




        /*
        public SegurancaDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<SegurancaDbContext>();
            optionsBuilder.UseSqlServer("Data Source=localhost;Initial Catalog=Seguranca;Integrated Security=False;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;Persist Security Info=True;User ID=sa;Password=changeme");

            return new SegurancaDbContext(optionsBuilder.Options);
        }*/



        /*
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
        }*/
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SegurancaDbContext).Assembly);
            modelBuilder.ApplyConfiguration(new AuditoriaConfigurations());
            modelBuilder.ApplyConfiguration(new CompanyConfiguration());
           // modelBuilder.ApplyConfiguration(new ApplicationRoleConfiguration());
           // modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());


            modelBuilder.Entity<ApplicationUser>(b =>
            {
                // Each User can have many UserClaims
                b.HasMany(e => e.Claims)
                    .WithOne(e => e.User)
                    .HasForeignKey(uc => uc.UserId)
                    .IsRequired();

                // Each User can have many UserLogins
                b.HasMany(e => e.Logins)
                    .WithOne(e => e.User)
                    .HasForeignKey(ul => ul.UserId)
                    .IsRequired();

                // Each User can have many UserTokens
                b.HasMany(e => e.Tokens)
                    .WithOne(e => e.User)
                    .HasForeignKey(ut => ut.UserId)
                    .IsRequired();

                // Each User can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.User)
                    .HasForeignKey(ur => ur.UserId)
                    .IsRequired();
            });

            modelBuilder.Entity<ApplicationRole>(b =>
            {
                // Each Role can have many entries in the UserRole join table
                b.HasMany(e => e.UserRoles)
                    .WithOne(e => e.Role)
                    .HasForeignKey(ur => ur.RoleId)
                    .IsRequired();

                // Each Role can have many associated RoleClaims
                b.HasMany(e => e.RoleClaims)
                    .WithOne(e => e.Role)
                    .HasForeignKey(rc => rc.RoleId)
                    .IsRequired();
            });
        }

        public override int SaveChanges()
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

                    if (entry.Entity is Auditoria || entry.State is EntityState.Detached or EntityState.Unchanged)
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
        }






    } 
    
}