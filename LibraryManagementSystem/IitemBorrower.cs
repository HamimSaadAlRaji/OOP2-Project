using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IitemBorrower
    {
        void BorrowItem(string title);
    }
   
    public class BorrowTextBook : IitemBorrower
    {
        public void BorrowItem(string title)
        {
            var book = Catalogue.textbooks.Find(b => b.Title == title);
            if (book != null && book.IsAvailable)
            {
                book.IsAvailable = false;
                Console.WriteLine($"Successfully Borrowed Textbook {book.Title} ");
            }
            else if( book == null ) 
            {
                Console.WriteLine($"Text Book with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"TextBook {book.Title} is not available for borrowing");
            }
        }
    }

    public class BorrowCD : IitemBorrower
    {
        public void BorrowItem(string title)
        {
            var cd = Catalogue.cds.Find(c => c.Title == title);
            if (cd != null && cd.IsAvailable)
            {
                cd.IsAvailable = false;
                Console.WriteLine($"Successfully Borrowed CD {cd.Title}");
            }
            else if (cd == null)
            {
                Console.WriteLine($"CD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"CD {cd.Title} is not available for borrowing");
            }
        }
    }

    public class BorrowDVD : IitemBorrower
    {
        public void BorrowItem(string title)
        {
            var dvd = Catalogue.dvds.Find(d => d.Title == title);
            if (dvd != null && dvd.IsAvailable)
            {
                dvd.IsAvailable = false;
                Console.WriteLine($"Successfully Borrowed DVD {dvd.Title}");
            }
            else if (dvd == null)
            {
                Console.WriteLine($"DVD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"DVD {dvd.Title} is not available for borrowing");
            }
        }
    }

}
