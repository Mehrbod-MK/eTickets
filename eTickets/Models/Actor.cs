using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "تصویر بازیگر")]
        public string ProfilePictureURL { get; set; }

        [Display(Name = "نام و نام خانوادگی")]
        public string FullName { get; set; }

        [Display(Name = "درباره بازیگر")]
        public string Bio { get; set; }

        // Relationships.
        public List<Actor_Movie> Actors_Movies { get; set; }
    }
}
