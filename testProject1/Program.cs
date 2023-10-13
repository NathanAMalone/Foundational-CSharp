Console.WriteLine("Hello, C#");

// Random is a stateful method.  It relies on values stored in memory.
Random dice = new Random();
int roll = dice.Next(1, 7);
Console.WriteLine(roll);

//Below will not work because you are trying to call Random like a stateless method.
// Must create a new instance of its class first due to being stateful.
    // int result = Random.Next();
