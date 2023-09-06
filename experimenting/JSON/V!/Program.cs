

using System.Text.Json;

namespace V1
{
    class Program
    {
        public static void Main()
        {
            Config config = new Config();
            string jsonStr = JsonSerializer.Serialize(config);
            Console.Write(jsonStr);
        }
    }
}