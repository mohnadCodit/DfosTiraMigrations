using DfosTiraMigration.Models.GoMakeModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.GoMakeModels
{
    public class QuoteItemFile
    {
        public Guid ID { get; set; }

        public Guid QuoteItemId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileLocalPath { get; set; }

        public int FileTypeId { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public virtual QuoteItem QuoteItem { get; set; }

        [NotMapped]
        public Guid MissionID { get; set; }
    }
}