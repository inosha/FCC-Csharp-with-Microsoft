/*
You must use either the do-while statement or the while statement as an outer game loop.
The hero and the monster will start with 10 health points.
All attacks will be a value between 1 and 10.
The hero will attack first.
Print the amount of health the monster lost and their remaining health.
If the monster's health is greater than 0, it can attack the hero.
Print the amount of health the hero lost and their remaining health.
Continue this sequence of attacking until either the monster's health or hero's health is zero or less.
Print the winner
*/

/* output example,
Hero was damaged and lost 6 health and now has 3 health.
Monster was damaged and lost 9 health and now has -7 health.
Hero wins!
*/

using System;
int hero = 10;
int monster = 10;

Random hit = new Random();

do
{
    int deduct = hit.Next(1, 10);
    monster -= deduct;
    Console.WriteLine($"Monster was damaged and lost {deduct} health and now has {monster} health.");

    if (monster <= 0) continue;

    deduct = hit.Next(1, 10);
    hero -= deduct;
    Console.WriteLine($"Hero was damaged and lost {deduct} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine( hero > monster ? "Hero wins!" : "Monster wins!");

// string winner = hero > monster ? "Hero" : "Monster";
// int score = hero > monster ? hero : monster;
// Console.Write($"{winner} won the game by {score}");
