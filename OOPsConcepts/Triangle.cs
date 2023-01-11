class Triangle : Shape
{
    public int Hypotenuse { get; set; }

    // Method
    public override double CalculateArea()
    {
        return 0.5 * Height * Width;
    }
}