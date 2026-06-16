namespace LibraryManagment
{
    partial class Program
    {
        public static bool CheckDublicates(List<LibraryItem> libraryItems, LibraryItem libraryItem)
        {
            foreach (LibraryItem item in libraryItems)
            {
                if (item.Author == libraryItem.Author && item.Title == libraryItem.Title && item.PublicationYear == libraryItem.PublicationYear)
                {
                    return true;
                }
            }
            return false;
        }
    }
}