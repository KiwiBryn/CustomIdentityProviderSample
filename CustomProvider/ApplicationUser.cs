using System;
using System.Security.Principal;

namespace CustomIdentityProviderSample.CustomProvider
{
    public class ApplicationUser : IIdentity
    {
        // public virtual Guid Id { get; set; } = Guid.NewGuid(); BHL
        public virtual string Id { get; set; } = Guid.NewGuid().ToString();
        public virtual string UserName { get; set; }
        public virtual string Email { get; set; }
        public virtual bool EmailConfirmed { get; set; }
        // public virtual string TelephoneNumber { get; set; } BHL
        public virtual string PhoneNumber { get; set; }
        public virtual bool TwoFactorEnabled { get; set; }
        public virtual String PasswordHash { get; set; }
        public string NormalizedUserName { get; internal set; }
        public string AuthenticationType { get; set; }
        public bool IsAuthenticated { get; set; }
        public string Name { get; set; }
    }
}
