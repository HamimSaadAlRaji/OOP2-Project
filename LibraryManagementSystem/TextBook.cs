using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class TextBook : Iborrowableitem
    {      
       
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool isAvailable { get; set; }
        public bool IsAvailable() { return isAvailable; }
        public void setAvailibility(bool availablity) {
            isAvailable = availablity;
        }

        public TextBook(string title, string author, string description)
        {            
            Title = title;
            Author = author;
            Description = description;
            isAvailable = true;
        }

       

      
       
    }
}
