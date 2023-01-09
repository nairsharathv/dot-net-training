
// TASK 1: Ask the user to enter two numbers and print their sum and product on screen

Console.WriteLine("Please input two integers");
Console.WriteLine("Please provide first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Please provide second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Sum of the inputs provided is: {num1 + num2}");
Console.WriteLine($"Product of inputs provided is: {num1 * num2}");


// TASK 2: Declare 3 variables a, b and c. Get the input from the user for these variables. Implement the equation (((a + b) / c) *a)

Console.WriteLine();
double a = 0.0;
double b = 0.0;
double c = 0.0;

Console.Write("Input value for a: ");
a = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value for b: ");
b = Convert.ToDouble(Console.ReadLine());

Console.Write("Input value for c: ");
c = Convert.ToDouble(Console.ReadLine());

Console.WriteLine($"{a} {b} {c}");


/* 
TASK 3: Create a game called "Fortune"
The player will be given 5 turns to guess a number x (0 - 100)
After each attempt your program will do the following.
If player's entered number is less than  x print "Guessed number is less than x" and show remaining turns
If player's entered number is greater than  x print "Guessed number is greater than x" and show remaining turns
If no more turns are available print "You lost" and exit
If guessed correctly print "You win" and exit 
*/


Console.WriteLine("Welcome to Fortune");
Console.WriteLine("Rule 1: You have 5 attempts to guess the lucky number ");
Console.WriteLine("Rule 2: Numbers can only be whole numbers between 0 and 100 ");
Console.WriteLine();
int attemptsRemaining = 5;
Random rand = new Random();
int luckyNumber = rand.Next(0, 101);
while (attemptsRemaining != 0) {
    Console.Write("Enter your guess: ");
    attemptsRemaining--;
    int guess = Convert.ToInt32(Console.ReadLine());
    if (guess > luckyNumber)
    {
        Console.WriteLine("Guessed number is greater than x");
    }
    else if (guess < luckyNumber)
    {
        Console.WriteLine("Guessed number is less than x");
    }
    else if (guess == luckyNumber)
    {
        Console.WriteLine("You win !!!");
        break;
    }
    Console.WriteLine($"Attempts {attemptsRemaining} remaining");
}
if (attemptsRemaining == 0)
{
    Console.WriteLine("You lost, Better luck next time !!");
}
