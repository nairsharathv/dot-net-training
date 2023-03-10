/*
Day 2 Assignment

We are writing a program for an ATM machine.

Ask the user to enter the 5 digit card number
Ask the user to enter the 4 digit pin
If the user provides the credentials correctly prompt him with the following options
Check balance
Withdraw the amount
Deposit the amount
Quit the program

*/


int accountBalance = 789098;


bool CheckCredentials()
{
    int storedCardNumber = 12345;
    int storedPinNumber = 1234;
    Console.WriteLine("Please enter your 5 digit card number: ");
    int inputCardNumber = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Please enter your 4 digit pin of your card number: ");
    int inputPinNumber = Convert.ToInt32(Console.ReadLine());
    if (storedCardNumber == inputCardNumber && storedPinNumber == inputPinNumber)
    {
        return true;
    }
    else
    {
        Console.WriteLine("Incorrect credentials");
        return false;
    }
}

bool isLoggedIn = CheckCredentials();

int LoadMenu()
{
    if (isLoggedIn)
    {
        Console.WriteLine("Welcome to you account");
        Console.WriteLine("Press 1: Check balance");
        Console.WriteLine("Press 2: Withdrawal");
        Console.WriteLine("Press 3: Deposit");
        Console.WriteLine("Press 4: Quit");
    }
    int selectedOption = Convert.ToInt32(Console.ReadLine());
    return selectedOption;
}



void CheckBalance()
{
    Console.WriteLine($"Your account balance is Rs.{accountBalance} .");
}

void CashWithdrawal()
{
    Console.WriteLine("Please enter the amount you want to withdraw in Rs .");
    int withdrawalAmount = Convert.ToInt32(Console.ReadLine());
    if (accountBalance > withdrawalAmount)
    {
        accountBalance -= withdrawalAmount;
        Console.WriteLine($"Successfully withdrawn Rs.{withdrawalAmount} .");
        Console.WriteLine($"Your account balance is Rs.{accountBalance} .");
    }
    else
    {
        Console.WriteLine("You have insufficient funds in your account to make this withdrawal");
        Console.WriteLine($"Your account balance is Rs.{accountBalance} .");
    }   
}

void CashDeposit()
{
    Console.WriteLine("Please enter the amount you want to deposit. ");
    int depositAmount = Convert.ToInt32(Console.ReadLine());
    accountBalance += depositAmount;
    Console.WriteLine($"Successfully deposited Rs.{depositAmount} .");
    Console.WriteLine($"Your account balance is Rs.{accountBalance} .");
}

void Quit()
{
    Console.WriteLine("Thank you for banking with us");
}


void ATMMachine(int selectedOption)
{

    switch (selectedOption)
    {
        case 1:
            CheckBalance();
            break;
        case 2:
            CashWithdrawal();
            break;
        case 3:
            CashDeposit();
            break;
        case 4:
            Quit();
            break;
        default: Console.WriteLine("Invalid Input provided");
            break;
    }
}

int selectedOption = LoadMenu();
ATMMachine(selectedOption);