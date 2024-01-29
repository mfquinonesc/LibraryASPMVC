namespace LibraryASPMVC.Models
{
    public class AuthorBookModels
    {
        public List<Author> Authors { get; set; } = new List<Author>();

        public List<BookAuthorInfo> BookAuthorInfos { get; set; } = new List<BookAuthorInfo>();

        public Author Author { get; set; } = new Author();
       

    }
}
