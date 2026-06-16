using System.Text.Json;
namespace LibraryManagment
{
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
                libraryItems.Remove(libraryItems.First(el => el.Title == bookToRemove));
                WriteNewItem(libraryItems);
            }
            return;
        }
    }
}