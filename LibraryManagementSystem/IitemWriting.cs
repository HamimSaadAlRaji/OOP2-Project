using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IitemWriting
    {
        void Write(string title,string description);
    }
    public class WriteInCD : IitemWriting
    {
        public void Write(string title, string description)
        {
            Cd item = Catalogue.cds.Find(c => c.Title == title);
            if (item != null && item.IsAvailable())
            {
                item.Description = description;
                Console.WriteLine($"Successfully Wrote into CD {item.Title}");
            }
            else if (item == null)
            {
                Console.WriteLine($"CD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"CD {item.Title} is currently not available for Writing");
            }
        }
    }
}
