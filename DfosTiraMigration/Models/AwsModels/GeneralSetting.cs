namespace DfosTiraMigration.Models.AwsModels
{
    using System.ComponentModel.DataAnnotations;

    public partial class GeneralSetting
    {
        public int ID { get; set; }

        [Required]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}
