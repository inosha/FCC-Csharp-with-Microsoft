//Create readable code with conventions, whitespace, and comments in C# 

/*
Following code used to reverse the message.
And count given character  in the message.
prints results to the Console.
*/
string originalMessage = "The quick brown fox jumps over the lazy dog.";
char[] Message = originalMessage.ToCharArray();
Array.Reverse(Message);

int letterCount = 0;
foreach (char letter in Message) { 
    if (letter == 'o') { letterCount++; } 
    }

string new_message = new String(Message);

Console.WriteLine(new_message);
Console.WriteLine($"'o' appears {letterCount} times.");
