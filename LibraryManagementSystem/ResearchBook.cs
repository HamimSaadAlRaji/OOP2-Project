using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal class ResearchBook : Iitem
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public bool IsAvailable { get; set; }

        public void ReadContent()
        {
          Console.WriteLine($"Reading the content of the research book: {Title} by {Author}");
          Console.WriteLine($"Description : {Description}");
        }
    }

}
