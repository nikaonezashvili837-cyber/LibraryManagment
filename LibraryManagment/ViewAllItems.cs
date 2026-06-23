namespace LibraryManagment
{
    partial class Program
    {
        public static void ViewAllItems()
        {
            List<LibraryItem>? AllItems = ExtractListItems<LibraryItem>("LibraryItems.json");
            int count = 0;
            if (AllItems != null)
            {
                foreach (LibraryItem item in AllItems)
                {
                    count++;
                    Console.WriteLine(item.Title);
                }
                Console.WriteLine("Items in total:" + count);
            }
        }
    }
}