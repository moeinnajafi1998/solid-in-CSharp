// The Interface Segregation Principle (ISP) is another SOLID principle in object-oriented design. 
// It states that a class should not be forced to implement interfaces it does not use. 
// Instead of one large interface, multiple smaller, more specific interfaces should be created. 
// This ensures that implementing classes only need to be concerned with the methods that are relevant to them
public interface IWorkable
{
    void Work();
}

public interface IFeedable
{
    void Eat();
}

public class HumanWorker : IWorkable, IFeedable
{
    public void Work()
    {
        // Human worker implementation for work
        Console.WriteLine("Human worker is working.");
    }

    public void Eat()
    {
        // Human worker implementation for eating
        Console.WriteLine("Human worker is eating.");
    }
}

public class RobotWorker : IWorkable
{
    public void Work()
    {
        // Robot worker implementation for work
        Console.WriteLine("Robot worker is working.");
    }
}

// Explanation:
// Here, the IWorker interface is split into two smaller, more specific interfaces: IWorkable and IFeedable.
// The HumanWorker class implements both IWorkable and IFeedable because it can work and eat.
// The RobotWorker class only implements IWorkable since it only needs to work and doesn’t need to worry about the Eat method.