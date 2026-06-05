namespace LibraryManagment
{
    partial class Program
    {
        class User
        {
            public string? Name {get;set;}
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
            public void AddNewItem()
            {
               

            }
        }
    }
}