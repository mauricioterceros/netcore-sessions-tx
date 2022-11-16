using Newtonsoft.Json;

namespace externalServices;
public class User
{
    // private string _lastName; // property

    [JsonProperty("first_name")] // attribute
    public string FirstName { get; set; } // Property

    [JsonProperty("last_name")]
    public string LastName { get; set; }

    /*
    public string getLastName() {
        return last_name;
    }
    public void setLastName(string lastName) {
        last_name = lastName;
    }
    */
}
