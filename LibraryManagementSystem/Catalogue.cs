using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public static class Catalogue
    {
        public static List<DVD> dvds = new List<DVD>();
        public static  List<Cd> cds = new List<Cd>();
        public static List<TextBook> textbooks = new List<TextBook>();
        public static List<ResearchBook> researchbooks = new List<ResearchBook>();

        public static void AddToLibrary(IitemAdder item)
        {
            Console.WriteLine("Title Of The Item:");
            string title = Console.ReadLine();
            Console.WriteLine("Author Name:");
            string author = Console.ReadLine();
            Console.WriteLine("Description:");
            string description = Console.ReadLine();
            item.AddItem(title, author, description);
            Console.WriteLine();
            
        }
        public static void RemoveFromLibrary(IitemRemover itemRemover)
        {
            Console.WriteLine("Title Of The Item you want to remove:");
            string title = Console.ReadLine();
            itemRemover.RemoveItem(title);
            Console.WriteLine();            
        }
        public static void SearchFromLibrary(ISearchItem searchItem)
        {
            Console.WriteLine("Title Of The Item you want to search:");
            string title = Console.ReadLine();
            searchItem.SearchItem(title);
        }
        public static void BorrowFromLibrary(IitemBorrower BorrowItem)
        {
            Console.WriteLine("Title Of The Item you want to Borrow:");
            string title = Console.ReadLine();
            BorrowItem.BorrowItem(title);
        }
        public static void WriteIntoItem(IitemWriting WriteItem)
        {
            Console.WriteLine("Title Of The Item you want to Write:");
            string title = Console.ReadLine();
            Console.Write("Description:");
            string description = Console.ReadLine();
            WriteItem.Write(title, description );
        }

    }
}
