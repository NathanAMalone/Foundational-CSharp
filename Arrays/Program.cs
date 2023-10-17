// Declare new array
/* string[] fraudulentOrderIDs = new string[3];

// Assign values
fraudulentOrderIDs[0] = "A123";
fraudulentOrderIDs[1] = "B456";
fraudulentOrderIDs[2] = "C789";

// Try to use an index not in array
// fraudulentOrderIDs[3] = "D000";
*/

// Initialize array during declaration
string[] fraudulentOrderIDs = { "A123", "B456", "C789" };

// Retrieve values
Console.WriteLine($"First: {fraudulentOrderIDs[0]}");
Console.WriteLine($"Second: {fraudulentOrderIDs[1]}");
Console.WriteLine($"Third: {fraudulentOrderIDs[2]}");

// Reassign a value
fraudulentOrderIDs[0] = "F000";

// Retrieve reassigned value
Console.WriteLine($"Reassign First: {fraudulentOrderIDs[0]}");

// Report number of fraudulent orders
Console.WriteLine($"There are {fraudulentOrderIDs.Length} fraudulent orders to process.");