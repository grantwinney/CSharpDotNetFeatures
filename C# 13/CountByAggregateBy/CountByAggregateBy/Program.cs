using CountByAggregateBy;


// CountBy examples
Console.WriteLine("** COUNTBY **\n");
LinqCountByExamples.GetNumberOfManagers();

var empsByDept = LinqCountByExamples.GetNumberOfEmployeesByDepartment_TraditionalGroupBy();
foreach (var dept in empsByDept)
    Console.WriteLine($"Total employees in {dept.Key}: {dept.Value}");

Console.WriteLine();

var empsByDept_new = LinqCountByExamples.GetNumberOfEmployeesByDepartment_NewCountBy();
foreach (var dept in empsByDept_new)
    Console.WriteLine($"Total employees in {dept.Key}: {dept.Value}");


// AggregateBy examples
Console.WriteLine("\n** AGGREGATEBY **\n");

var salaryTotalByDept = LinqAggregateByExamples.GetTotalSalariesByDept_TraditionalGroupBy();
foreach (var dept in salaryTotalByDept)
    Console.WriteLine($"Total salaries for {dept.Key}: {dept.Value:C}");

Console.WriteLine();

var salaryTotalByDept_new = LinqAggregateByExamples.GetTotalSalariesByDept_NewAggregateBy();
foreach (var dept in salaryTotalByDept_new)
    Console.WriteLine($"Total salaries for {dept.Key}: {dept.Value:C}");

Console.WriteLine();

var totalsByTitle = LinqAggregateByExamples.GetTotalEmployeesAndSalariesOver100kByTitle_TraditionalGroupBy();
foreach (var title in totalsByTitle)
    Console.WriteLine($"{title.Value.Item1} {title.Key.ToLower()} personnel earn over 100k, for a total of {title.Value.Item2:C}");

Console.WriteLine();

var totalsByTitle_new = LinqAggregateByExamples.GetTotalEmployeesAndSalariesOver100kByTitle_NewAggregateBy();
foreach (var title in totalsByTitle_new)
    Console.WriteLine($"{title.Value.Item1} {title.Key.ToLower()} personnel earn over 100k, for a total of {title.Value.Item2:C}");
