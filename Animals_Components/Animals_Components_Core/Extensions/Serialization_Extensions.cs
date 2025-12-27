using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Animals_Components_Core;

public static class Serialization_Extensions
{
    private static readonly JsonSerializerSettings settings = new JsonSerializerSettings
    {
        TypeNameHandling = TypeNameHandling.Objects,
        Formatting = Formatting.Indented,
        NullValueHandling = NullValueHandling.Ignore,
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new SnakeCaseNamingStrategy(),
        },
    };

    public static string Serialize(this object obj)
    {
        return JsonConvert.SerializeObject(obj, settings);
    }
}
