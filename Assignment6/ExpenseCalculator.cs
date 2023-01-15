namespace Assignment6;

public class ExpenseCalculator
{

    private List<AccountStatement> _accountStatement = new List<AccountStatement>();
    public ExpenseCalculator()
    {
        var statementFile = File.ReadAllLines("C:\\Users\\shara\\source\\repos\\ConsoleProgramming\\Assignment6\\test.csv");
        List<string> entries = new List<string>(statementFile);

        foreach (string entry in entries)
        {
            string[] data = entry.Split(",");
            _accountStatement.Add(new AccountStatement(DateTime.Parse(data[0]), double.Parse(data[1]), data[2]));
        }

    }

    public void TotalBalance()
    {
        double totalBalance = 0.0;
        foreach (AccountStatement statement in _accountStatement)
        {
            totalBalance += statement.expense;
        }
        Console.Write("Your account balance : Rs.");
        Console.WriteLine(totalBalance);
    }

    public void MonthlyBalance()
    {
        double totalNetBalance = 0.0;
        int months = 12;

        Console.WriteLine();
        Console.WriteLine("Monthly account balance sheet: ");
        for (int i = 0; i < months; i++)
        {
            foreach (AccountStatement data in _accountStatement)
            {
                if (data.date.Month == i)
                {
                    totalNetBalance += data.expense;
                }
            }
            if (totalNetBalance != 0.0)
            {
                string monthName = MonthName.GetFullName(i);
                Console.WriteLine($"Net balance for the month of {monthName} is Rs.{totalNetBalance}");
            }
            totalNetBalance = 0.0;
        }
    }





}
