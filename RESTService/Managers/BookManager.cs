using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTService.Managers
{
    public class BookManager
    {
        private static List<Book> _book = new List<Book>()
        {
            new Book()
            {Title= "DWEFR", Author="AAA",PageNumber=1234 , ISBN="EEFW2"  },

            new Book()
            {Title= "ASD", Author="BBB",PageNumber=4321 , ISBN="DFGTZ1"  }


        };
        public List<Book> GellAll()
        {
            return new List<Book>(_book);
        }

        public Book GetBookIds(String ISBN)
        {
            return   _book.Find(x => x.ISBN == ISBN);
        }


        public void PostBooks(Book NewBook)
        {
            _book.Add(NewBook);
        }

        public void Put(string ISBN, Book UpBook)
        {
            _book.u
        }











    }
}
