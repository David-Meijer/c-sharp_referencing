

//Do-while loop
//Run code at least once
bool isValidAge;
int age; //Make sure that the age exists not only in the context of the do while block

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
Console.Write("Please enter the current year: ");
bool isValidYear = int.TryParse(Console.ReadLine(), out int currentYear);

while (!isValidYear || currentYear < 2025)
{
    Console.Write("You did not enter a valid year, please enter the current year again: ");
    isValidYear = int.TryParse(Console.ReadLine(), out currentYear);
}

Console.WriteLine("Your entered year was validated to be correct!");