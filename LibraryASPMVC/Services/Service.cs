using LibraryASPMVC.Data;

namespace LibraryASPMVC.Services
{
    public class Service
    {
        protected readonly DB_LibraryContext _context;

        public Service(DB_LibraryContext context)
        {
            this._context = context;
        }
    }
}
