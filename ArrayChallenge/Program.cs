// Microsoft training: C# Arrays:  Exercise Challenge Unit 4

// Orders that start with B encounter fraud at 25 times greater
    // Write new code that outputs Order ID of new orders where ID starts with B


// Declare an array and initialize; will represent fraudulent Order ID
string[] inventory = { "B123", "C234", "A345", "C15", "B177", "G3003", "C235", "B179" };

// Iterate through array; identify if string starts with B
foreach (string items in inventory)
{
    if (items.StartsWith("B"))
    {
        Console.WriteLine(items);
    }
}