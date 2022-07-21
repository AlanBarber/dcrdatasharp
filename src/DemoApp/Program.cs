namespace DemoApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("DcrDataSharp Demo App...");

            // Call endpoint list api to get list of all api endpoints
            var dcrDataClient = new DcrDataSharp.Clients.DcrDataClient();
            var task = dcrDataClient.EndPointList.GetEndPointsAsync();
            var result = task.Result;

            foreach (var line in result)
            {
                Console.WriteLine(line);
            }

            // Debug
            Console.Write("Press any key to continue...");
            Console.ReadKey();

        }
    }
}