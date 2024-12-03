namespace CountByAggregateBy;

internal record Employee(string Name, string Dept, string Title, decimal Salary);

class EmployeeHelper
{
    internal static IEnumerable<Employee> GetEmployees()
    {
        return
        [
            new("Mary", "Accounting", "Accountant", 80_000),
            new("Jean", "Accounting", "Manager", 140_000),
            new("Bill", "Accounting", "Accountant", 90_000),
            new("Dean", "Accounting", "Accountant", 84_000),

            new("Suzy", "IT", "Developer", 160_000),
            new("Mike", "IT", "Manager", 160_000),
            new("Adam", "IT", "Developer", 75_000),

            new("Leah", "Sales", "Manager", 99_000),
            new("Glen", "Sales", "Sales Rep", 65_000),
            new("Katy", "Sales", "Sales Rep", 102_000),
            new("Mark", "Sales", "Sales Rep", 55_000),
            new("Nate", "Sales", "Manager", 110_000),
        ];
    }
}