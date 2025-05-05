
//specify array length and indivually assign
string[] namesArray = new string[2];
namesArray[0] = "David";
namesArray[1] = "Bob";

Console.WriteLine($"Hello {namesArray[0]}");
Console.WriteLine($"Hello {namesArray[1]}");
Console.WriteLine($"We just greeted {namesArray.Length} people!"); //access the array length

//specify array by assigning the array to it
string[] anotherNamesArray = ["Foo", "Bar"];

Console.WriteLine($"{anotherNamesArray[0]} {anotherNamesArray[1]}!");

//specify array by using a splitted string
string historicalFigures = "Cleopatra,Caesar,Einstein,Columbus";
string[] historicalFiguresArray = historicalFigures.Split(',');

Console.WriteLine($"Hello {historicalFiguresArray[3]}");

//specifying array by giving it a sequence (note that the array length is not specified @ new string[])
string[] favouriteFoodArray = new string[] {"Carbonara", "Pizza", "Curry"};
Console.WriteLine($"Lets eat {favouriteFoodArray[0]} tonight!");