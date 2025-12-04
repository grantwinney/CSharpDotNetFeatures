
namespace NullConditionalAssignment;

internal class Program
{
    static void Main(string[] args)
    {
        GetTraditional();
        GetWithNullConditional();

        SetTraditional();
        SetWithNullConditional();
        SetWithNullConditionalPreserveName();

        var company = new Company
        {
            Departments =
            [
                new Department
                {
                    Name = "Sales",
                    Employees = [ new() { Name = "Greg Smith"} ]
                }
            ]
        };
        ActivateEmployee(company, "Sales", "Greg Smith");
    }

    static void GetTraditional(Company? company = null)
    {
        if (company == null)
            company = new Company();

        // Getting employee name traditionally
        if (company != null &&
            company.Departments != null && company.Departments.Count > 0 &&
            company.Departments[0].Employees != null &&
            company.Departments[0].Employees.Count > 0 &&
            company.Departments[0].Employees[0].Name != null)
        {
            var employeeName = company.Departments[0].Employees[0].Name;
            Console.WriteLine($"Employee Name: {employeeName}");
        }
        else
        {
            Console.WriteLine("Employee Name: N/A");
        }
    }

    static void GetWithNullConditional(Company? company = null)
    {
        company ??= new Company();

        // Getting employee name using null-conditional operators
        var employeeName = company?.Departments?[0]?.Employees?[0]?.Name ?? "N/A";
        Console.WriteLine($"Employee Name: {employeeName}");
    }

    static void SetTraditional(Company? company = null)
    {
        if (company == null)
            company = new Company();

        // Setting employee name traditionally
        if (company != null &&
            company.Departments != null && company.Departments.Count > 0 &&
            company.Departments[0].Employees != null &&
            company.Departments[0].Employees.Count > 0 &&
            company.Departments[0].Employees[0].Name != null)
        {
            company.Departments[0].Employees[0].Name = "John Doe";
        }
    }

    static void SetWithNullConditional(Company? company = null)
    {
        company ??= new Company();

        // Setting employee name using null-conditional operators
        company?.Departments?[0]?.Employees?[0]?.Name = "John Doe";
    }

    static void SetWithNullConditionalPreserveName(Company? company = null)
    {
        company ??= new Company();

        // Setting employee name using null-conditional and null-coalescing operators
        company?.Departments?[0]?.Employees?[0]?.Name ??= "John Doe";
    }

    static void ActivateEmployee(Company company, string dept, string name)
    {
        // Activate employee, using null-conditional assignment operator
        company
            ?.Departments.SingleOrDefault(d => d.Name == "Sales")
            ?.Employees.SingleOrDefault(e => e.Name == "Greg Smith")
            ?.Active = true;
    }
}
