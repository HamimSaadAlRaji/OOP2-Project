using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface Iitem
    {
        string Title { get; set; }
        string Author { get; set; }
        string Description { get; set; }
        
    }
    public interface Iborrowableitem : Iitem
    {
         bool isAvailable { get; set; }
         bool IsAvailable();
        void setAvailibility(bool availablity);
    }





}
