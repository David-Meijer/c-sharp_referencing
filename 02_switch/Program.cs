


string firstName = "David";
int age = 29;

switch (firstName.ToLower())
{
    case "david":
        Console.WriteLine("Hey you!");
        break;
    
    case "caesar" or "cleopatra":
        Console.WriteLine("You are very old!");
        break;
    
    default:
        Console.WriteLine("I don't think i know you..");
        break;
}

switch (age)
{
    case >= 0 and < 4:
        Console.WriteLine("Your are not in school yet.");
        break;
    
    case >= 4 and < 17:
        Console.WriteLine("You are most likely already in school.");
        break;
    
    case >= 17 and < 26:
        Console.WriteLine("Do you already have a job or still studying?");
        break;

    case >= 26 and <= 67:
        Console.WriteLine("You are probably working!");
        break;

    case > 67 and <= 120:
        Console.WriteLine("You probably stopped working already!");
        break;

    default:
        Console.WriteLine("I wan't expecting to encounter an age of " + age);
        break;
}