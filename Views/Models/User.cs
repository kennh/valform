using System.ComponentModel.DataAnnotations;

namespace valform.Models
{
    public abstract class BaseEntity {}
    public class User : BaseEntity
    {
        [Required]
        [MinLength(4)]
        public string First_Name { get; set;}
        [Required]
        [MinLength(4)]
        public string Last_Name { get; set;}
        public int Age { get; set;}
        [Required]
        [EmailAddress]
        public string Email{ get; set;}
        [Required]
        [DataType(DataType.Password)]
        [MinLength(8)]
        public string Password { get; set;}
    }
}
