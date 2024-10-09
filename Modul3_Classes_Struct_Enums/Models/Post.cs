using Modul3_Classes_Struct_Enums.Models.Base_Models;

namespace Modul3_Classes_Struct_Enums.Models
{
    public class Post : BaseClass
    {
        public int UserId { get; set; }
        public string ?Title { get; set; }
        public string ?Body { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("Onverride From Post Class");

        }

        public override void ReturnId()
        {
            Console.WriteLine("Override from Post class Return ID");
        }
    }
}
