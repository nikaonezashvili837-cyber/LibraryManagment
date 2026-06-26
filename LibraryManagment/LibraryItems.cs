namespace LibraryManagment
{
    partial class Program
    {
        struct BorrowedItem
        {
            public string? Id {get;set;}
            public string? Title {get;set;}
            public BorrowedItem(string id, string? title)
            {
                Id = id;
                title = Title;
            }
        }
        public class LibraryItem
        {
            public string? Id {get;set;}
            public string? Title {get;set;}
            public int PublicationYear {get;set;}
            public string? Author{get;set;}
            public LibraryItem()
            {
                
            }
            public LibraryItem(string? title,int publicationyear,string? author)
            {
                Id = Guid.NewGuid().ToString();
                Title = title;
                PublicationYear = publicationyear;
                Author = author; 
            }
            public LibraryItem(string title)
            {
                Title = title;
            }
        }
    }
}