namespace ExpenseTracker.Models;
public class User
{
    public int Id { get; set; }
    public required string Name { get; set; }
    public required string Email { get; set; }
    public required string PasswordHash { get; set; }
    public ICollection<Budget> Budgets { get; set; } = new List<Budget>();
}
