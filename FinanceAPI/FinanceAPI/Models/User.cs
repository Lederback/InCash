namespace FinanceAPI.Models
{
    public class User
    {
        //public string? Login { get; set; }
        //public string? Password { get; set; }
        //public List<Transaction>? Transaction { get; set; }
        public int Id { get; set; }
        public string? Login { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}
