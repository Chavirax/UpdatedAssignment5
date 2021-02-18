using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment5.Models
{
    public interface ICharityRepository // creating a template 
    {
        IQueryable<Book> Books { get; }
    }
}
