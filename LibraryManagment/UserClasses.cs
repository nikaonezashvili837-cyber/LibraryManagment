namespace LibraryManagment
{
    partial class Program
    {
        class User
        {
            public string? Name { get; set; }
            public User()
            {

            }
            public User(string? name)
            {
                Name = name;
            }
            public string WelcomeMessage()
            {
                return "Welcome " + Name;
            }
        }
        class Librarian : User
        {
            public LibraryItem CreateNewItem()
            {
                try
                {
                    Console.WriteLine("Enter title");
                    string? title = Console.ReadLine();
                    Console.WriteLine("Enter publication year");
                    int publicationYear = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Author");
                    string? author = Console.ReadLine();
                    LibraryItem libraryItem = new LibraryItem(title, publicationYear, author);
                    return libraryItem;
                }
                catch
                {
                    Console.WriteLine("Enter valid input");
                    LibraryItem libraryItem = new LibraryItem("failed");
                    return libraryItem;
                }

            }
        }
    }
}