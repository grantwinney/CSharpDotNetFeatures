namespace NullConditionalAssignment;

public class Company
{
    public string Name { get; set; }
    public IList<Department> Departments { get; set; }
}

public class Department
{
    public string Name { get; set; }
    public IList<Employee> Employees { get; set; } = new List<Employee>();
}

public class Employee
{
    public string Name { get; set; }

    public bool Active { get; set; } = false;
}
