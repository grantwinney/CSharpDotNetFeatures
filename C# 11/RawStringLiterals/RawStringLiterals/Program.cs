using static System.Console;
using System.Runtime.InteropServices;

[DllImport("User32.dll", CharSet = CharSet.Unicode)]
static extern int MessageBox(IntPtr h, string m, string c, int type);


// Normal string allows escape sequences,
// quotes must be escaped
WriteLine("Windows dir: \t\t \"C:\\Windows\"");                  // Windows dir:             "C:\Windows"

// Verbatim strings ignore escape sequences,
// quotes must be doubled
WriteLine(@"Windows dir: \t\t ""C:\Windows""");                  // Windows dir: \t\t "C:\Windows"

// String interpolation behaves like a normal string,
// but allows inline variables; curly braces must be doubled
WriteLine($"Today's date is: \t\t \"{{{DateTime.Now}}}\"");      // Today's date is:                 "{12/13/2024 9:31:09 PM}"

// Verbatim interpolated strings ignore escape seqs,
// but still allow inline variables
WriteLine($@"Today's date is: \t\t ""{{{DateTime.Now}}}""");     // Today's date is: \t\t "{12/13/2024 9:31:09 PM}"


// Single-line raw string literals start and end with at least three quotes,
// don't allow escaped sequences,
// require a dollar sign to allow for string interpolation,
// require multiple dollar signs to support literal curly braces
WriteLine("""Today's date is: \t "{DateTime.Now}" """);             // Today's date is: "{DateTime.Now}"
WriteLine(""""Today's date is: \t """{DateTime.Now}""" """");       // Today's date is: """{DateTime.Now}"""

WriteLine($"""Today's date is: \t "{DateTime.Now}" """);            // Today's date is: "12/13/2024 9:31:09 PM"
WriteLine($$"""Today's date is: \t "{{{DateTime.Now}}}" """);       // Today's date is: "{12/13/2024 9:31:09 PM}"
WriteLine($$$"""Today's date is: \t "{{{{{DateTime.Now}}}}}" """);  // Today's date is: "{{12/13/2024 9:31:09 PM}}"


// Multi-line raw string literals follow the same rules as above;
// None of the lines may appear to the left of the closing set of quotes

WriteLine("""
    Now this is interesting!
            Is this indented? \t "{DateTime.Now}"
    """);

// Now this is interesting!
//         Is this indented? \t "{DateTime.Now}"

var tab = $"\t";

WriteLine("""
    Now this is interesting!
            Is this indented? {tab} "{DateTime.Now}"
    """);

// Now this is interesting!
//         Is this indented? {tab} "{DateTime.Now}"

WriteLine($"""
    Now this is interesting!\n\n\n
            Is this indented? {tab} "{DateTime.Now}"
    """);

// Now this is interesting!
//         Is this indented?        "12/13/2024 9:44:39 PM"

WriteLine($"""""
    Now this is interesting!
            Is this indented? {tab} """"{DateTime.Now}""""
    """"");

// Now this is interesting!
//         Is this indented?        """"12/13/2024 9:44:39 PM""""

WriteLine($$"""
    Now this is interesting!
            Is this indented? {{tab}} "{{{DateTime.Now}}}"
    """);

// Now this is interesting!
//         Is this indented?        "{12/13/2024 9:44:39 PM}"


MessageBox(0, $"""
    Now this is interesting!

            Is this indented? {tab} "{DateTime.Now}"
    """, "Silly Message", 0);
