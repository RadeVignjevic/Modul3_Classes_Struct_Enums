namespace Modul3_Classes_Struct_Enums 
{
    using Modul3_Classes_Struct_Enums.DBContext;
    using Modul3_Classes_Struct_Enums.Models;
    using Modul3_Classes_Struct_Enums.Models.DboModels;
    using Modul3_Classes_Struct_Enums.Services;
    using Modul3_Classes_Struct_Enums.Services.Interfaces;
    using Serilog;
    using System.IO;
    using System.IO.Pipes;
    using System.Net;
    using System.Net.Http.Headers;
    using System.Text.Json;
    using System.Text;

    internal class Program
    {
        static async Task Main(string[] args)
        {
             Log.Logger = new LoggerConfiguration()
                  .WriteTo.Console()
                  .WriteTo.File("log.txt")
                  .CreateLogger();

            IApiService apiService = new ApiService();

            string token = "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";
            
            try
            {
                HttpClient client = new HttpClient();

                client.DefaultRequestHeaders.UserAgent.ParseAdd("request");

                byte[] authToken = Encoding.ASCII.GetBytes($"{token}");
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Basic", Convert.ToBase64String(authToken));


                var response = await client.GetAsync("https://api.github.com/user/emails");

                string jsonContent = "{ \"name\": \"test\", \"description\": \"test-description\", \"private\": false }";

                var content = new StringContent(jsonContent, Encoding.UTF8, "application/json");

                var postResponse = await client.PostAsync("https://api.github.com/user/repos", content);


                if (response.IsSuccessStatusCode)
                {
                    var test = response.Content.ReadAsStringAsync().Result;
                }
            }
            catch (HttpRequestException ex)
            {

                Console.WriteLine(ex);
            }


        }
      
    }
}

