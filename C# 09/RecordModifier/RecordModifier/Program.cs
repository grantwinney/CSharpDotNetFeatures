using RecordModifier;

// Standard class; doesn't implement interface or override operators
var plane1 = new Plane("Cessna", "680A", 2015);
var plane2 = new Plane("Cessna", "680A", 2015);

Console.WriteLine("Testing equality in Plane class:");
Console.WriteLine(plane1.Equals(plane2));  // false
Console.WriteLine(plane1 == plane2);       // false
Console.WriteLine(plane1 != plane2);       // true


// Standard class; implements IEquatable<T> and overrides operators
var train1 = new Train("Odakyu", "3000", 1958);
var train2 = new Train("Odakyu", "3000", 1958);

Console.WriteLine("\nTesting equality in Train class:");
Console.WriteLine(train1.Equals(train2));  // true
Console.WriteLine(train1 == train2);       // true
Console.WriteLine(train1 != train2);       // false


// Record class; does the heavy lifting for us with regards to equality
var auto1 = new Automobile("Toyota", "Corolla", 2023);
var auto2 = new Automobile("Toyota", "Corolla", 2023);

Console.WriteLine("\nTesting equality in Automobile class:");
Console.WriteLine(auto1.Equals(auto2));  // true
Console.WriteLine(auto1 == auto2);       // true
Console.WriteLine(auto1 != auto2);       // false

Console.WriteLine("\nTesting 'with' keyword:");
var kia = new Automobile("Kia", "Forte", 2016);
var newerKia = kia with { Year = 2021 };

Console.WriteLine(kia);
Console.WriteLine(newerKia);
Console.WriteLine(kia == newerKia);  // false
