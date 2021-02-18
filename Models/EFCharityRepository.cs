using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public class EFCharityRepository : ICharityRepository
    {
        private CharityDbContext _context;

        //constructor
        public EFCharityRepository (CharityDbContext context)
        {
            _context = context;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
