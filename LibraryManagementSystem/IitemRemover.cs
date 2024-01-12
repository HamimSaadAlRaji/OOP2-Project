using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IitemRemover
    {
        void RemoveItem(string title);
    }
    public class ResearchBookRemover : IitemRemover
    {
        public void RemoveItem(string title)
        {
            Catalogue.researchbooks.RemoveAll(book => book.Title == title);
            Console.WriteLine();
            Console.WriteLine($"{title} ResearchBook Removed Successfully");
        }
    }

    public class TextBookRemover : IitemRemover
    {
        public void RemoveItem(string title)
        {
            Catalogue.textbooks.RemoveAll(book => book.Title == title);
           Console.WriteLine();
            Console.WriteLine($"{title} TexthBook Removed Successfully");
        }
    }

    public class CDRemover : IitemRemover
    {
        public void RemoveItem(string title)
        {
            Catalogue.cds.RemoveAll(cd => cd.Title == title);
            Console.WriteLine();
            Console.WriteLine($"{title} CD Removed Successfully");
        }
    }

    public class DVDRemover : IitemRemover
    {
        public void RemoveItem(string title)
        {
            Catalogue.dvds.RemoveAll(dvd => dvd.Title == title);
            Console.WriteLine();
            Console.WriteLine($"{title} DVD Removed Successfully");
        }
    }
}
