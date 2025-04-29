Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

Console.Write("What is your last name? ");
string lastName = Console.ReadLine();


if (firstName.ToLower() == "david" && 
    lastName.ToLower() == "meijer")
{
    Console.WriteLine("Welcome back boss!");
}

else if (firstName.ToLower() == "david")
{
    Console.WriteLine("You have a cool first name!");
}

else if (lastName.ToLower() == "meijer")
{
    Console.WriteLine("You have a cool last name!");
}

else 
{
    Console.WriteLine("I dont like your name!");
}
