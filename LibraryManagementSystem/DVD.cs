using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class DVD : Iborrowable
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        public DVD(string id, string title, string author, string description)
        {
            Id = id;
            Title = title;
            Author = author;            
            Description = description;
            IsAvailable = true;
        }
        public void ReadContent()
        {

            Console.WriteLine($"Playing the content of the DVD: {Title} by {Author}");
            Console.WriteLine($"Description : {Description}");
        }
        public void borrow()
        {
            if (IsAvailable)
            {
                IsAvailable = false;
                Console.WriteLine($"DVD {Title} borrowed successfully.");
            }
            else
            {
                Console.WriteLine($"DVD {Title} is not available for borrowing.");
            }
        }
    }
}
