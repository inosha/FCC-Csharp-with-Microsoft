// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello C#!");

// Call Methods From the .NET Class Library Using C#

Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//Stateless(Static) methods: Console.WriteLine() method doesn't rely on any values stored in memory. 
// It performs its function and finishes without impacting the state of the application in any way
// When calling a stateless method, you don't need to create a new instance of its class first.

//Stateful (instance) methods
// rely on values stored in memory by previous lines of code that have already been executed
// Or they modify the state of the application by updating values or storing new values in memory
// When calling a stateful method, you need to create an instance of the class, and access the method on the object.
// An instance of a class is called an object.

//Overloaded methods

Random dice = new Random();
int roll1 = dice.Next();
int roll2 = dice.Next(101);
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

//Code challenge: Implement a method of the Math class that returns the larger of two numbers

int firstValue = 500;
int secondValue = 600;
int largerValue = System.Math.Max(firstValue,secondValue);

Console.WriteLine(largerValue);
