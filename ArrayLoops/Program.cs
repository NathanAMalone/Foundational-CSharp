// C# arrays: Exercise  Unit 3
    // Complete an inventory of warehouse to determine # of products ready to ship
    // Report # of products stored in each bin, along with running total
    // Running total can be used to create an audit trail


// Create an int array to store # of finished products in each bin
int[] inventory = { 200, 450, 700, 175, 250 };

// Declare variable to represent sum of finished products
int sum = 0;

// Declare int variable for current bin
int bin = 0;

//Iterate through each statement of array 
// use sum to store total # of items
// Use bin to track bin #
// Report bin #, how man items in bin, total items
foreach ( int items in inventory)
{
    sum += items;
    bin++;
    Console.WriteLine($"Bin {bin} = {items} items (Running total: {sum})");
}

// Report final sum
Console.WriteLine($"We have {sum} items in inventory.");