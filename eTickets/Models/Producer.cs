using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تصویر تهیه‌کننده")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }

        [Display(Name = "درباره تهیه‌کننده")]
        public string Bio { get; set; }

        // Relationshipts.
        public List<Movie> Movies { get; set; }
    }
}
