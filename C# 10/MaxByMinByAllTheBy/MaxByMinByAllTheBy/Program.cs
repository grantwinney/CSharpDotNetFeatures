using MaxByMinByAllTheBy;


// Finding the max number from a list of integers
var maxNumber = new[] { 4, 3, 1, 17, 9, 0 }.Max();
Console.WriteLine($"The max number is: {maxNumber}");


// Finding the highest and lowest paid Employee, using the ICompare<T> implementation
var employees = new List<Employee>
{
    new("Ed",  "Accounting",  78_000, new(2010,3,2), 1),
    new("Ned", "Accounting", 120_000, new(2000,2,6), 2),
    new("Ted", "Accounting",  94_000, new(2020,1,1), 0),
    new("Bob", "Accounting",  55_000, new(2015,7,2), 3)
};

var max = employees.Max();  // Ned
var min = employees.Min();  // Bob

Console.WriteLine($"{max!.Name} makes the most at {max.Salary:C}, " +
    $"while {min!.Name} makes the least at {min.Salary:C}.");


// Finding the newest and oldest hired Employee, using MaxBy and MinBy
var newestHire = employees.MaxBy(e => e.HireDate);
var oldestHire = employees.MinBy(e => e.HireDate);

Console.WriteLine($"{newestHire!.Name} was the newest hire on {newestHire.HireDate}, " +
    $"while {oldestHire!.Name} was hired long ago on {oldestHire.HireDate}.");


// Finding the Employee with the highest and lowest security, using MaxBy and MinBy
var mostSecurePersonnel = employees.MaxBy(e => e.SecurityLevel);
var leastSecurePersonnel = employees.MinBy(e => e.SecurityLevel);

Console.WriteLine($"{mostSecurePersonnel!.Name} has the highest security level, " +
    $"while {leastSecurePersonnel!.Name} has the lowest.");


// Finding the company with the most employees, using MaxBy
var warnerEmps = new Company("Warner Bros", new List<Employee>
{
    new("Yakko", "IT",  78_000, new(2010,3,2), 1),
    new("Wakko", "IT", 90_000,  new(2000,2,6), 2),
    new("Dot", "IT", 90_000,  new(2000,2,6), 2),
});

var acmeEmps = new Company("Acme Inc", new List<Employee>
{
    new("Wile E Coyote", "IT",  78_000, new(2010,3,2), 1),
    new("Road Runner", "IT", 90_000,  new(2000,2,6), 2),
});

var largestCompany = new[] { warnerEmps, acmeEmps }.MaxBy(c => c.Employees.Count());

Console.WriteLine($"{largestCompany!.Name} is the largest company.");
