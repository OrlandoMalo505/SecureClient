namespace SecureClient
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AuthConfig config = AuthConfig.ReadJsonFromFile("appsettings.json.txt");
            Console.WriteLine($"Authority: {config.Authority}");
        }
    }
}

