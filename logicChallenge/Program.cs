// Microsoft training module: "Add decision logic"  unit 4

// Challenge: display a subscription renewal message when user logs in
    // notify user subscription will end soon
// Rule 1: Code should display only one message
// Rule 2: Display message when sub will expire in 10 days or less
// Rule 3: If sub expires <= 5, display:
    // "Your subscription expires in _ days."
    // "Renew now and save 10%!"
// Rule 4: If sub expires = 1, display:
    // "Your subscription expires within a day!"
    // "Renew now and save 20%!"
// Rule 5: If sub expired, display:
    // "Your subscription has expired."
// Rule 6: If sub expires > 10, display nothing.


// Setup: create random number for days until expiration
Random random = new Random();
int daysUntilExpiration = random.Next(12);
int discountPercentage = 0;


// Code below used when checking logic
// int daysUntilExpiration=0;
// int daysUntilExpiration=1;
// int daysUntilExpiration=3;
// int daysUntilExpiration=5;
// int daysUntilExpiration=7;
// int daysUntilExpiration=10;
// int daysUntilExpiration=12;
// Console.WriteLine(daysUntilExpiration);


// Discount should be 20 if 1 day left
if (daysUntilExpiration == 1)
{
    discountPercentage = 20;
}
// Discount should be 10 if 5 or less days left
else if (daysUntilExpiration <= 5)
{
    discountPercentage = 10;
}

// Sub expired if 0 days left
if (daysUntilExpiration == 0)
{
    Console.WriteLine("Your subscription has expired.");
}
// Sub warning if 1 day left
else if (daysUntilExpiration == 1)
{
    Console.WriteLine("Your subscription expires within a day!");
}
// Sub warning if 5 days or less
else if (daysUntilExpiration <= 5)
{
    Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
}
// Sub warning if 10 days or less
else if (daysUntilExpiration <= 10)
{
    Console.WriteLine("Your subscription will expire soon. Renew now!");
}

// Discount offer if 1 to 5 days left
if (daysUntilExpiration >= 1 && daysUntilExpiration <=5 )
{
    Console.WriteLine($"Renew now and save {discountPercentage}%!");
}