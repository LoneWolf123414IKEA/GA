

using System.Text.Json;

namespace V1
{
    class Program
    {
        
        public static Nav io = new Nav();
        public static Config config = new Config();
        public static void Main()
        {
            string jsonStr;
            if(File.Exists("config.json"))
            {
                try
                {
                    jsonStr = File.ReadAllText("config.json");
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
            Console.Write(jsonStr);
            

            File.WriteAllText("config.json", jsonStr);
            Console.Read();
        }
    }
}