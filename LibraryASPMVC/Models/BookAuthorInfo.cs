using System;
using System.Collections.Generic;

namespace LibraryASPMVC.Models
{
    public partial class BookAuthorInfo
    {
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int? AuthorId { get; set; }
        public string? Name { get; set; }
    }
}
