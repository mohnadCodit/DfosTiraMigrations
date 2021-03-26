using DfosTiraMigration.Models.ElinerModels.PriceListsModels;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class OrderFile
    {
        public int ID { get; set; }

        public int OrderId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public virtual Order Order { get; set; }
    }
}