using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    internal interface IItemHandler
    {
        void Handle(Operations libraryOperations);
    }

    class CdHandler : IItemHandler
    {
        public void Handle(Operations libraryOperations)
        {
            Console.WriteLine("CD Options:");
            Console.WriteLine("1. Write to CD");
            Console.WriteLine("2. Borrow CD");
            Console.WriteLine("3. Back to Main Menu");
            Console.Write("Enter your choice (1-3): ");
            string cdChoice = Console.ReadLine();

            Cd cd = CreateCd();

            switch (cdChoice)
            {
                case "1":
                    WritableOperation writableOperation = new WritableOperation();
                    writableOperation.WriteItem(cd);
                    break;
                case "2":
                    BorrowableOperation borrowableOperation = new BorrowableOperation();
                    borrowableOperation.BorrowItem(cd);
                    break;
                case "3":
                    break; // Do nothing and go back to the main menu
                default:
                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                    break;
            }
        }
        private Cd CreateCd()
        {
            Console.Write("Enter CD Title: ");
            string title = Console.ReadLine();
            Console.Write("Enter Artist: ");
            string artist = Console.ReadLine();
            Console.Write("Enter Description: ");
            string description = Console.ReadLine();

            return new Cd("", title, artist, description);
        }
    }
    static class ItemHandlerFactory
    {
        public static IItemHandler CreateItemHandler(string itemTypeChoice)
        {
            switch (itemTypeChoice)
            {
                case "1":
                    return new CdHandler();
                // Similar cases for other item types...
                default:
                    return null;
            }
        }
    }
}
