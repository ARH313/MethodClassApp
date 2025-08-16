using System;
using MethodClassApp; // <- matches the namespace in MathOps.cs

// Instantiate the class
var ops = new MathOps();

// Call the method with two numbers (positional arguments)
ops.ProcessNumbers(5, 20);

// Call the method again using named parameters
ops.ProcessNumbers(second: 99, first: 12);

// Keep console open so results are visible
Console.WriteLine("Press any key to exit...");
Console.ReadKey();

