
using System.Text.Json;

namespace LibraryManagment
{
    partial class Program
    {
        public static void WriteNewItem<T>(List<T>? Items,string filePath)
        {
            var json = JsonSerializer.Serialize(Items, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            File.WriteAllText(filePath, json);
        }
    }
}