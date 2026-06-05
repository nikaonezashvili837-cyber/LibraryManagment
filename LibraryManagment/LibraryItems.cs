namespace LibraryManagment
{
    partial class Program
    {
        class LibraryItem
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
        }
    }
}