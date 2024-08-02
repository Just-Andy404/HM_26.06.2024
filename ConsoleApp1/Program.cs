using hw_cSH_14;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const string path = "data.json";

            Query.GetLocationByIp("62.16.8.251", path);
            //Query.GetLocationByIp("8.8.4.4", path);
            //Query.GetLocationByIp("32.16.8.221", path);

            Console.ReadKey();

        }
    }
}
