

using System.Security.Authentication;
using System.Text.Json;

namespace LibraryManagment
{
    partial class Program
    {
        public static void Main()
        {
            Console.WriteLine(@"
            ===== LOGIN MENU =====
            Log in as:
            1. Librarian
            2. Member
            Choose an option (1-2):
            ======================
            ");
            int menuOption = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter username:");
            string? userName = Console.ReadLine();
            while (userName == "")
            {
                Console.WriteLine("Enter valid username");
                userName = Console.ReadLine();
            }
            InitilizeMenu(userName);
            ActivateUserOptions(menuOption);
        }
        public static void InitilizeMenu(string? userName)
        {
            User user = new User(userName);
            Console.WriteLine($@"
            
            ==========================
            {user.WelcomeMessage()}
            ==========================");
        }
        public static void ActivateUserOptions(int menuOption)
        {
            string librarianMenu = @"
            ===== LIBRARIAN MENU =====
            1. Add a new item
            2. Remove an item
            3. View all items
            4. Register a new member
            5. View all members and their borrowed items
            6. Exit
            ==========================";
            string memberMenu = @"
            ===== MEMBER MENU =====
            1. Search for an item
            2. View available items
            3. Borrow an item
            4. Return an item
            5. View my borrowed items
            6. Exit
            ==========================";
            if (menuOption == 1)
            {
                Librarian librarian = new Librarian();
                Console.WriteLine(librarianMenu);
                bool programIsRunning = true;
                while (programIsRunning)
                {
                    int librarianMenuOption = Convert.ToInt32(Console.ReadLine());
                    switch (librarianMenuOption)
                    {

                        case 1:
                            List<LibraryItem>? libraryItems = ExtractListItems<LibraryItem>("LibraryItems.json");
                            LibraryItem libraryItem = librarian.CreateNewItem();
                            if (libraryItem.Title != "failed" && libraryItems != null && !CheckDublicates(libraryItems, libraryItem))
                            {
                                libraryItems.Add(libraryItem);
                            }
                            if (libraryItems != null)
                            {
                                WriteNewItem(libraryItems);
                            }
                            Console.WriteLine(librarianMenu);
                            break;
                        case 2:
                            Console.WriteLine("Enter book title to remove:");
                            string? bookToRemove = Console.ReadLine();
                            RemoveItem(bookToRemove);
                            Console.WriteLine(librarianMenu);
                            break;
                        case 3:
                            ViewAllItems();
                            break;
                        case 4:
                            break;
                        case 6:
                            programIsRunning = false;
                            break;
                    }
                }
            }
            else
            {
                Console.WriteLine(memberMenu);
                int? memberMenuOption = Convert.ToInt32(Console.ReadLine());
            }
        }
        public static List<T>? ExtractListItems<T>(string filePath)
        {
            List<T>? Items = new List<T>(); ;
            string jsonContent = File.ReadAllText(filePath);
            if (jsonContent != "")
            {
                List<T>? jsonArray = JsonSerializer.Deserialize<List<T>>(jsonContent);
                Items = jsonArray;
            }
            return Items;
        }
    }
}