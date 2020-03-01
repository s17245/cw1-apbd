using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace Ćwiczenie_1
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            Console.WriteLine("start");
            var client = new HttpClient();
            var result = await client.GetAsync("https://www.pja.edu.pl");

            if (result.IsSuccessStatusCode) {
                string html = await result.Content.ReadAsStringAsync();
            }


            Console.WriteLine("End!");
        }
    }
}
