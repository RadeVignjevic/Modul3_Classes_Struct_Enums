using Modul3_Classes_Struct_Enums.Models;
using Modul3_Classes_Struct_Enums.Services.Interfaces;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_Classes_Struct_Enums.Services
{
    public class ApiService : IApiService
    {
        private readonly HttpClient httpClient;

        public ApiService()
        {
            httpClient = new HttpClient();
        }

        public async Task<List<User>> GetAllUsers()
        {
            List<User> allUsers = await httpClient.GetFromJsonAsync<List<User>>("https://jsonplaceholder.typicode.com/users");

            return allUsers;
        }

        public async Task<User> GetRandomUser()
        {
            try
            {
                var randomUser = await httpClient.GetFromJsonAsync<User>($"https://jsonplaceholder.typicode.com/users/1");
                return randomUser;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message); 
                return null;
            }
        }

        public async Task<List<Post>> GetPostsAsync(int userId)
        {

            var allPosts = await httpClient.GetFromJsonAsync<List<Post>>("https://jsonplaceholder.typicode.com/posts");

            return allPosts.Where(x => x.UserId == userId).ToList();
        }

        public void PrintAllUsers(List<User> users)
        {
            foreach (var user in users) {
                Console.WriteLine($"{user.Name}");
            }
        }
    }
}
