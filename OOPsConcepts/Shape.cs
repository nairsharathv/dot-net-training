// Abstract class cannot be used to create an object directly.
// To achieve this you will have to create an object using a derived class of abstract class.

abstract class Shape: IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public virtual double CalculateArea()
    {
        Console.WriteLine(Height * Width);
        return Height * Width;
    }
}