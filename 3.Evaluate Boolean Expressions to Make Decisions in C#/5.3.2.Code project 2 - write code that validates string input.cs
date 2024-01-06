// Code project 2 - write code that validates string input
/*
Your solution must include either a do-while or while iteration.

Before the iteration block: your solution must use a Console.WriteLine() statement to prompt the user for one of three role names: Administrator, Manager, or User.

Inside the iteration block:

Your solution must use a Console.ReadLine() statement to obtain input from the user.
Your solution must ensure that the value entered matches one of the three role options.
Your solution should use the Trim() method on the input value to ignore leading and trailing space characters.
Your solution should use the ToLower() method on the input value to ignore case.
If the value entered isn't a match for one of the role options, your code must use a Console.WriteLine() statement to prompt the user for a valid entry.
Below (after) the iteration code block: Your solution must use a Console.WriteLine() statement to inform the user that their input value has been accepted.

*/

/*
Enter your role name (Administrator, Manager, or User)
Admin
The role name that you entered, "Admin" is not valid. Enter your role name (Administrator, Manager, or User)
   Administrator
Your input value (Administrator) has been accepted.
*/

bool isValidInput = false; // do-while condition variable

Console.WriteLine("Enter your role name (Administrator, Manager, or User)");

do {
    string? userInput = Console.ReadLine().Trim();

    switch (userInput.ToLower())
    {
        case "administrator":
        case "manager":
        case "user":
            {
                isValidInput = true;
                Console.WriteLine($"Your input value ({userInput}) has been accepted.");
                break;
            }
        default:
            Console.WriteLine($"The role name that you entered, \"{userInput}\" is not valid. Enter your role name (Administrator, Manager, or User)");
            break;

    }
}
while (!isValidInput); // escape at isValidInput = true
