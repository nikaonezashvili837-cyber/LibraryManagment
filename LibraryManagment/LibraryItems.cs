namespace LibraryManagment
{
    partial class Program
    {
        public class LibraryItem
        {
            public string? Title {get;set;}
            public int PublicationYear {get;set;}
            public string? Author{get;set;}
            public LibraryItem(string? title,int publicationyear,string? author)
            {
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