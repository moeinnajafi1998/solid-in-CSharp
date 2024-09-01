public interface IWorker
{
    void Work();
    void Eat();
}

public class HumanWorker : IWorker
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

public class RobotWorker : IWorker
{
    public void Work()
    {
        // Robot worker implementation for work
        Console.WriteLine("Robot worker is working.");
    }

    public void Eat()
    {
        // RobotWorker does not eat, but is forced to implement the Eat method
        throw new NotImplementedException();
    }
}

// Explanation:
// The IWorker interface has two methods: Work and Eat.
// The HumanWorker class can implement both methods, but the RobotWorker class can only implement Work. Since robots don't eat, RobotWorker has to either throw an exception or provide a meaningless implementation for Eat.
// This design violates the Interface Segregation Principle because RobotWorker is forced to implement an interface method (Eat) that it doesn't need.