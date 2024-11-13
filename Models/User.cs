using Newtonsoft.Json;

namespace BlazorApp_Usuarios.Models
{
    public class Users
{
    [JsonProperty("id")]
    public long id { get; set; }

    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("username")]
    public string username { get; set; }

    [JsonProperty("email")]
    public string email { get; set; }

    [JsonProperty("address")]
    public Address address { get; set; }

    [JsonProperty("phone")]
    public string phone { get; set; }

    [JsonProperty("website")]
    public string website { get; set; }

    [JsonProperty("company")]
    public Company company { get; set; }
}

public  class Address
{
    [JsonProperty("street")]
    public string street { get; set; }

    [JsonProperty("suite")]
    public string suite { get; set; }

    [JsonProperty("city")]
    public string city { get; set; }

    [JsonProperty("zipcode")]
    public string zipcode { get; set; }

    [JsonProperty("geo")]
    public Geo geo { get; set; }
}

public  class Geo
{
    [JsonProperty("lat")]
    public string lat { get; set; }

    [JsonProperty("lng")]
    public string lng { get; set; }
}

public  class Company
{
    [JsonProperty("name")]
    public string name { get; set; }

    [JsonProperty("catchPhrase")]
    public string catchPhrase { get; set; }

    [JsonProperty("bs")]
    public string bs { get; set; }
}
}
