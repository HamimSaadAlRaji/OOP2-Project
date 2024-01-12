using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface ISearchItem
    {
        void SearchItem(string title);
    }
    public class ResearchBookSearcher : ISearchItem
    {
        public void SearchItem(string title)
        {
            var book = Catalogue.researchbooks.Find(b => b.Title == title);
            if (book != null)
            {
                Console.WriteLine($"Research Book - Title: {book.Title}, Author: {book.Author}, Description: {book.Description}");
            }
            else
            {
                Console.WriteLine($"Research Book with title '{book.Title}' not found.");
            }
        }
    }

    public class TextBookSearcher : ISearchItem
    {
        public void SearchItem(string title)
        {
            var book = Catalogue.textbooks.Find(b => b.Title == title);
            if (book != null)
            {
                Console.WriteLine($"Text Book - Title: {book.Title}, Author: {book.Author}, Description: {book.Description}");
            }
            else
            {
                Console.WriteLine($"Text Book with title '{title}' not found.");
            }
        }
    }

    public class CDSearcher : ISearchItem
    {
        public void SearchItem(string title)
        {
            var cd = Catalogue.cds.Find(c => c.Title == title);
            if (cd != null)
            {
                Console.WriteLine($"CD - Title: {cd.Title}, Author: {cd.Author}, Description: {cd.Description}");
            }
            else
            {
                Console.WriteLine($"CD with title '{title}' not found.");
            }
        }
    }

    public class DVDSearcher : ISearchItem
    {
        public void SearchItem(string title)
        {
            var dvd = Catalogue.dvds.Find(d => d.Title == title);
            if (dvd != null)
            {
                Console.WriteLine($"DVD - Title: {dvd.Title}, Author: {dvd.Author}, Description: {dvd.Description}");
            }
            else
            {
                Console.WriteLine($"DVD with title '{title}' not found.");
            }
        }
    }
}
