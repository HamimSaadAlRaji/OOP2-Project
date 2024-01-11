using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class TextBook : Iborrowable
    {

        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        public TextBook(string id, string title, string author, string description)
        {
            Id = id;
            Title = title;
            Author = author;
            Description = description;
            IsAvailable = true;
        }

        public void ReadContent()
        {
            Console.WriteLine($"Reading the content of the textbook: {Title} by {Author}");
        }

        public void borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"Textbook {Title} borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"Textbook {Title} is not available for borrowing.");
            }
        }
    }
}
