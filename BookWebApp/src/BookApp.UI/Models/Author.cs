using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BookApp.UI.Models
{
    public class Author
    {
        [ScaffoldColumn(false)]
        public int Id { get; set; }
        [Required(ErrorMessage = "The Author's Name is Required")]
        public string Name { get; set; }
        public string Nationality { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public virtual List<Book> Books { get; set; }
    }
}
