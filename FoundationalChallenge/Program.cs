// Challenge from Microsoft Training module: "Call Methods from the .NET Class Library"
// Unit 5 of 8

// Find a method to returns the larger of the two numbers (500 & 600) and store
//      larger number in variable; print to terminal.

int firstValue = 500;
int secondValue = 600;
int largerValue;

largerValue = Math.Max(firstValue, secondValue);

Console.WriteLine(largerValue);