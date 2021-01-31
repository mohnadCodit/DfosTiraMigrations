using DfosTiraMigration.Models.AwsModels.Products;
using System.Collections.Generic;

namespace DfosTiraMigration.Models.AwsModels.PriceLists
{
    public class PriceListParameter
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListParameter()
        {
            SubProductParameters = new HashSet<SubProductParameter>();
        }

        public int ID { get; set; }

        public int PriceListId { get; set; }

        public string Name { get; set; }

        public string Values { get; set; }

        public string DefaultValue { get; set; }

        public string HtmlInputId { get; set; }

        public bool IsRequired { get; set; } = false;

        public virtual PriceList PriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SubProductParameter> SubProductParameters { get; set; }
    }
}