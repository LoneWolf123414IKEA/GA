

using System.Text.Json;

namespace V1
{
    class Program
    {
        
        public static Nav io = new Nav();
        public static Config config = new Config();
        public static void Main()
        {
            io.mainMenu();
            string jsonStr = JsonSerializer.Serialize(config);
            Console.Write(jsonStr);
            Console.Read();
        }
    }
}