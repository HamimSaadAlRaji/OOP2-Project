using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface Iitem
    {
        string Id { get; set; }
        string Title { get; set; }
        string Author { get; set; }

        string Description { get; set; }
        bool IsAvailable { get; set; }

        void ReadContent(); 

    }

    public interface Iwritable : Iitem {
        void write();    
    }
    public interface Iborrowable : Iitem
    {
        void borrow();
    }
    




}
