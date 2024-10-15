using BankSystem;

public class Bank
{
    public List<Customer> Customers = new List<Customer>();
    public int counter = 1;
    public void AddCustomer(Customer customer)
    {
        Customers.Add(customer);
    }

    public void DisplayAllAccounts()
    {
        foreach (Customer customer in Customers)
        {
            Console.WriteLine($" * Customer Account Number {counter}");
            Console.WriteLine($"  - Customer: {customer.Name}\n  - ID: {customer.CustomerID}");
            foreach (Account account in customer.Accounts)
            {
                Console.WriteLine($"  - Account Number: {account.AccountNumber} \n  - Account Type: {account.AccountType} \n  - Balance: {account.Balance:C} \n  - Interest: {account.CalculateInterest():C}");
            }
            Console.WriteLine("         ------------------------");
            counter++;
        }
    }
    public void DisplayAllCustomers(Customer ca)
    {
        Console.WriteLine($"  - Customer: {ca.Name} \n  - ID: {ca.CustomerID}");
        foreach (Account account in ca.Accounts)
        {
            Console.WriteLine($"  - Account Number: {account.AccountNumber} \n  - Account Type: {account.AccountType} \n  - Balance: {account.Balance:C}\n  - Interest: {account.CalculateInterest():C}");
        }
    }



}
