using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Modul3_Classes_Struct_Enums.Models.Base_Models
{
    public abstract class BaseClass
    {
        [JsonPropertyName("id")]
        public int Id { get; set; }

        public abstract void DisplayInfo();

        public virtual void ReturnId()
        {
            Console.WriteLine("called from base class");
        }
    }
}
