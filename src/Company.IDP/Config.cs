using IdentityServer4.Models;
using IdentityServer4.Test;
using System.Collections.Generic;
using System.Security.Claims;

namespace Company.IDP
{
    public static class Config
    {
        public static List<TestUser> GetUsers() => new List<TestUser>()
        {
            new TestUser
            {
                SubjectId = "d860efca-22d9-47td",
                Username = "Frank",
                Password = "password",
                Claims = new List<Claim>()
                {
                    new Claim("given_name", "Frank"),
                    new Claim("family_name", "Castle")
                }
            },
            new TestUser
            {
                SubjectId = "b7539694-97e7-4dfe",
                Username = "Maria",
                Password = "password",
                Claims = new List<Claim>()
                {
                    new Claim("given_name", "Maria"),
                    new Claim("family_name", "Castle")
                }
            }
        };

        //IdentityResources => map to scopes that give access to Identity-related information
        //ApiResources => map to scopes that give access to Api-resources
        public static IEnumerable<IdentityResource> GetIdentityResources() => new List<IdentityResource>()
        {
            //If a client request the OpenId scope, the subjectId is returned
            new IdentityResources.OpenId(),

            //If a client request the OpenId scope, the given_name and family_name claims will be returned
            new IdentityResources.Profile()
        };

        public static IEnumerable<Client> GetClients() => new List<Client>();
    }
}
