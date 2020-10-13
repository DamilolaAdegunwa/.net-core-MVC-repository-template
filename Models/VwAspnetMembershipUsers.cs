using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace GRA.Models
{
    public partial class VwAspnetMembershipUsers
    {
        [Key]
        public Guid UserId { get; set; }
        public int PasswordFormat { get; set; }
        public string MobilePin { get; set; }
        public string Email { get; set; }
        public string LoweredEmail { get; set; }
        public string PasswordQuestion { get; set; }
        public string PasswordAnswer { get; set; }
        public bool IsApproved { get; set; }
        public bool IsLockedOut { get; set; }
        [Common.Validation.DateRange]
        public DateTime CreateDate { get; set; }
        [Common.Validation.DateRange]
        public DateTime LastLoginDate { get; set; }
        [Common.Validation.DateRange]
        public DateTime LastPasswordChangedDate { get; set; }
        [Common.Validation.DateRange]
        public DateTime LastLockoutDate { get; set; }
        public int FailedPasswordAttemptCount { get; set; }
        [Common.Validation.DateRange]
        public DateTime FailedPasswordAttemptWindowStart { get; set; }
        public int FailedPasswordAnswerAttemptCount { get; set; }
        [Common.Validation.DateRange]
        public DateTime FailedPasswordAnswerAttemptWindowStart { get; set; }
        public string Comment { get; set; }
        public Guid ApplicationId { get; set; }
        public string UserName { get; set; }
        public string MobileAlias { get; set; }
        public bool IsAnonymous { get; set; }
        [Common.Validation.DateRange]
        public DateTime LastActivityDate { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public Guid UserLookup { get; set; }
        public Guid? RoleId { get; set; }
        public string RoleName { get; set; }
    }
}
