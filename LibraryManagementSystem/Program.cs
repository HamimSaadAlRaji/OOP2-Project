using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            Operations libraryOperations = new Operations();

            while (true)
            {
                Console.WriteLine("Library Management System Menu:");
                Console.WriteLine("1. Choose an Item");
                Console.WriteLine("2. Display Available Items");
                Console.WriteLine("3. Exit");

                Console.Write("Enter your choice (1-3): ");
                string mainChoice = Console.ReadLine();

                switch (mainChoice)
                {
                    case "1":
                        Console.WriteLine("Choose an Item:");
                        Console.WriteLine("1. CD");
                        Console.WriteLine("2. DVD");
                        Console.WriteLine("3. Research Book");
                        Console.WriteLine("4. TextBook");
                        Console.Write("Enter your choice (1-4): ");
                        string itemTypeChoice = Console.ReadLine();

                        switch (itemTypeChoice)
                        {
                            case "1":
                                /* HandleCd(libraryOperations);
                                 break;
                             case "2":
                                 HandleDvd(libraryOperations);
                                 break;
                             case "3":
                                 HandleResearchBook(libraryOperations);
                                 break;
                             case "4":
                                 HandleTextBook(libraryOperations);
                                 break;
                             default:
                                 Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                                 break;*/

                                IItemHandler itemHandler = ItemHandlerFactory.CreateItemHandler(itemTypeChoice);

                                if (itemHandler != null)
                                {
                                    itemHandler.Handle(libraryOperations);
                                }
                                else
                                {
                                    Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                                }
                                break;

                            case "2":
                                // Similar to the previous version, display available items based on user choice
                                // ...
                                break;

                            case "3":
                                Console.WriteLine("Exiting Library Management System. Goodbye!");
                                return;

                            default:
                                Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                                break;
                        }
                        break;
                
                        

                    case "2":
                        Console.WriteLine("Select the type of item to display:");
                        Console.WriteLine("1. Research Book");
                        Console.WriteLine("2. DVD");
                        Console.WriteLine("3. CD");
                        Console.WriteLine("4. Textbook");
                        Console.Write("Enter your choice (1-4): ");
                        string itemTypeToDisplay = Console.ReadLine();

                        switch (itemTypeToDisplay)
                        {
                            case "1":
                                libraryOperations.DisplayAvailableItems(new ResearchBook());
                                break;
                            case "2":
                                libraryOperations.DisplayAvailableItems(new DVD("", "", "", ""));
                                break;
                            case "3":
                                libraryOperations.DisplayAvailableItems(new Cd("", "", "", ""));
                                break;
                            case "4":
                                libraryOperations.DisplayAvailableItems(new TextBook("", "", "", ""));
                                break;
                            default:
                                Console.WriteLine("Invalid choice. Please enter a number between 1 and 4.");
                                break;
                        }
                        break;

                    case "3":
                        Console.WriteLine("Exiting Library Management System. Goodbye!");
                        return;

                    default:
                        Console.WriteLine("Invalid choice. Please enter a number between 1 and 3.");
                        break;
                }
            }
        }
    }

    }
