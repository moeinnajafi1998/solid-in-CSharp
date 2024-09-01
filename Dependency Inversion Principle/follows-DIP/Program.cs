// Dependency Inversion Principle (DIP)
// Definition:
// High-level modules should not depend on low-level modules. Both should depend on abstractions (e.g., interfaces or abstract classes).
// Abstractions should not depend on details. Details should depend on abstractions.
// This principle aims to reduce the coupling between high-level and low-level modules, making the system more modular, flexible, and easier to maintain.

// In this improved version, both DataProcessor and the database classes depend on an abstraction (IDatabase). 
// This decouples the high-level DataProcessor from the low-level database implementations, allowing for greater flexibility and easier maintenance.

using System;
// Abstraction
public interface IDatabase
{
    void Connect();
    void Disconnect();
}

// Low-Level Module 1
public class MySQLDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to MySQL Database...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from MySQL Database...");
    }
}

// Low-Level Module 2
public class PostgreSQLDatabase : IDatabase
{
    public void Connect()
    {
        Console.WriteLine("Connecting to PostgreSQL Database...");
    }

    public void Disconnect()
    {
        Console.WriteLine("Disconnecting from PostgreSQL Database...");
    }
}

// High-Level Module
public class DataProcessor
{
    private readonly IDatabase _database;

    // Dependency Injection via Constructor
    public DataProcessor(IDatabase database)
    {
        _database = database;
    }

    public void ProcessData()
    {
        _database.Connect();
        Console.WriteLine("Processing data...");
        _database.Disconnect();
    }
}

// Usage with Dependency Injection
public class Program
{
    public static void Main()
    {
        // You can easily switch the database implementation here
        IDatabase database = new MySQLDatabase();
        // IDatabase database = new PostgreSQLDatabase();

        DataProcessor processor = new DataProcessor(database);
        processor.ProcessData();
    }
}
// Explanation:
// Abstraction: IDatabase interface defines the contract for database operations.
// Low-Level Modules: MySQLDatabase and PostgreSQLDatabase implement the IDatabase interface.
// High-Level Module: DataProcessor depends on the IDatabase abstraction rather than concrete implementations.
// Dependency Injection: The specific database implementation is injected into DataProcessor via its constructor.