public class Rectangle
{
    public virtual int Width { get; set; }
    public virtual int Height { get; set; }

    public int GetArea()
    {
        return Width * Height;
    }
}

public class Square : Rectangle
{
    public override int Width
    {
        set
        {
            base.Width = value;
            base.Height = value; // Force Height to be the same as Width
        }
    }

    public override int Height
    {
        set
        {
            base.Height = value;
            base.Width = value; // Force Width to be the same as Height
        }
    }
}

// Client code
public void PrintArea(Rectangle rectangle)
{
    rectangle.Width = 4;
    rectangle.Height = 5;
    Console.WriteLine($"Area: {rectangle.GetArea()}");
}

// Explanation:
// The Square class inherits from Rectangle but overrides the Width and Height properties to ensure that both dimensions are always equal.
// When you pass a Square object to the PrintArea method, the behavior is incorrect because setting the width or height of a square should also set the other dimension, which violates the expectation for a rectangle.
// In this case, substituting a Square for a Rectangle breaks the client code’s logic and violates the Liskov Substitution Principle.