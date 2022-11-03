namespace FinanceAPI.Models
{
    public class User
    {
        public int Id { get; set; }
        public string? Login { get; set; }
        public string? Password { get; set; }
        public List<Transaction>? Transaction { get; set; }
    }
}
