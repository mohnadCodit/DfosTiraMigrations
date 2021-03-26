namespace DfosTiraMigration.Models.ElinerModels
{
    using DfosTiraMigration.Models.ElinerModels.PriceLists;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class PriceListsMachine
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public PriceListsMachine()
        {
            MachineSheetsCosts = new HashSet<MachineSheetsCost>();
            PriceListsPaperDetailsMachines = new HashSet<PriceListsPaperDetailsMachine>();
        }

        public int ID { get; set; }

        public int PriceListId { get; set; }

        public int MachineId { get; set; }

        public double? Productivity { get; set; }

        public double? MachineCost { get; set; }

        public double? LifeSpanYears { get; set; }

        public double? MonthlyCost { get; set; }

        public double? MachineHourCost { get; set; }

        public double? AgentHourCost { get; set; }

        public virtual Machine Machine { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MachineSheetsCost> MachineSheetsCosts { get; set; }

        public virtual PriceList PriceList { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PriceListsPaperDetailsMachine> PriceListsPaperDetailsMachines { get; set; }
    }
}
