// The Single Responsibility Principle (SRP) is one of the SOLID principles of object-oriented design. 
// It states that a class should have only one reason to change, 
// meaning it should have only one job or responsibility
public class Employee
{
    public string Name { get; set; }
    public decimal Salary { get; set; }

    public Employee(string name, decimal salary)
    {
        Name = name;
        Salary = salary;
    }

    public decimal CalculateAnnualSalary()
    {
        return Salary * 12;
    }
}

public class EmployeeRepository
{
    public void SaveToDatabase(Employee employee)
    {
        // Code to save employee details to a database
    }
}

public class EmployeeReport
{
    public string GenerateReport(Employee employee)
    {
        // Code to generate an employee report
        return $"Employee Report for {employee.Name}";
    }
}

// Explanation:
// The responsibilities are now divided across three classes:
// Employee handles employee-related data and salary calculations.
// EmployeeRepository is responsible for saving employee data to a database.
// EmployeeReport takes care of generating the report.