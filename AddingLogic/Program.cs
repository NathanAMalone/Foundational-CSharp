// Microsoft training module: "Add decision logic"  unit 2 & 3

// Exercise: Create a game to practice if statements
// Use Random.Nest() to simulate three dice
// If any two dice result in same value, get 2 bonus points
// If all three dice are same value, get 6 bonus pints
// If sum of three dice plus bonus points is >= 15, you win


// Create var for each roll for each dice and total of dice; display in console
using System.Security.Principal;

Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// Code below used when checking logic pertaining to rolled triples.
// int roll1 = 4;
// int roll2 = 4;
// int roll3 = 4;

int total = roll1 + roll2 + roll3;

Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if two of the 3 match, add 2 bonus points.  If all three  match, add 6
if ((roll1 == roll2) || (roll1 == roll3) || (roll2 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
        Console.WriteLine($"New total = {total}!");
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
        Console.WriteLine($"New total = {total}!");
    }
}

// if total is >=15, display You win!; else display, Sorry, you lose.
// if (total >= 15)
// {
//     Console.WriteLine("You win!");
// }
// else
// {
//     Console.WriteLine("Sorry, you lose.");
// }


// Now have the player win a prize instead of just a message
    // if score >= 16, win new car.
    // if score >= 10, win new laptop.
    // if score = 7, win a trip
    // otherwise, win a kitten.


// If total >= 16, new car.
if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
// If total >= 10, new laptop.
else if (total >=10)
{
    Console.WriteLine("You win a new laptop!");
}
// if total = 7, trip.
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
// if anything else, kitten.
else
{
    Console.WriteLine("You win a kitten!");
}