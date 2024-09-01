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

    public void SaveToDatabase()
    {
        // Code to save employee details to a database
    }

    public string GenerateReport()
    {
        // Code to generate an employee report
        return $"Employee Report for {Name}";
    }
}


// Explanation:
// The Employee class has multiple responsibilities:
// Calculating the annual salary (CalculateAnnualSalary)
// Saving employee data to a database (SaveToDatabase)
// Generating an employee report (GenerateReport)
// This violates SRP because any change in the salary calculation, database saving logic, or report generation would require changes to the Employee class.