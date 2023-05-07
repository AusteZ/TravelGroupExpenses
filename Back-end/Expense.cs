namespace TravelGroupExpenses.Back_end
{
    public class Expense
    {
        public Guid GroupId { get; set; }
        public Guid Id { get; private set; }
        public string Title { get; set; }
        public decimal Amount { get; set; }
        public string? Place { get; set; } = null;
        public DateTime? Date { get; set; } = null;
        public string? PhotoPath { get; set; } = null;
        public Split SplitMethod { get; set; } = Split.Ways;
        public List<SplitTags> Splits { get; set; } = new List<SplitTags>();
        public Expense(string title, decimal amount)
        {
            Id = Guid.NewGuid();
            GroupId = Guid.Empty;
            Title = title;
            Amount = amount;
        }

        public class SplitTags
        {
            public decimal Amount { get; set; }
            public Guid? Id { get; set; }
        }

    }
    public enum Split
    {
        Ways,
        Percentages,
        Amounts
    }

}
