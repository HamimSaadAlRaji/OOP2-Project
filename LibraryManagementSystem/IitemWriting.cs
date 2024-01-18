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
            Cd cd = Catalogue.cds.Find(c => c.Title == title);
            if (cd != null && cd.IsAvailable)
            {
                cd.Description = description;
                Console.WriteLine($"Successfully Wrote into CD {cd.Title}");
            }
            else if (cd == null)
            {
                Console.WriteLine($"CD with title '{title}' not found.");
            }
            else
            {
                Console.WriteLine($"CD {cd.Title} is currently not available for Writing");
            }
        }
    }
}
