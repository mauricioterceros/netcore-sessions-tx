using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace externalServices;
public class UserService
{
    public async Task<List<User>> GetExternalUsersAsync()
    {
        HttpClient client = new HttpClient();

        string baseExternalServerURL = "https://random-data-api.com";
        string externalResourceURI = "/api/v2/users?size=10";
        HttpResponseMessage response = await client.GetAsync(baseExternalServerURL + externalResourceURI);

        if (response.IsSuccessStatusCode)
        {
            string responseContent = await response.Content.ReadAsStringAsync();
            // Console.WriteLine(responseContent);
            List<User> externalUsers = JsonConvert.DeserializeObject<List<User>>(responseContent);
            return externalUsers;
        }
        else
        {
            string message = "La coneccion con el server externo fallo";
            // Log.Error(message);
            Console.WriteLine(message);
            throw new System.Exception(message);
        }
    }
}
