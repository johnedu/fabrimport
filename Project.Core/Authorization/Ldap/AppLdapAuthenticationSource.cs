using Abp.Zero.Ldap.Authentication;
using Abp.Zero.Ldap.Configuration;
using Project.Authorization.Users;
using Project.MultiTenancy;

namespace Project.Authorization.Ldap
{
    public class AppLdapAuthenticationSource : LdapAuthenticationSource<Tenant, User>
    {
        public AppLdapAuthenticationSource(ILdapSettings settings, IAbpZeroLdapModuleConfig ldapModuleConfig)
            : base(settings, ldapModuleConfig)
        {
        }
    }
}
