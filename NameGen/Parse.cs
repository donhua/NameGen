using System;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace NameGen
{
    internal class Parse
    {
        public void JsLoad(object a)
        {
            string jsonString = File.ReadAllText("\jsconfig1.json");
            a = JsonSerializer.Deserialize<ForData>(jsonString);
        }
        
    }
}
