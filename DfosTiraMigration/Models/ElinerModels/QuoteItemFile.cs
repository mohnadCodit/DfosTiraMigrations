using DfosTiraMigration.Models.ElinerModels.PriceListsModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class QuoteItemFile
    {
        public int ID { get; set; }

        public int QuoteItemId { get; set; }

        public string FileName { get; set; }

        public string FilePath { get; set; }

        public string FileLocalPath { get; set; }

        public int FileTypeId { get; set; }

        public DateTime Created { get; set; } = DateTime.Now;

        public virtual QuoteItem QuoteItem { get; set; }

        [NotMapped]
        public int MissionID { get; set; }
    }
}