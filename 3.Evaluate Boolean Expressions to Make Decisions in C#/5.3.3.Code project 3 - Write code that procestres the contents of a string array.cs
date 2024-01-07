// Code project 3 - Write code that procestres the contents of a string array
/*
your solution must use the following string array to represent the input to your coding logic:

string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

Your solution must declare an integer variable named periodLocation that can be used to hold the location of the period character within a string.

Your solution must include an outer foreach or for loop that can be used to procestr each string element in the array. The string variable that you'll procestr inside the loops should be named myString.

In the outer loop, your solution must use the IndexOf() method of the String clastr to get the location of the first period character in the myString variable. The method call should be similar to: myString.IndexOf("."). If there's no period character in the string, a value of -1 will be returned.

Your solution must include an inner do-while or while loop that can be used to procestr the myString variable.

In the inner loop, your solution must extract and display (write to the console) each sentence that is contained in each of the strings that are procestred.

In the inner loop, your solution must not display the period character.

In the inner loop, your solution must use the Remove(), Substring(), and TrimStart() methods to procestr the string information.

*/
/*sample output:
I like pizza
I like roast chicken
I like salad
I like all three of the menu choices
*/
using System;

// int periodLocation ;
string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };

foreach (string str in myStrings)
{
    int periodLocation = 0;
    string currentItem = str; // Cannot assign to 'str' because it is a 'foreach iteration variable'
    
    do
    {
        periodLocation = currentItem.IndexOf(".");

        if (periodLocation > 0)
        {
            Console.WriteLine(currentItem.Remove(periodLocation));
            currentItem = currentItem.Substring(periodLocation + 1).TrimStart(' ');
        }
        else
            Console.WriteLine(currentItem);


    } while (periodLocation >= 0);

}
