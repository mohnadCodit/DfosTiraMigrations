using System;

namespace DfosTiraMigration.Models.GoMakeModels.DataTable
{
    public class SubProductGridSource
    {
        public Guid ID { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public string MainProductName { get; set; }

        public string Description { get; set; }

        public string ProductGroups { get; set; }

        public string ProductType { get; set; }

        public string BelongTo { get; set; }

        public string KanbanPath { get; set; }

        public bool IsActive { get; set; }

        public bool Shortcut { get; set; }

    }
}