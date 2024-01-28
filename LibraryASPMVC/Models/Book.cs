using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace LibraryASPMVC.Models
{
    public partial class Book
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; } = null!;

        [Required]
        public int? AuthorId { get; set; }
    }
}
