
Console.Write("What is your first name? ");
string firstName = Console.ReadLine();

Console.Write("What is your age? ");
string ageText = Console.ReadLine(); //Readline only gives back string values

bool isValidAge = int.TryParse(ageText, out int age);

if (!isValidAge)
{
    Console.WriteLine("You did not supply a valid age!");
    Console.WriteLine("Exiting program...");
    return; //exit the program
}

//Determine correct formatting of name based on proffer names and age
string firstNameLowerCase = firstName.ToLower();
string formattedName;
if ((firstNameLowerCase == "bob" || firstNameLowerCase == "sue") && age > 21)
{
     formattedName = $"professor {firstName}";
}
else
{
    formattedName = firstName;
}

//Great student or professor
if (age >= 21) 
{
    Console.WriteLine($"Hello {formattedName}");
}
//Somebody whose age is probably too low to be a student or professor
else
{   
    int yearsToWait = 21 - age;
    Console.WriteLine($"Hello {formattedName}, you should probably wait for {yearsToWait} more years to start studying!");
}

