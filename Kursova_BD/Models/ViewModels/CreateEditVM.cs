using Kursova_BD.Models.Tables;

namespace Kursova_BD.Models.ViewModels
{
    public class CreateEditVM
    {
        public Item Item { get; set; }
        public List<Category> Categories { get; set; }
    }
}
