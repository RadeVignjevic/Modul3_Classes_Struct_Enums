using Modul3_Classes_Struct_Enums.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul3_Classes_Struct_Enums.Services.Interfaces
{
    public interface IApiService {

        Task<User> GetRandomUser();

        Task<List<User>> GetAllUsers();

        /// <summary>
        /// Print All the users
        /// </summary>
        /// <param name="users"></param>
        void PrintAllUsers(List<User> users);

        Task<List<Post>> GetPostsAsync(int userId);
    }
}
