using Modul3_Classes_Struct_Enums.Models.Base_Models;

namespace Modul3_Classes_Struct_Enums.Models
{
    //[Serializable]
    public class User : BaseClass
    {
        public string Name { get; set; }
        public string UserName { get;set; }
        public string Email { get; set; }

        public override void DisplayInfo()
        {
            Console.WriteLine("Onverride From User Class");
        }
        public override void ReturnId()
        {
            base.ReturnId();
        }
    }
}
