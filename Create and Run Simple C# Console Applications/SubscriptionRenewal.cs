Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;

// message: depending on the ramainign days

if(daysUntilExpiration == 0){
    Console.WriteLine("Your subscription has expired.");
}
else if (daysUntilExpiration == 1){
    Console.WriteLine("Your subscription expires within a day! \nRenew now and save 20%!");
        discountPercentage = 20;

}
else if (daysUntilExpiration <=5 && daysUntilExpiration > 1){
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days. Renew now and save 10%!");
    discountPercentage = 10;
}
else if (daysUntilExpiration < 10 && daysUntilExpiration > 5){
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

//display discout
if (discountPercentage > 0)
{
    Console.WriteLine($"Renew now and save {discountPercentage}%.");
}
