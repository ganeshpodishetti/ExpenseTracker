namespace ExpenseTracker.Core.DBModels;

public partial class ExpenseCategory
{
    public int ExpenseCategoryId { get; set; }

    public string ExpenseCategoryName { get; set; } = null!;

    public virtual ICollection<Expense> Expenses { get; set; } = new List<Expense>();
}
