using System.ComponentModel.DataAnnotations;

namespace introAPI2.Models
{
    public class Students
    {
        [Required]
        [Key]
        public short StudentId { get; set; }

        public string StudentFirstName { get; set; }
        
        public string StudentLastName { get; set; }
    }
}
