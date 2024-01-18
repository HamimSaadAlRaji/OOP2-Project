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
            var item = Catalogue.researchbooks.Find(b => b.Title == title);
            if(item == null)
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
            var item = Catalogue.textbooks.Find(b => b.Title == title);
            if (item == null)
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
            var item= Catalogue.cds.Find(b => b.Title == title);
            if (item == null)
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
                var item= Catalogue.dvds.Find(b => b.Title == title);
                if (item == null)
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
