// The Liskov Substitution Principle (LSP) is one of the SOLID principles in object-oriented design. 
// It states that objects of a superclass should be replaceable with objects of a subclass without affecting the correctness of the program. 
// In other words, a subclass should behave in such a way that it can be substituted for its superclass without causing errors or unexpected behavior.
public abstract class Shape
{
    public abstract int GetArea();
}

public class Rectangle : Shape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public override int GetArea()
    {
        return Width * Height;
    }
}

public class Square : Shape
{
    public int Side { get; set; }

    public override int GetArea()
    {
        return Side * Side;
    }
}

// Client code
public void PrintArea(Shape shape)
{
    Console.WriteLine($"Area: {shape.GetArea()}");
}

// Explanation:
// Here, the Shape abstract class defines a common interface for getting the area, and both Rectangle and Square implement this interface.
// The Rectangle and Square classes each provide their own correct implementation of the GetArea method without interfering with each other's logic.
// The PrintArea method can now accept either a Rectangle or a Square, and the behavior will be correct and predictable, adhering to the Liskov Substitution Principle.