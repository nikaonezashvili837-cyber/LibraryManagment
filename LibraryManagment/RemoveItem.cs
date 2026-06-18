using System.Text.Json;
namespace LibraryManagment
{
    //please fix the bug in particular after user tries to add item to json post deletion deleted item returns
    partial class Program
    {
        public static void RemoveItem(string? bookToRemove)
        {
            string jsonContent = File.ReadAllText("LibraryItems.json");
            if (jsonContent == "")
            {
                Console.WriteLine("Library is empty");
                return;
            }
            List<LibraryItem>? libraryItems = JsonSerializer.Deserialize<List<LibraryItem>>(jsonContent);
            if (libraryItems != null)
            {
                try
                {
                    libraryItems.Remove(libraryItems.First(el => el.Title == bookToRemove));
                    WriteNewItem(libraryItems);
                }
                catch
                {
                    Console.WriteLine("no such book in the library");
                }
            }
            return;
        }
    }
}