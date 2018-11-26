using IdentityServer4.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace IdentityServer.Model
{
    public class ApiConfig
    {
        //resource
        public static IEnumerable<ApiResource> GetApiResources()
        {
            return new[] { new ApiResource("ValueApi", "API Value") };
        }

        //trust client
        public static IEnumerable<Client> GetClients()
        {
            return new[]{
                new Client(){
                    ClientId="OcelotIdentity",
                    ClientSecrets=new []{new Secret("Aikenwu".Sha256())},
                    AllowedGrantTypes= GrantTypes.ClientCredentials,
                    AllowedScopes=new[]{"ValueApi"}
                    }
                };
        }
    }
}
