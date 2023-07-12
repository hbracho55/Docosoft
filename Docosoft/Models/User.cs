using System.ComponentModel.DataAnnotations;

namespace Docosoft.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string SurName { get; set; }

        [Required]
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime Created { get; set; }

    }
}
