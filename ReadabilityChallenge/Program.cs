// Microsoft Training: Readable code:  Unit 5, Challenge Exercise


/*Original code; improve readability

string str = "The quick brown fox jumps over the lazy dog.";
// convert the message into a char array
char[] charMessage = str.ToCharArray();
// Reverse the chars
Array.Reverse(charMessage);
int x = 0;
// count the o's
foreach (char i in charMessage) { if (i == 'o') { x++; } }
// convert it back to a string
string new_message = new String(charMessage);
// print it out
Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {x} times.");

*/


// This code takes a string and converts it into a char array.
    // The array is reversed and counts how many times "o" is in the array
    // The array is converted back into a string (Still in reverse order)
    // Code prints out how many times "o" occurs.

string message = "The quick brown fox jumps over the lazy dog.";

char[] charactersInMessage = message.ToCharArray();
Array.Reverse(charactersInMessage);

int numOfLetters = 0;

foreach (char i in charactersInMessage) 
{ 
    if (i == 'o') 
    { 
        numOfLetters++; 
    } 
}

string newMessage = new String(charactersInMessage);

Console.WriteLine(newMessage);
Console.WriteLine($"'o' appears {numOfLetters} times.");