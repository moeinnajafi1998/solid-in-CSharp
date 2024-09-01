// In this example, the high-level DataProcessor class directly depends on the low-level MySQLDatabase class. 
// This tight coupling makes it difficult to switch to a different database or mock the database for testing purposes.
using System;

public class MySQLDatabase
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

public class DataProcessor
{
    private MySQLDatabase _database;

    public DataProcessor()
    {
        _database = new MySQLDatabase();
    }

    public void ProcessData()
    {
        _database.Connect();
        Console.WriteLine("Processing data...");
        _database.Disconnect();
    }
}

// Usage
public class Program
{
    public static void Main()
    {
        DataProcessor processor = new DataProcessor();
        processor.ProcessData();
    }
}

// Explanation:
// High-Level Module: DataProcessor
// Low-Level Module: MySQLDatabase
// Issue: DataProcessor is tightly coupled to MySQLDatabase. 
// If you need to switch to a different database (e.g., PostgreSQLDatabase), you must modify the DataProcessor class, violating the DIP.