namespace CountByAggregateBy;

internal class LinqAggregateByExamples
{
    internal static IEnumerable<KeyValuePair<string, decimal>> GetTotalSalariesByDept_TraditionalGroupBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        var t1 = employees.MaxBy(x => x.Salary > 130_000);

        var t2 = employees.Max(x => x.Salary < 130_000);

        var t3 = employees.DistinctBy(x => x.Salary);

        // Query total salaries of ALL employees BY DEPT - GroupBy / Aggregate
        var totalSalariesByDept = employees
            .GroupBy(e => e.Dept)
            .Select(deptGroup => new KeyValuePair<string, decimal>(deptGroup.Key,
                deptGroup.Aggregate(0m, (deptSal, nextEmp) => deptSal + nextEmp.Salary)));

        return totalSalariesByDept;
    }

    internal static IEnumerable<KeyValuePair<string, decimal>> GetTotalSalariesByDept_NewAggregateBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query total salaries of ALL employees BY DEPT - AggregateBy
        return employees.AggregateBy(e => e.Dept, 0m, (deptSal, nextEmp) => deptSal + nextEmp.Salary);
    }

    internal static IEnumerable<KeyValuePair<string, (int, decimal)>> GetTotalEmployeesAndSalariesOver100kByTitle_TraditionalGroupBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query count and total salaries of ALL employees BY TITLE who earn MORE THAN 100k - GroupBy / Aggregate
        var employeesOver100k = employees
            .GroupBy(e => e.Title)
            .Select(group => new KeyValuePair<string, (int Count, decimal Salary)>(group.Key,
                group.Aggregate((Count: 0, Salary: 0m), (t, nextEmp) =>
                    nextEmp.Salary > 100_000 ? (t.Count + 1, t.Salary + nextEmp.Salary) : t)));

        return employeesOver100k;
    }

    internal static IEnumerable<KeyValuePair<string, (int, decimal)>> GetTotalEmployeesAndSalariesOver100kByTitle_NewAggregateBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query count and total salaries of ALL employees BY TITLE who earn MORE THAN 100k - AggregateBy
        var employeesOver100k = employees
            .AggregateBy(e => e.Title, (Count: 0, Salary: 0m), (t, nextEmp) =>
                nextEmp.Salary > 100_000 ? (t.Count + 1, t.Salary + nextEmp.Salary) : t);
   
        return employeesOver100k;
    }
}
