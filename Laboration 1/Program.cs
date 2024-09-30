//Laboration 1 - Find numbers in string with characters

string input = "29535123p48723487597645723645";
double sum = 0;

//Start a new substring at every index (outputs a new string starting at each character)
for (int i = 0; i < input.Length; i++)
{
    string currentString = input.Substring(i);
    string firstCharacter = currentString.Substring(0, 1);
    int nextOccurance = currentString.IndexOf(firstCharacter, 1);

    //Find the next occurance of the firstCharacter (e.g. if first number is 2, then find the next 2)
    //if the firstCharacter does occur again it i will return index number, and if not it will return -1.
    string getNumber = currentString.Substring(0, nextOccurance + 1);
    bool noLetters = double.TryParse(getNumber, out double result);
    //Console.WriteLine($"Index: {i} | First Character: {firstCharacter} | Current String: {currentString} | GET STRING:  {result} | nextOccuarnce: {nextOccurance} ");

    if (nextOccurance > 0 && noLetters)
    {
        //string start = result.ToString();

        string partOne = input.Substring(0, i);
        string removed = input.Substring(i, getNumber.Length);
        string partTwo = input.Substring(i + getNumber.Length);

        //Print the seuqence to console, with the patterns colored green
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(partOne);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.Write(removed);
        Console.ForegroundColor= ConsoleColor.White;
        Console.Write(partTwo + "\n");

        //Increment sum of all numbers 
        sum += result;
    }
}

Console.Write($"\nThe sum of all numbers is = {sum} \n\n\n");


