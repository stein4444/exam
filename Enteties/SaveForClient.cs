namespace Exam1111
{
    public class SaveForClient
    {
        public int Id { get; set; }
        public int AccountID { get; set; }
        public int BookId { get; set; }
        public virtual Book Book { get; set; }
        public virtual Account Account { get; set; }
    }
}
