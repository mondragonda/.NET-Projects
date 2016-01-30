using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntroductionToASPNETMVC.Models
{
    public class Artist
    {
        [Key]
        [ScaffoldColumn(false)]
        public int ArtistId { get; set; }
        [Required(ErrorMessage = "The name is required")]
        public string Name { get; set; }
        public virtual List<Album> Albums { get; set; }
    }
}
