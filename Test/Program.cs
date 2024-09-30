//Lab 1

string input = "29535123p48723487597645723645";

string output = "";

//Start a new substring at every index (outputs a new string starting at each character)
for (int i = 0; i <= input.Length; i++)
{
    //Substring starting from 0 and increasing in length (e.g 1 | 12 | 123 | 1234 ... and so on)
    string subString = input.Substring(0, i);
    Console.WriteLine("SUBSTRING LOOP 1 | " + subString);

    for (int j = 0; j <= subString.Length; j++)
    {      
        string subStringTwo = subString.Substring(j);
        //Console.WriteLine("SUBSTRING LOOP 2 | " + subStringTwo);

        if (subStringTwo.Length > 2 && subStringTwo.EndsWith(subStringTwo[0]))
        {
            //Check if the string is made up of ints
            bool isInt = int.TryParse(subStringTwo, out int value);

            if (isInt)
            {
                if (!subStringTwo.Substring(1, subStringTwo.Length - 2).Contains(subStringTwo[0]) || subStringTwo.Length < 2)
                {
                    output = subStringTwo; 
                    Console.WriteLine(j + " | " + output + " " + output.Length + " | isInt? " + isInt + " isIntValue " + value);

                }
                else
                {
                    //Console.WriteLine(" | isInt? " + isInt + " isIntValue " + value);
                    continue;
                }
            }
            else
            {
                continue;
            }
        }
    }
}



