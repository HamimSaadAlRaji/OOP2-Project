using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IitemDisplay
    {
        void Display();
    }

    public class ResearchBookDisplay : IitemDisplay
    {
        public void Display()
        {
            Console.WriteLine("Research Books in Catalogue:");
            foreach (var researchBook in Catalogue.researchbooks)
            {
                Console.WriteLine($"Title: {researchBook.Title}, Author: {researchBook.Author}, Description: {researchBook.Description}");
            }
        }
    }

    public class TextBookDisplay : IitemDisplay
    {
        public void Display()
        {
            Console.WriteLine("TextBooks in Catalogue:");
            foreach (var textBook in Catalogue.textbooks)
            {
                Console.WriteLine($"Title: {textBook.Title}, Author: {textBook.Author}, Description: {textBook.Description}");
            }
        }
    }

    public class CDDisplay : IitemDisplay
    {
        public void Display()
        {
            Console.WriteLine("CDs in Catalogue:");
            foreach (var cd in Catalogue.cds)
            {
                Console.WriteLine($"Title: {cd.Title}, Author: {cd.Author}, Description: {cd.Description}");
            }
        }
    }

    public class DVDDisplay : IitemDisplay
    {
        public void Display()
        {
            Console.WriteLine("DVDs in Catalogue:");
            foreach (var dvd in Catalogue.dvds)
            {
                Console.WriteLine($"Title: {dvd.Title}, Author: {dvd.Author}, Description: {dvd.Description}");
            }
        }
    }
}
