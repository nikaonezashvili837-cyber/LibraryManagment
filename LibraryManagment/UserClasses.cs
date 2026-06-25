using System.Text.Json;
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
            class LibraryMember : User
            {
                public string? Email { get; set; }
                public DateTime RegistrationDate { get; set; }
                public LibraryMember(DateTime registrationDate, string? name, string? email = "") : base(name)
                {
                    Email = email;
                    RegistrationDate = registrationDate;
                }
            }
            public void RegisterNewMember()
            {
                try
                {
                    Console.Write("Enter members name: ");
                    string? name = Console.ReadLine();

                    Console.Write("Enter email: ");
                    string? email = Console.ReadLine();

                    Console.Write("Enter registration date (yyyy-MM-dd): ");
                    DateTime RegistrationDate = DateTime.Parse(Console.ReadLine()!);
                    LibraryMember member = new LibraryMember(RegistrationDate, name, email);
                    List<LibraryMember>? memberList = ExtractListItems<LibraryMember>("members.json");
                    if (memberList != null)
                    {
                        memberList.Add(member);
                    }
                    WriteNewItem(memberList, "members.json");
                }
                catch
                {
                    Console.WriteLine("enter valid input");
                }
            }
        }
    }
}