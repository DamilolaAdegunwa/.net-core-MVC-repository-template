using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using GRA.Data.Base;
using GRA.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace GRA.Data
{
    public class ApplicationDbContext : IdentityDbContext<User>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public int SaveChanges(string user)
        {
            LogChanges(user);
            return base.SaveChanges();
        }

        [Obsolete("SaveChanges() is deprecated, please use SaveChanges(string user) instead.", true)]
        public override int SaveChanges()
        {
            LogChanges("", false);
            return base.SaveChanges();
        }


        public Task<int> SaveChangesAsync(string user, CancellationToken cancellationToken = new CancellationToken())
        {
            LogChanges(user);
            return base.SaveChangesAsync(cancellationToken);
        }

        [Obsolete("SaveChangesAsync is deprecated, please use SaveChangesAsync(string user, CancellationToken cancellationToken = new CancellationToken()) instead.", true)]
        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            LogChanges("", false);
            return base.SaveChangesAsync(cancellationToken);
        }


        private void LogChanges(string user, bool logUser = true)
        {
            var t = Environment.StackTrace;

            if (string.IsNullOrEmpty(user))
            {
                if (logUser) throw new Exception("No Auth");

                user = "no user";
            }

            var entries = base.ChangeTracker.Entries().ToList();
            for (var index = 0; index < entries.Count; index++)
            {
                var entry = entries[index];
                if (entry.State != EntityState.Unchanged)
                {
                    var id = 0;
                    if (entry.Entity is BaseModel)
                    {
                        id = ((BaseModel) entry.Entity).Id;
                        if(logUser)((BaseModel) entry.Entity).CreatorId = user;
                    }

                    var log = new EditorsAndCreators
                    {
                        CreationTime = DateTime.Now,
                        UserId = user,
                        ModifiedId = id,
                        State = entry.State,
                        Table = entry.CurrentValues.EntityType.Name,
                        StackTrace = t,
                        ValueJson = JsonConvert.SerializeObject(entry.Entity, Formatting.Indented, new JsonSerializerSettings
                        {
                            ReferenceLoopHandling = ReferenceLoopHandling.Ignore
                        })
                    };
                    Add(
                      log  
                    );
                }
            }
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            new FillData().Fill(modelBuilder);

            //modelBuilder.FinalizeModel();
        }

        #region DbSets
        public DbSet<Department> Departments { get; set; }
        public DbSet<UserActivityLog> UserActivityLogs { get; set; }

        public DbSet<Page> Pages { get; set; }
        public DbSet<RolePageMap> RolePageMaps { get; set; }
        public DbSet<PersonModel> Persons { get; set; }
        public DbSet<PersonPhotoModel> PersonPhotos { get; set; }
        public DbSet<PersonDocumentModel> PersonDocuments { get; set; }
        public DbSet<PersonAddressModel> PersonAddresses { get; set; }




        public virtual DbSet<Nationality> Nationality { get; set; }
        public virtual DbSet<Country> Country { get; set; }

        public DbSet<EditorsAndCreators> EditorsAndCreators { get; set; }

        public DbSet<GraAdvocacyInfo> GraAdvocacyInfo { get; set; }

        public DbSet<GraAdvocacyWorkPlace> GraAdvocacyWorkPlace { get; set; }

        public DbSet<GraAdvocacyWorkPlaceCredentials> GraAdvocacyWorkPlaceCredentials { get; set; }

        public DbSet<GraAdvocacyWorkPlaceName> GraAdvocacyWorkPlaceName { get; set; }

        public DbSet<GraApplicant> GraApplicant { get; set; }

        public DbSet<GraFIO> GraFIO { get; set; }

        public DbSet<GraFormOfAdvocacy> GraFormOfAdvocacy { get; set; }

        public DbSet<GraGGUP> GraGGUP { get; set; }

        public DbSet<GraGGUPEntryInfo> GraGGUPEntryInfo { get; set; }

        public DbSet<GraGGUPExclusion> GraGGUPExclusion { get; set; }

        public DbSet<GraGGUPExclusionBasement> GraGGUPExclusionBasement { get; set; }

        public DbSet<GraGGUPHelpForm> GraGGUPHelpForm { get; set; }

        public DbSet<GraGGUPSpecialization> GraGGUPSpecialization { get; set; }

        public DbSet<GraGGUPSuspension> GraGGUPSuspension { get; set; }

        public DbSet<GraGGUPSuspensionBasement> GraGGUPSuspensionBasement { get; set; }

        public DbSet<GraLicenceInfo> GraLicenceInfo { get; set; }

        public DbSet<GraLicenseBasement> GraLicenseBasement { get; set; }

        public DbSet<GraLicenseNumber> GraLicenseNumber { get; set; }

        public DbSet<GraLicenseStatus> GraLicenseStatus { get; set; }

        public DbSet<GraLicenseStopBasement> GraLicenseStopBasement { get; set; }

        public DbSet<GraLicenseStopInfo> GraLicenseStopInfo { get; set; }

        public DbSet<GraLicenseTermination> GraLicenseTermination { get; set; }

        public DbSet<GraLicenseTerminationBasement> GraLicenseTerminationBasement { get; set; }

        public DbSet<GraLicenseWithdrawal> GraLicenseWithdrawal { get; set; }

        public DbSet<GraLicenseWithdrawalBasement> GraLicenseWithdrawalBasement { get; set; }

        public DbSet<GraPerson> GraPerson { get; set; }

        public DbSet<Sex> Sex { get; set; }

        #endregion
    }
}