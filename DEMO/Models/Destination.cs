using System.ComponentModel.DataAnnotations;

namespace DEMO.Models
{
    public class Destination
    {
        [Key]
        public int idDes { get; set; }

        public string name { get; set; }

        public string description { get; set; }

        public string image { get; set; }

        public Utilisateur user { get; set; }


    }
}
