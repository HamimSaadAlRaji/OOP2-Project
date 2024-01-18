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
            var researchookcheck = Catalogue.researchbooks.Find(b => b.Title == title);
            if(researchookcheck == null)
            {
                ResearchBook researchBook = new ResearchBook(title, author, description);
                Catalogue.researchbooks.Add(researchBook);
                Console.WriteLine("Research Book Added Successfully");
            }
            else
            {
                Console.WriteLine("ResearchBook Already Exists");
            }
            
        }
    }
    public class TextBookAdder : IitemAdder
    {
        public void AddItem(string title, string author, string description)
        {
            var bookcheck = Catalogue.textbooks.Find(b => b.Title == title);
            if (bookcheck == null)
            {
                TextBook textBook = new TextBook(title, author, description);
                Catalogue.textbooks.Add(textBook);
                Console.WriteLine("TextBook Added Successfully");
            }
            else
            {
                Console.WriteLine("TextBook Already Exists");

            }
        }
    }
    public class CDAdder : IitemAdder
    {
        public void AddItem(string title, string author, string description)
        {
            var cdcheck= Catalogue.cds.Find(b => b.Title == title);
            if (cdcheck == null)
            {
                Cd cd = new Cd(title, author, description);
                Catalogue.cds.Add(cd);
                Console.WriteLine("CD Added Successfully");
            }
            else { Console.WriteLine("CD Already Exists"); }


        }
        public class DVDAdder : IitemAdder
        {
            public void AddItem(string title, string author, string description)
            {
                var dvdcheck= Catalogue.dvds.Find(b => b.Title == title);
                if (dvdcheck == null)
                {
                    DVD dvd = new DVD(title, author, description);
                    Catalogue.dvds.Add(dvd);
                    Console.WriteLine("DVD Added Successfully");
                }
                else { Console.WriteLine("DVD Already Exists"); }
            }
        }
    }
}
