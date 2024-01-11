using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public interface IitemOperations
    {
        void AddItem( Iitem item);
        void RemoveItem(Iitem item);
        void SearchItemsByAuthor(string author);
        void DisplayAvailableItems(Iitem item);
    }

    public interface IBorrowableOperation
    {
        void BorrowItem(Iborrowable borrowable);
        void ReturnItem(Iborrowable borrowable);
    }

    public interface IWriteOperation {
    
        void WriteItem(Iwritable writable);
    }
}
