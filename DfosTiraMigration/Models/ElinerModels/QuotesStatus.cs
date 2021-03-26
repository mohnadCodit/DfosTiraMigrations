using System.ComponentModel.DataAnnotations;

namespace DfosTiraMigration.Models.ElinerModels
{
    public class QuotesStatus
    {
        public int ID { get; set; }

        [Required]
        public string Name { get; set; }
    }
}