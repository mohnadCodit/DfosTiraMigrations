namespace DfosTiraMigration.Models.AwsModels
{
    public class BoardUsers
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int BoardID { get; set; }
        public Boards Board { get; set; }
        public virtual User User { get; set; }
    }
}