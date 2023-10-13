Random dice = new Random();
// No Limit; value from 0 to 2,147,483,647 (max int value)
int roll1 = dice.Next();

// Sets Max value at < 101
int roll2 = dice.Next(101);

// set value beteween 50 < 101
int roll3 = dice.Next(50, 101);

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");

