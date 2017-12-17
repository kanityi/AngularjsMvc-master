using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AngularjsMvc.Models.EF
{
    [Table("Users")]
    public class User
    {
       
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Identity_Type { get; set; }
        public string Identiy_Number { get; set; }
        public string Date_Of_Birth { get; set; }
    }
}