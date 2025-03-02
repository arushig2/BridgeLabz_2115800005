using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CommonLayer
{
    public class Employee
    {
        [Key]  
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)] 
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Password { get; set; }

    }
}
