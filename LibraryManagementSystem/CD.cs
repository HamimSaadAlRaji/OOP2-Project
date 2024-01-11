using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class Cd : Iwritable, Iborrowable
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        public Cd(string id, string title, string author, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            IsAvailable = true;
        }

        public void ReadContent()
        {
            
            Console.WriteLine($"Playing the content of the CD: {Title} by {Author}");
            Console.WriteLine($"Description : {Description}");
        }

        public void write()
        {
            if (IsAvailable)
            {
                Console.WriteLine($"Writing data to the CD: {Title} by {Author}");
                Console.Write("Enter new description: ");
                Description = Console.ReadLine();
                IsAvailable = false;
                Console.WriteLine($"CD {Title} updated.");
            }
            else
            {
                Console.WriteLine($"CD {Title} is not available for writing.");
            }
        }

        public void borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"CD {Title} borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"CD {Title} is not available for borrowing.");
            }
        }
    }
}
