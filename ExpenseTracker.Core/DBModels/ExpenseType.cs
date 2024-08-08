namespace ExpenseTracker.Core.DBModels;

public partial class ExpenseType
{
    public int ExpenseTypeId { get; set; }

    public string ExpenseTypeName { get; set; } = null!;

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}
