

using System.Text.Json;

namespace V1
{
    class Program
    {
        
        public static Nav io = new Nav();
        public static Config config = new Config();
        public static void Main()
        {
            if(File.Exists("config.json"))
            {
                try
                {
                    config = JsonSerializer.Deserialize<Config>(File.ReadAllText("config.json"));
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
            string jsonStr = JsonSerializer.Serialize(config, writerOptions);
            Console.Write(jsonStr);
            

            File.WriteAllText("config.json", jsonStr);
            Console.Read();
        }
    }
}