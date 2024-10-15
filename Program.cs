using BankSystem;
using System;

 Bank j = new Bank();
 bool t = true;static void SetConsoleColor(ConsoleColor color)
{
    Console.ForegroundColor = color;
}
SetConsoleColor(ConsoleColor.Yellow);

Console.WriteLine("\n                               * * * Welcome to the Bank Account System * * * \n\n");

while (t)
{
    bool tt = true;
    Console.WriteLine("   Enter Account Details :: \n");
    Console.Write(" Account ID: ");
    Console.ForegroundColor = ConsoleColor.White;

    try
    {
        int ad = Convert.ToInt32(Console.ReadLine());
        SetConsoleColor(ConsoleColor.Yellow);
        Console.Write(" Account Holder: ");
        Console.ForegroundColor = ConsoleColor.White;
        string ah = Convert.ToString(Console.ReadLine());
        SetConsoleColor(ConsoleColor.Yellow);
        Customer ca = new Customer(ad, ah);
        Console.Write(" Account Type (Saving / Checking): ");
        Console.ForegroundColor = ConsoleColor.White;
        string at = Convert.ToString(Console.ReadLine());
        SetConsoleColor(ConsoleColor.Yellow);
        Console.Write(" Account Number: ");
        Console.ForegroundColor = ConsoleColor.White;
        int an = (int)Convert.ToInt64(Console.ReadLine());
        SetConsoleColor(ConsoleColor.Yellow);
        Console.Write(" Balance: ");
        Console.ForegroundColor = ConsoleColor.White;
        int b;
        while (!int.TryParse(Console.ReadLine(), out b) || b < 0)
        {
            Console.Write("Please enter a valid non-negative balance: ");
        }
        SetConsoleColor(ConsoleColor.Yellow);
        Account ac = new Account(an, at, b);
        ca.AddAccount(ac);

        j.AddCustomer(ca);

        while (tt)
        {
            Console.WriteLine("\n   Please choose an option :: \n");
            Console.WriteLine(" 1. Deposit money\n 2. Withdrew money\n 3. Show account details\n 4. Exit");
            Console.Write("  Please enter your choice: ");
            Console.ForegroundColor = ConsoleColor.White;
            int r = Convert.ToInt32(Console.ReadLine());
            SetConsoleColor(ConsoleColor.Yellow);
            switch (r)
            {
                case 1:
                    Console.Write(" Enter the amount to deposit:");
                    Console.ForegroundColor = ConsoleColor.White;
                    int y = Convert.ToInt32(Console.ReadLine());
                    SetConsoleColor(ConsoleColor.Yellow);
                    ac.Deposit(y);
                    break;
                case 2:
                    Console.Write(" Enter the amount to withdrew:");
                    Console.ForegroundColor = ConsoleColor.White;
                    int k = Convert.ToInt32(Console.ReadLine());
                    SetConsoleColor(ConsoleColor.Yellow);
                    ac.Withdrew(k);
                    break;
                case 3:
                    j.DisplayAllCustomers(ca);
                    break;
                case 4:
                    tt = false;
                    break;
            }

            if (r == 4) break;
            Console.Write("         ------------------------\n  Would you like to perform another action ? (yes / no): ");
            Console.ForegroundColor = ConsoleColor.White;
            string p = Convert.ToString(Console.ReadLine());
            SetConsoleColor(ConsoleColor.Yellow);
            tt = p.ToLower() == "yes";
        }

        Console.Write("         ------------------------\n  Would you like to perform another Account ? (yes / no): ");
        Console.ForegroundColor = ConsoleColor.White;
        string s = Convert.ToString(Console.ReadLine());
        SetConsoleColor(ConsoleColor.Yellow);
        if (s.ToLower() == "no")
        {
            Console.Write("         ------------------------\n  Would you like to view all accounts you entered? (yes / no): ");
            Console.ForegroundColor = ConsoleColor.White;
            string viewAccounts = Console.ReadLine();
            SetConsoleColor(ConsoleColor.Yellow);
            if (viewAccounts.ToLower() == "yes")
            {
                Console.WriteLine("\n");
                j.DisplayAllAccounts();
            }

            break;
        }
    }
     catch (FormatException)
    {
        Console.WriteLine("Invalid input. Please enter a valid number.");
    }
}
