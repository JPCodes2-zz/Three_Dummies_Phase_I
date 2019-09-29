using System;
using System.IO;
using Newtonsoft.Json;

namespace APIGateway.Infra
{
    public class JsonParser
    {
        public static T LoadUrisFromFile<T>(string filePath)
        {
            using StreamReader reader = new StreamReader(filePath);
            string json = reader.ReadToEnd();
            T result = JsonConvert.DeserializeObject<T>(json);
            return result;
        }
        public static T Deserialize<T>(object jsonObject)
        {
            return JsonConvert.DeserializeObject<T>(Convert.ToString(jsonObject));
        }
    }
}
