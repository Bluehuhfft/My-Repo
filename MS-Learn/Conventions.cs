/*
This program counts the number of times the letter 'o' appears in a string and then outputs that number.
*/

string str = "The quick brown fox jumps over the lazy dog.";
char[] charMessage = str.ToCharArray(); // convert the message into a char array
Array.Reverse(charMessage); // Reverse the chars
string new_message = new String(charMessage);  // convert it back to a string

int x = 0; // count the o's
foreach (char i in charMessage) 
{ 
    if (i == 'o') 
    {
         x++; 
        } 

    }

Console.WriteLine(new_message); // print it out
Console.WriteLine($"'o' appears {x} times.");
