using BankSystem;

public class Customer
{
    public int CustomerID;
    public string Name;
    public List<Account> Accounts;

    public Customer(int id, string name)
    {
        CustomerID = id;
        Name = name;
        Accounts = new List<Account>(); 
    }

    public void AddAccount(Account account)
    {
        Accounts.Add(account); 
    }
}
