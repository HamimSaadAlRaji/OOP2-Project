using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace LibraryManagementSystem
{
    public class Operations : IitemOperations
    {
        private List<Iitem> libraryItems;

        public Operations()
        {
            libraryItems = new List<Iitem>();
        }

        public void AddItem(Iitem item)
        {
            libraryItems.Add(item);
            Console.WriteLine($"{item.GetType().Name} added to the library.");
        }

        public void RemoveItem(Iitem item)
        {
            if (libraryItems.Contains(item))
            {
                libraryItems.Remove(item);
                Console.WriteLine($"{item.GetType().Name} removed from the library.");
            }
            else
            {
                Console.WriteLine($"{item.GetType().Name} not found in the library.");
            }
        }

        public void SearchItemsByAuthor(string author)
        {
            var matchingItems = libraryItems.Where(item => item.Author.Equals(author, StringComparison.OrdinalIgnoreCase)).ToList();

            if (matchingItems.Any())
            {
                Console.WriteLine($"Items by {author} found in the library:");
                foreach (var matchingItem in matchingItems)
                {
                    Console.WriteLine($"{matchingItem.GetType().Name}: {matchingItem.Title}");
                }
            }
            else
            {
                Console.WriteLine($"No items by {author} found in the library.");
            }
        }


        public void DisplayAvailableItems(Iitem item)
        {
            Console.WriteLine($"Available {item.GetType().Name}s in the library:");
            foreach (var libraryItem in libraryItems.Where(i => i.GetType() == item.GetType()))
            {
                Console.WriteLine($"{libraryItem.GetType().Name}: {libraryItem.Title}");
            }
        }
    }

    public class WritableOperation : Operations, IWriteOperation
    {      
      public void WriteItem(Iwritable writable)
        {
            Console.WriteLine($"Writing {writable.GetType().Name}: {writable.Title}");
            // Add logic for writing to a writable item (e.g., a book)
        }
    }

    public class BorrowableOperation : Operations, IBorrowableOperation
    {
        public void BorrowItem(Iborrowable borrowable)
        {
            Console.WriteLine($"Borrowing {borrowable.GetType().Name}: {borrowable.Title}");
            // Add logic for borrowing a borrowable item (e.g., a book)
        }

        public void ReturnItem(Iborrowable borrowable)
        {
            Console.WriteLine($"Returning {borrowable.GetType().Name}: {borrowable.Title}");
            // Add logic for returning a borrowable item (e.g., a book)
        }
    }

}
