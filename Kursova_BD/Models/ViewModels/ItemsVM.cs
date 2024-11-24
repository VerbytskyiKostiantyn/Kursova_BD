using Kursova_BD.Models.Tables;

namespace Kursova_BD.Models.ViewModels
{
    public class ItemsVM
    {
        public List<Item> items {  get; set; }
        public string CategoryName { get; set; }
    }
}
