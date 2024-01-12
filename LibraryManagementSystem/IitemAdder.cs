using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    
    public interface IitemAdder
    {
        void AddItem(string title, string author, string description);
    }
    public class ResearchBookAdder : IitemAdder
    {        
        public void  AddItem(string title, string author, string description)
        {
            ResearchBook researchBook = new ResearchBook(title, author, description);
            Catalogue.researchbooks.Add(researchBook);
            Console.WriteLine("Research Book Added Successfully");
        }
    }
    public class TextBookAdder : IitemAdder
    {
        public void AddItem(string title, string author, string description)
        {
            TextBook textBook = new TextBook(title, author, description);
            Catalogue.textbooks.Add(textBook);
            Console.WriteLine("TextBook Added Successfully");
        }
    }
    public class CDAdder : IitemAdder
    {
        public void AddItem(string title, string author, string description)
        {
            Cd cd = new Cd(title, author, description);
            Catalogue.cds.Add(cd);
            Console.WriteLine("CD Added Successfully");
        }
    }
    public class DVDAdder : IitemAdder
    {
        public void AddItem(string title, string author, string description)
        {
            DVD dvd = new DVD(title, author, description);
            Catalogue.dvds.Add(dvd);
            Console.WriteLine("DVD Added Successfully");
        }
    }
}
