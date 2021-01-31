using DfosTiraMigration.Models.AwsModels.PriceListsModels;

namespace DfosTiraMigration.Models.AwsModels
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