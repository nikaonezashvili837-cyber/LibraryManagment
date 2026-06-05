

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
            InitilizeMenu(userName, menuOption);
        }
        public static void InitilizeMenu(string? userName, int menuOption)
        {
            User user = new User(userName);
            Console.WriteLine($@"
            
            ==========================
            {user.WelcomeMessage()}
            ==========================");
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
                Console.WriteLine(librarianMenu);
                int? librerianMenuOption = Convert.ToInt32(Console.ReadLine());
            }
            else
            {
                Console.WriteLine(memberMenu);
                int? memberMenuOption = Convert.ToInt32(Console.ReadLine());
            }
        }
    }

}