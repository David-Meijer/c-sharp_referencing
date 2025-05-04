
Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

Console.Write("What is your age? ");
int age = Convert.ToInt32(Console.ReadLine());

string firstNameLowerCase = firstName.ToLower();

if (firstNameLowerCase == "bob" || firstNameLowerCase == "Sue") 
{
    Console.WriteLine("Hello Professor!");
}
else if ((firstNameLowerCase != "bob" || firstNameLowerCase != "Sue") && age >= 21)
{
    Console.WriteLine("Hello student!")
} 
else
{
    Console.WriteLine("You should probably wait some more time to start studying!");
}

