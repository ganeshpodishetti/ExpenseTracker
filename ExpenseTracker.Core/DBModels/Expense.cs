﻿namespace ExpenseTracker.Core.DBModels;

public partial class Expense
{
    public int ExpenseId { get; set; }

    public int? UserId { get; set; }

    public decimal ExpenseAmount { get; set; }

    public int? ExpenseCategoryId { get; set; }

    public int? ExpenseTypeId { get; set; }

    public int? CreditCardId { get; set; }

    public string ExpenseDescription { get; set; } = null!;

    public DateTime ExpenseDate { get; set; }

    public virtual CreditCard? CreditCard { get; set; }

    public virtual ExpenseCategory? ExpenseCategory { get; set; }

    public virtual ExpenseType? ExpenseType { get; set; }

    public virtual UserProfile? User { get; set; }
}
