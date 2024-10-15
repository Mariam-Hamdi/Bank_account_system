using BankSystem;

public interface ICustomer
{
    List<Account> Accounts { get; init; }
    int CustomerID { get; init; }
    string Name { get; init; }

    void AddAccount(Account account);
    void Deconstruct(out int CustomerID, out string Name, out List<Account> Accounts);
    bool Equals(Customer? other);
    bool Equals(object? obj);
    int GetHashCode();
    string ToString();
}