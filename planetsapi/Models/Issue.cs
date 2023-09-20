using System.ComponentModel.DataAnnotations;

namespace planetsapi.Models
{
    public class Issue
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int Distance_From_Sun { get; set; }

    }

}
