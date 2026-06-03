namespace LibraryManagment
{
    class Program
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
            if (menuOption == 1)
            {
                Console.WriteLine(@"
                ===== LIBRARIAN MENU =====
                1. Add a new item
                2. Remove an item
                3. View all items
                4. Register a new member
                5. View all members and their borrowed items
                6. Exit
                ==========================
                ");
            }
            else if (menuOption == 2)
            {
                Console.WriteLine(@"
                ===== MEMBER MENU =====
                1. Search for an item
                2. View available items
                3. Borrow an item
                4. Return an item
                5. View my borrowed items
                6. Exit
                =======================");
            }
        }
    }
}