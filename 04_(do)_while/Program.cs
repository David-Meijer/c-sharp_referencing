

//Do-while loop
//Run code at least once
bool isValidAge;
int age;

do
{
    Console.Write("Please enter you age: ");
    isValidAge = int.TryParse(Console.ReadLine(), out age);
    if  (!isValidAge || age > 125 || age < 0)
    {   
        isValidAge = false;
        Console.WriteLine("You did not enter a valid age, please try again");
    }
}
while (!isValidAge);

Console.WriteLine("Your entered age was validated to be correct!");


//While loop
//Run code 0 or more times
bool isValidYear = false;
int currentYear;

while (!isValidYear)
{
    Console.Write("Please enter the current year: ");
    isValidYear = int.TryParse(Console.ReadLine(), out currentYear);
    if (!isValidYear || currentYear < 2025)
    {
        isValidYear = false;
        Console.WriteLine("You did not enter a valid year, please try again");
    }
}

Console.WriteLine("Your entered year was validated to be correct!");