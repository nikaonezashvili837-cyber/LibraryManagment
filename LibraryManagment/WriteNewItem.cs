
using System.Text.Json;

namespace LibraryManagment
{
    partial class Program
    {
        public static void WriteNewItem<T>(List<T> libraryItems,string filePath)
        {
            var json = JsonSerializer.Serialize(libraryItems, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            File.WriteAllText("LibraryItems.json", json);
        }
    }
}