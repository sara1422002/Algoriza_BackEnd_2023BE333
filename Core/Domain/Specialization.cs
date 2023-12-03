using System.ComponentModel.DataAnnotations;


namespace Core.Domain
{
    public class Specialization
    {
        [Key]
        public int ID { get; set; }

        [Required]
        [StringLength(100)]
        public string Name { get; set; }
    }
}
