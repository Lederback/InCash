namespace FinanceAPI
{
    public class Transaction
    {
        public int Id { get; set; }
        public DateTime Date{ get; set; }
        public decimal Value { get; set; }
        public string? Description { get; set; }
        public enum TypeEnum
        {
            Contas,
            Lazer,
            Alimentação,
        }
        public TypeEnum TypeTransaction { get; set; }
    }
}
