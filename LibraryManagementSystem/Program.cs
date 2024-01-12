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
            while (true)
            {
                Console.WriteLine("Choose an item type:");
                Console.WriteLine("1. ResearchBook");
                Console.WriteLine("2. TextBook");
                Console.WriteLine("3. CD");
                Console.WriteLine("4. DVD");
                Console.WriteLine("0. Exit");

                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 0:
                        Console.WriteLine("Exiting program.");
                        return;
                    case 1:
                        Console.Clear();
                        HandleResearchBook();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 2:
                        Console.Clear();
                        HandleTextBook();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        HandleCD();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 4:
                        Console.Clear();
                        HandleDVD();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        continue;
                        
 
                }
            }
        }

        private static void HandleResearchBook()
        {
            Console.WriteLine("ResearchBook Options:");
            Console.WriteLine("1. Add New ResearchBook");
            Console.WriteLine("2. Remove ResearchBook");
            Console.WriteLine("3. Search ResearchBook");
            Console.WriteLine("0. Go Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return; 
                case 1:
                    Console.Clear();
                    IitemAdder researchBookAdder = new ResearchBookAdder();
                    Catalogue.AddToLibrary(researchBookAdder);
                    break;
                case 2:
                    Console.Clear();
                    IitemRemover RemoveresearchBook = new ResearchBookRemover();
                    Catalogue.RemoveFromLibrary(RemoveresearchBook);
                    break;
                case 3:
                    Console.Clear();
                    ISearchItem searchItem = new ResearchBookSearcher();
                    Catalogue.SearchFromLibrary(searchItem);
                    break;
                default :
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        private static void HandleTextBook()
        {
            Console.WriteLine("TextBook Options:");
            Console.WriteLine("1. Add New TextBook");
            Console.WriteLine("2. Remove TextBook");
            Console.WriteLine("3. Search TextBook");
            Console.WriteLine("4. Borrow TextBook");
            Console.WriteLine("0. Go Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.Clear();
                    IitemAdder TextBookAdder = new TextBookAdder();
                    Catalogue.AddToLibrary(TextBookAdder);
                    break;
                case 2:
                    Console.Clear();
                    IitemRemover RemoveTextBook = new TextBookRemover();
                    Catalogue.RemoveFromLibrary(RemoveTextBook);
                    break;
                case 3:
                    Console.Clear();
                    ISearchItem searchItem = new TextBookSearcher();
                    Catalogue.SearchFromLibrary(searchItem);
                    break;
                case 4:
                    Console.Clear();
                    IitemBorrower iitemBorrower = new BorrowTextBook();
                    Catalogue.BorrowFromLibrary(iitemBorrower);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        private static void HandleCD()
        {
            Console.WriteLine("CD Options:");
            Console.WriteLine("1. Add New CD");
            Console.WriteLine("2. Remove CD");
            Console.WriteLine("3. Search CD");
            Console.WriteLine("4. Borrow CD");
            Console.WriteLine("4. Write In CD");
            Console.WriteLine("0. Go Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.Clear();
                    IitemAdder CDAdder = new CDAdder();
                    Catalogue.AddToLibrary(CDAdder);
                    break;
                case 2:

                    Console.Clear();
                    IitemRemover RemoveCD = new CDRemover();
                    Catalogue.RemoveFromLibrary(RemoveCD);
                    break;
                case 3:
                    Console.Clear();
                    ISearchItem searchItem = new CDSearcher();
                    Catalogue.SearchFromLibrary(searchItem);
                    break;
                case 4:
                    Console.Clear();
                    IitemBorrower iitemBorrower = new BorrowCD();
                    Catalogue.BorrowFromLibrary(iitemBorrower);
                    break;
                case 5:
                    Console.Clear();
                    IitemWriting WriteCd = new WriteInCD();
                    Catalogue.WriteIntoItem(WriteCd);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

        private static void HandleDVD()
        {
            Console.WriteLine("DVD Options:");
            Console.WriteLine("1. Add New DVD");
            Console.WriteLine("2. Remove DVD");
            Console.WriteLine("3. Search DVD");
            Console.WriteLine("4. Borrow DVD");
            Console.WriteLine("0. Go Back");

            int choice = int.Parse(Console.ReadLine());

            switch (choice)
            {
                case 0:
                    return;
                case 1:
                    Console.Clear();
                    IitemAdder DVDAdder = new DVDAdder();
                    Catalogue.AddToLibrary(DVDAdder);
                    break;
                case 2:
                    Console.Clear();
                    IitemRemover RemoveDVD = new DVDRemover();
                    Catalogue.RemoveFromLibrary(RemoveDVD);
                    break;
                case 3:
                    Console.Clear();
                    ISearchItem searchItem = new DVDSearcher();
                    Catalogue.SearchFromLibrary(searchItem);
                    break;
                case 4:
                    Console.Clear();
                    IitemBorrower iitemBorrower = new BorrowDVD();
                    Catalogue.BorrowFromLibrary(iitemBorrower);
                    break;
                default:
                    Console.WriteLine("Invalid Input");
                    break;
            }
        }

      
    }
}
    

    
