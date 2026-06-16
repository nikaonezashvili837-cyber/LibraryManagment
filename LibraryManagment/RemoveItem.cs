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
            List<LibraryItem> UpdatedList = new List<LibraryItem>();
            List<LibraryItem>? libraryItems = JsonSerializer.Deserialize<List<LibraryItem>>(jsonContent);
            if (libraryItems != null)
            {
                foreach (LibraryItem item in libraryItems)
                {
                    if (item.Title != bookToRemove)
                    {
                        UpdatedList.Add(item);
                    }
                }
            }
            WriteNewItem(UpdatedList);
            return;
        }
    }
}