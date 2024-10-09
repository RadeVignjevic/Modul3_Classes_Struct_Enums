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
    using System.Text.Json;

    internal class Program
    {
        static void Main(string[] args)
        {
             Log.Logger = new LoggerConfiguration()
                  .WriteTo.Console()
                  .WriteTo.File("log.txt")
                  .CreateLogger();

            IApiService apiService = new ApiService();

            try
            {
                AddAppContext context = new AddAppContext();

                //DboUser user = new DboUser
                //{
                //    Name = "Rade",
                //    UserName = "Rade_Vig"
                //};

                //context.DboUser.Add(user);
                List<DboUser> usersToBeUpdated = context.DboUser.Where(x=>x.UserDescription == "").ToList();

                foreach (DboUser user in usersToBeUpdated)
                {
                    user.UserDescription = "test";

                    context.DboUser.Update(user);
                }

                context.SaveChanges();

                //DboPost dboPost = new DboPost
                //{
                //    UserId = 10,
                //    Title = "Test",
                //};

                //context.DboPost.Add(dboPost);
                //context.SaveChanges();


            }
            catch (Exception ex)
            {
                Console.WriteLine($"Exception {ex}");
            }
           
        }
      
    }
}

