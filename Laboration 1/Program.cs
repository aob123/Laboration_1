//Laboration 1 - Find numbers in string with characters

string input = "29535123p48723487597645723645";
double sum = 0;

//Start a new substring at every index (outputs a new string starting at each character)
for (int i = 0; i < input.Length; i++)
{
    //Create substring from input based on index
    string currentString = input.Substring(i);
    //Get first character of current substring
    string firstCharacter = currentString.Substring(0, 1);
    //Find the next occurence of firstCharacter
    int nextOccurance = currentString.IndexOf(firstCharacter, 1);

    //Get the number between position 0 of currentString and index number based on nextOccurance
    string getNumber = currentString.Substring(0, nextOccurance + 1);
    //TryParse getNumber, checks if characters are letters or not
    bool noLetters = double.TryParse(getNumber, out double result);

    //If nextOccurance is greater than 0 and cotains no letters, print to console.
    if (nextOccurance > 0 && noLetters)
    {
        //Split the input string into substrings;

        //partOne: starts at position 0 and ends at i
        //number : starts at i and ends at index represented by getNumber.Length
        //partTwo: starts at i + getNumber.Length  
        
        string partOne = input.Substring(0, i);
        string number = input.Substring(i, getNumber.Length);
        string partTwo = input.Substring(i + getNumber.Length);

        //Print the seuqence to console, with the patterns colored green
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(partOne);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(number);
        Console.ForegroundColor= ConsoleColor.White;
        Console.Write(partTwo + "\n");

        //Increment sum of all numbers 
        sum += result;
    }
}

Console.Write($"\nThe sum of all numbers is = {sum} \n\n\n");


