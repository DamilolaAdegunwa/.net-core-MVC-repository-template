using GRA.Data.Base;
using GRA.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;

namespace GRA.Data
{
    public class RepositoryContext : IRepositoryContext
    {
        private readonly ApplicationDbContext context;

        private readonly IHttpContextAccessor accessor;
        private readonly UserManager<User> userManager;

        public EfCoreRepository<Sex, ApplicationDbContext> RepositorySex;
        public EfCoreRepository<GraApplicant, ApplicationDbContext> RepositoryGraApplicant;
        public EfCoreRepository<GraPerson, ApplicationDbContext> RepositoryGraPerson;
        public EfCoreRepository<GraAdvocacyInfo, ApplicationDbContext> RepositoryGraAdvocacyInfo;
        public EfCoreRepository<GraLicenceInfo, ApplicationDbContext> RepositoryGraLicenceInfo;
        public EfCoreRepository<GraLicenseBasement, ApplicationDbContext> RepositoryGraLicenseBasement;
        public EfCoreRepository<GraLicenseNumber, ApplicationDbContext> RepositoryGraLicenseNumber;
        public EfCoreRepository<GraLicenseStatus, ApplicationDbContext> RepositoryGraLicenseStatus;
        public EfCoreRepository<GraLicenseTermination, ApplicationDbContext> RepositoryGraLicenseTermination;
        public EfCoreRepository<GraLicenseWithdrawal, ApplicationDbContext> RepositoryGraLicenseWithdrawal;
        public EfCoreRepository<GraAdvocacyWorkPlace, ApplicationDbContext> RepositoryGraAdvocacyWorkPlace;
        public EfCoreRepository<GraFIO, ApplicationDbContext> RepositoryGraFIO;
        public EfCoreRepository<GraFormOfAdvocacy, ApplicationDbContext> RepositoryGraFormOfAdvocacy;
        public EfCoreRepository<GraLicenseStopBasement, ApplicationDbContext> RepositoryGraLicenseStopBasement;
        public EfCoreRepository<GraLicenseStopInfo, ApplicationDbContext> RepositoryGraLicenseStopInfo;
        public EfCoreRepository<GraLicenseTerminationBasement, ApplicationDbContext> RepositoryGraLicenseTerminationBasement;
        public EfCoreRepository<GraLicenseWithdrawalBasement, ApplicationDbContext> RepositoryGraLicenseWithdrawalBasement;
        public EfCoreRepository<GraAdvocacyWorkPlaceCredentials, ApplicationDbContext> RepositoryGraAdvocacyWorkPlaceCredentials;
        public EfCoreRepository<GraAdvocacyWorkPlaceName, ApplicationDbContext> RepositoryGraAdvocacyWorkPlaceName;
        public EfCoreRepository<GraGGUP, ApplicationDbContext> RepositoryGraGGUP;
        public EfCoreRepository<GraGGUPExclusion, ApplicationDbContext> RepositoryGraGGUPExclusion;
        public EfCoreRepository<GraGGUPSpecialization, ApplicationDbContext> RepositoryGraGGUPSpecialization;
        public EfCoreRepository<GraGGUPSuspension, ApplicationDbContext> RepositoryGraGGUPSuspension;
        public EfCoreRepository<GraGGUPEntryInfo, ApplicationDbContext> RepositoryGraGGUPEntryInfo;
        public EfCoreRepository<GraGGUPExclusionBasement, ApplicationDbContext> RepositoryGraGGUPExclusionBasement;
        public EfCoreRepository<GraGGUPHelpForm, ApplicationDbContext> RepositoryGraGGUPHelpForm;
        public EfCoreRepository<GraGGUPSuspensionBasement, ApplicationDbContext> RepositoryGraGGUPSuspensionBasement;
        public EfCoreRepository<Country, ApplicationDbContext> RepositoryCountry;
     

        public RepositoryContext(ApplicationDbContext context, IHttpContextAccessor accessor, UserManager<User> userManager)
        {
            this.context = context;
            this.accessor = accessor;
            this.userManager = userManager;
            RepositorySex = new EfCoreRepository<Sex, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraApplicant = new EfCoreRepository<GraApplicant, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraPerson = new EfCoreRepository<GraPerson, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraAdvocacyInfo = new EfCoreRepository<GraAdvocacyInfo, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenceInfo = new EfCoreRepository<GraLicenceInfo, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseBasement = new EfCoreRepository<GraLicenseBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseNumber = new EfCoreRepository<GraLicenseNumber, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseStatus = new EfCoreRepository<GraLicenseStatus, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseTermination = new EfCoreRepository<GraLicenseTermination, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseWithdrawal = new EfCoreRepository<GraLicenseWithdrawal, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraAdvocacyWorkPlace = new EfCoreRepository<GraAdvocacyWorkPlace, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraFIO = new EfCoreRepository<GraFIO, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraFormOfAdvocacy = new EfCoreRepository<GraFormOfAdvocacy, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseStopBasement = new EfCoreRepository<GraLicenseStopBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseStopInfo = new EfCoreRepository<GraLicenseStopInfo, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseTerminationBasement = new EfCoreRepository<GraLicenseTerminationBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraLicenseWithdrawalBasement = new EfCoreRepository<GraLicenseWithdrawalBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraAdvocacyWorkPlaceCredentials = new EfCoreRepository<GraAdvocacyWorkPlaceCredentials, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraAdvocacyWorkPlaceName = new EfCoreRepository<GraAdvocacyWorkPlaceName, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUP = new EfCoreRepository<GraGGUP, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPExclusion = new EfCoreRepository<GraGGUPExclusion, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPSpecialization = new EfCoreRepository<GraGGUPSpecialization, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPSuspension = new EfCoreRepository<GraGGUPSuspension, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPEntryInfo = new EfCoreRepository<GraGGUPEntryInfo, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPExclusionBasement = new EfCoreRepository<GraGGUPExclusionBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPHelpForm = new EfCoreRepository<GraGGUPHelpForm, ApplicationDbContext>(context, accessor, userManager);
            RepositoryGraGGUPSuspensionBasement = new EfCoreRepository<GraGGUPSuspensionBasement, ApplicationDbContext>(context, accessor, userManager);
            RepositoryCountry = new EfCoreRepository<Country, ApplicationDbContext>(context, accessor, userManager);
        }
    }
}