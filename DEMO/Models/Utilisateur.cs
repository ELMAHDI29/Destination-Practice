using System.ComponentModel.DataAnnotations;

namespace DEMO.Models
{
    public class Utilisateur
    {

        [Key]
        public int idUser { get; set; }
        
        public string nom { get; set; }

        public string email { get; set; }

        public string telephone { get; set; }
    }
}
