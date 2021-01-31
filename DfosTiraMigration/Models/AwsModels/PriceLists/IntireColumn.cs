using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.AwsModels.PriceListsModels
{
    public class IntireColumn
    {
        public int ID { get; set; }

        [Required]
        public string Quantity { get; set; }

        public string Side { get; set; }

        public string Color { get; set; }

        public string Type { get; set; }

        public string ChromeWeight { get; set; }

        public string WoodWeight { get; set; }

        public string StickerWeight { get; set; }

        public string SpecialWeight { get; set; }

        public string PaperPrice { get; set; }

        public string Lamination { get; set; }

        public int BooksPriceListID { get; set; }

        public virtual BooksItemValue BooksPriceList { get; set; }
    }
}