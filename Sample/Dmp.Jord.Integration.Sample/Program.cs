using Dmp.Jord.Integration.Sample.Rest;
using IdentityModel.Client;
using IdentityModel.OidcClient;
using System;
using System.Net.Http;
using System.Threading.Tasks;


namespace Dmp.Jord.Integration.Sample
{
    class Program
    {
        static async Task Main(string[] args)
        {
            var apiUrl = "https://jorddev-api.azurewebsites.net/";
            var jordClient = await RestFactory.CreateAsync(apiUrl);

            await IsAliveAsync(jordClient);
            await GetClaimsAsync(jordClient);
        }

        private static async Task IsAliveAsync(JordClient jordClient)
        {
            Console.WriteLine("Calling IsAlive");
            var result = await jordClient.IsAliveAsync();
            Console.WriteLine("IsAlive response: " + result);
        }

        private static async Task GetClaimsAsync(JordClient jordClient)
        {
            Console.WriteLine("Calling GetClaims");
            var result = await jordClient.GetClaimsAsync();
            Console.WriteLine("GetClaims response: ");
            foreach (var claim in result)
            {
                Console.WriteLine(claim);
            }
        }
    }
}
