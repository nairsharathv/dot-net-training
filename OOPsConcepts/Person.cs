// Encapsulation
class Person
{
    // default constructor
    // these are implicit in nature
    public Person(string firstName, string lastName, int age, double salary) 
    {
        FirstName = firstName;
        LastName = lastName;
        Age = age;
        _salary= salary;
    }

    // Properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }

    // Fields 
    private double _salary;

    //Methods
    public void SetSalary(double salary)
    {
        _salary = salary;
    }

    public double GetSalary()
    {
        return _salary;
    }

    public string GetFullName()
    {
        return FirstName + " " +  LastName;
    }

    // an example of method overloading
    public string GetFullName(string middleName) 
    {
        return FirstName + " " + middleName + " " + LastName;   
    }
}


/*
 * 
 - Difference between fields and properties:
    1. Attributes which are private are called as fields and which are public are called Properties.
    2. Classes which only has getter and not setter or if the state of the class cannot be changed it is called as immutable class.

 */