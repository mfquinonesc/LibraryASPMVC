using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryASPMVC.Models
{
    public partial class Author
    {
        public int AuthorId { get; set; }

        [Required]
        public string? Name { get; set; }
    }
}
