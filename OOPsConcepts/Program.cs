/*
string firstName = string.Empty;
string middleName = string.Empty;
string lastName = string.Empty;
int age = 0;
double salary = 0;

Console.Write("Please enter your first name: ");
firstName = Console.ReadLine();

Console.Write("Please enter your middle name: ");
middleName = Console.ReadLine();

Console.Write("Please enter your last name: ");
lastName = Console.ReadLine();

Console.Write("Please enter your age: ");
age = Convert.ToInt32(Console.ReadLine());

Console.Write("Please enter your salary: ");
salary = Convert.ToInt32(Console.ReadLine());



// using default constructor
Person person = new Person(firstName, lastName, age, salary);

/*
 * without using default constructor
Person person = new Person();
person.FirstName = firstName;
person.LastName = lastName;
person.Age = age;
person.SetSalary(salary);


Console.WriteLine($"The name entered is {person.FirstName + " " + person.LastName}.");
Console.WriteLine($"The age entered is {person.Age}");
Console.WriteLine($"The salary is {person.GetSalary()}");


// both are correct way to instantiate
// in most cases we use the second way to instantiate

Shape s = new Triangle();
Triangle triangle = new Triangle() { Height = 10, Width = 5};

*/

Rectangle rec = new Rectangle();
rec.Height = 10;
rec.Width = 4;
rec.CalculateArea();

Triangle triangle = new Triangle();
triangle.Height = 10;
triangle.Width = 4;
triangle.Hypotenuse = 9;

Console.WriteLine(triangle.Hypotenuse);
triangle.CalculateArea();