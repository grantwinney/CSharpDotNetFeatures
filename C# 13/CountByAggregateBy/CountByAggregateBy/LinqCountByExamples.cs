namespace CountByAggregateBy;

internal class LinqCountByExamples
{
    internal static int GetNumberOfManagers()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query count of ONE type of employee - no GroupBy needed
        return employees.Count(e => e.Title == "Manager");
    }

    internal static IEnumerable<KeyValuePair<string, int>> GetNumberOfEmployeesByDepartment_TraditionalGroupBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query counts of ALL employees BY DEPT - GroupBy
        return employees
            .GroupBy(emp => emp.Dept)
            .Select(grp => new KeyValuePair<string, int>(grp.Key, grp.Count()));
    }

    internal static IEnumerable<KeyValuePair<string, int>> GetNumberOfEmployeesByDepartment_NewCountBy()
    {
        var employees = EmployeeHelper.GetEmployees();

        // Query counts of ALL employees BY DEPT - CountBy
        return employees.CountBy(e => e.Dept);
    }
}
