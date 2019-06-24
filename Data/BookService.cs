using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using blazorserversidetest3.Models;

namespace blazorserversidetest3.Data
{
    public class BookService
    {
        private readonly MyContext _context = new MyContext();
        /* 
        public BookService(MyContext context) {
            this._context = context;
        }
        */
        
        public List<Book> GetBookList()
        {
            return this._context.Book.ToList();
            
        }
    }
}
