using System.ComponentModel.DataAnnotations;

namespace IntroductionToASPNETMVC.Models
{
    public class Review
    {
        public int ReviewId { get; set; }

        [Display(Name = "Album")]
        public int AlbumId { get; set; }
        public virtual Album Album { get; set; }

        public string Content { get; set; }

        [Display(Name = "Reviewer Email")]
        public string ReviewerEmail { get; set; }
    }
}