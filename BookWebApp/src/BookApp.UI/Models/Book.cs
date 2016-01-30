using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.UI.Models
{
    public class Book
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Book's Title is Required")]
        public string Title { get; set; }
        public string Description { get; set; }

        public int ISBN { get; set; }

        public string Genre { get; set; }

        public int Year { get; set; }
        [ScaffoldColumn(false)]
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; }
    }
}
