namespace MaxByMinByAllTheBy;

internal record Employee(string Name, string Dept, decimal Salary, DateOnly HireDate, int SecurityLevel) : IComparable<Employee>
{
    public int CompareTo(Employee? other)
    {
        if (other == null)
            return 1;

        return Salary > other.Salary ? 1 : Salary < other.Salary ? -1 : 0;
    }
}

internal record Company(string Name, IEnumerable<Employee> Employees);

