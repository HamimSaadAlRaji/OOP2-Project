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
            var item = Catalogue.textbooks.Find(b => b.Title == title);
            if (item != null && item.IsAvailable())
            {
                item.setAvailibility(false);
                Console.WriteLine($"Successfully Borrowed Textbook {item.Title} ");
            }
            else if( item == null ) 
            {
                Console.WriteLine($"Text Book with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"TextBook {item.Title} is not available for borrowing");
            }
        }
    }

    public class BorrowCD : IitemBorrower
    {
        public void BorrowItem(string title)
        {
            var item = Catalogue.cds.Find(c => c.Title == title);
            if (item != null && item.IsAvailable())
            {
                item.setAvailibility(false);
                Console.WriteLine($"Successfully Borrowed CD {item.Title}");
            }
            else if (item == null)
            {
                Console.WriteLine($"CD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"CD {item.Title} is not available for borrowing");
            }
        }
    }

    public class BorrowDVD : IitemBorrower
    {
        public void BorrowItem(string title)
        {
            var item = Catalogue.dvds.Find(d => d.Title == title);
            if (item != null && item.IsAvailable())
            {
                item.setAvailibility(false);
                Console.WriteLine($"Successfully Borrowed DVD {item.Title}");
            }
            else if (item == null)
            {
                Console.WriteLine($"DVD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"DVD {item.Title} is not available for borrowing");
            }
        }
    }

}
