// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
// dice project

using System.Security.AccessControl;

Random dice = new Random();

int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

//roll1 = 6;
//roll2 = 6;
//roll3 = 6;

int total = roll1 + roll2 + roll3 ;
Console.WriteLine($"Dice roll : {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) ||(roll3 == roll1)){
    if ((roll1 == roll2) && (roll2 == roll3)){
        Console.WriteLine("You roled triples! +6 bonus to the total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!, +2 bonus to total!");
        total += 2;
    }
}

if (total >= 16){
    Console.WriteLine("You win a new car!");
}
else if(total >= 10){
    Console.WriteLine("you win a new laptop!");
}
else if(total == 7){
    Console.WriteLine("You win a trip for two1");
}
else{
    Console.WriteLine("You win a kitten!");
}

// if (total >= 15){
//     Console.WriteLine("You Win!");
// }
// else
// {
//     Console.WriteLine("Sorry you lost");
// }

// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if (message.Contains("fox"))
// {
//     Console.WriteLine("What does the fox say?");
// }
