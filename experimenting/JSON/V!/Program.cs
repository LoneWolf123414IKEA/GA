

using System.Text.Json;

namespace V1
{
    class Program
    {
        
        public static Nav io = new Nav();
        public static Config config = new Config();
        public static void Main()
        {

            Console.SetWindowSize(160, 60);
            string jsonStr;
            if(File.Exists("config.json"))
            {
                try
                {
                    jsonStr = File.ReadAllText("config.json");
                    jsonStr = jsonStr.Replace("\"default\": {", "\"defaul\": {");
                    config = JsonSerializer.Deserialize<Config>(jsonStr);
                    File.Delete("config.json");
                }
                catch
                {
                }
            }

            io.mainMenu();
            JsonSerializerOptions writerOptions = new()
            {
                WriteIndented = true
            };
            writerOptions.DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingNull;
            jsonStr = JsonSerializer.Serialize(config, writerOptions);
            jsonStr = jsonStr.Replace("\"defaul\": {", "\"default\": {");
            Console.Write(jsonStr);
            

            File.WriteAllText("config.json", jsonStr);
            Console.Read();
        }
    }
}