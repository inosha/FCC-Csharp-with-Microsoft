for (int i = 0; i <= 100; i++)
{
    if (i % 5 == 0 && i % 3 == 0)
    {
       Console.WriteLine($"{i} FizzBuzz"); 
    }
    else if (i % 5 == 0 && i % 3 != 0)
    {
       Console.WriteLine($"{i}  Buzz"); 
    }
    else if (i % 5 != 0 && i % 3 == 0)
    {
       Console.WriteLine($"{i} Fizz "); 
    }
    else
    {
    Console.WriteLine(i);
    }
}
