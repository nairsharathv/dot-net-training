// for (Counter controlled)

for (int i = 0; i < 10; i++)
{
    Console.WriteLine($"Inside Loop {i}");
}
Console.WriteLine();
Console.WriteLine("For loop exited");



// while (Condition controlled)

int n = 0;
while (n < 5)
{
    Console.Write("Enter the value for n: ");
    n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside while loop {n}");
}
Console.WriteLine();
Console.WriteLine("While loop exited");


// do while (Condition controlled, post check)

int j = 10;
do
{
    Console.Write("Enter the value for j: ");
    j = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Inside do while loop {j}");
} while (j < 5);
Console.WriteLine();
Console.WriteLine("Do while loop exited");
