using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace IntroductionToASPNETMVC.Models
{
    public class Album
    {
        [ScaffoldColumn(false)]
        public int AlbumId { get; set; }
        [Required(ErrorMessage = "The title is required")]
        [Display(Name = "Album")]
        public string Title { get; set;}
        public virtual Artist Artist { get; set; }
        public virtual List<Review> Reviews { get; set; }
    }
}