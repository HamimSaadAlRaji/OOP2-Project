using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static LibraryManagementSystem.CDAdder;

namespace LibraryManagementSystem 
{
    class LibraryManagementSystem
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string[] Options = { "ResearchBook", "TextBook", "CD", "DVD", "Exit" };
                Menu menu = new Menu(Options);


                int choice = menu.Run();

                switch (choice)
                {
                    
                    case 0:
                        Console.Clear();
                        HandleResearchBook();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 1:
                        Console.Clear();
                        HandleTextBook();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 2:
                        Console.Clear();
                        HandleCD();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;
                    case 3:
                        Console.Clear();
                        HandleDVD();
                        Console.WriteLine();
                        Console.WriteLine("Press Any Key To Continue");
                        Console.ReadKey(true);
                        Console.Clear();

                        break;

                    case 4:
                        Console.WriteLine("Exiting program.");
                        return;


                }
            }
        }

        private static void HandleResearchBook()
        {
            string[] Options = { "Add New ResearchBook", "Remove ResearchBook","Display ResearchBook", "Search ResearchBook", "Go Back"};
            Menu menu = new Menu(Options);
            int choice = menu.Run();
           

            switch (choice)
            {
                
                case 0:
                    Console.Clear();
                    IitemAdder researchBookAdder = new ResearchBookAdder();
                    Catalogue.AddToLibrary(researchBookAdder);
                    break;
                case 1:
                    Console.Clear();
                    IitemRemover RemoveresearchBook = new ResearchBookRemover();
                    Catalogue.RemoveFromLibrary(RemoveresearchBook);
                    break;
                case 2 : Console.Clear();
                    IitemDisplay iitemDisplay = new ResearchBookDisplay();
                    Catalogue.DisplayLibraryItem(iitemDisplay);
                    break;
                case 3:
                    Console.Clear();
                    ISearchItem searchItem = new ResearchBookSearcher();
                    Catalogue.SearchFromLibrary(searchItem);
                    break;
                case 4:
                    return;


            }
        }

        private static void HandleTextBook()
        {
            string[] Options = { "Add New TextBook", "Remove TextBook", "Display Textbooks", "Search TextBook", "Borrow Textbook", "Go Back" };
            Menu menu = new Menu(Options);
            int choice = menu.Run();
           

            switch (choice)
            {
               
                case 0:
                    Console.Clear();
                    IitemAdder TextBookAdder = new TextBookAdder();
                    Catalogue.AddToLibrary(TextBookAdder);
                    break;
                case 1:
                    Console.Clear();
                    IitemRemover RemoveTextBook = new TextBookRemover();
                    Catalogue.RemoveFromLibrary(RemoveTextBook);
                    break;

                case 2:
                    Console.Clear();
                    IitemDisplay iitemDisplay = new TextBookDisplay();
                    Catalogue.DisplayLibraryItem(iitemDisplay);
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
                case 5:
                    return;
            }
        }

        private static void HandleCD()
        {
            string[] Options = { "Add New CD", "Remove CD", "Display CDs", "Search CD", "Borrow CD", " Write In CD ", "Go Back" };
            Menu menu = new Menu(Options);
            int choice = menu.Run();
            Console.WriteLine("CD Options:");
            Console.WriteLine("1. Add New CD");
            Console.WriteLine("2. Remove CD");
            Console.WriteLine("3. Search CD");
            Console.WriteLine("4. Borrow CD");
            Console.WriteLine("4. Write In CD");
            Console.WriteLine("0. Go Back");           

            switch (choice)
            {
                
                case 0:
                    Console.Clear();
                    IitemAdder CDAdder = new CDAdder();
                    Catalogue.AddToLibrary(CDAdder);
                    break;
                case 1:

                    Console.Clear();
                    IitemRemover RemoveCD = new CDRemover();
                    Catalogue.RemoveFromLibrary(RemoveCD);
                    break;
                case 2:
                    Console.Clear();
                    IitemDisplay iitemDisplay = new CDDisplay();
                    Catalogue.DisplayLibraryItem(iitemDisplay);
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
                case 6:
                    return;
            }
        }

        private static void HandleDVD()
        {
            string[] Options = { "Add New DVD", "Remove DVD", "Display DVDs", "Search DVD", "Borrow DVD", "Go Back" };
            Menu menu = new Menu(Options);
            int choice = menu.Run();            

            switch (choice)
            {
                
                case 0:
                    Console.Clear();
                    IitemAdder dvdadder = new DVDAdder();
                    Catalogue.AddToLibrary(dvdadder);
                    break;
                case 1:
                    Console.Clear();
                    IitemRemover RemoveDVD = new DVDRemover();
                    Catalogue.RemoveFromLibrary(RemoveDVD);
                    break;

                case 2:
                    Console.Clear();
                    IitemDisplay iitemDisplay = new DVDDisplay();
                    Catalogue.DisplayLibraryItem(iitemDisplay);
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
                case 5:
                    return;
            }
        }

      
    }
}
    

    
