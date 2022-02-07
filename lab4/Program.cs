bool Continue = true;
while (Continue)
{
    Console.WriteLine("please enter a sentence: ");
    string entry = Console.ReadLine();
    entry.ToLower();
    Console.WriteLine(ToPigLatin(entry));





    Console.WriteLine("Do you want to try again y/n");
    string loopChoice = Console.ReadLine();
    if (loopChoice == "y")
    {
        Continue = true;
    }
    else if (loopChoice == "n")
    {
        Continue = false;
    }
}





static string ToPigLatin(string sentence)
{

    const string vowels = "AEIOUaeio";
    List<string> pigWords = new List<string>();

    foreach (string word in sentence.Split(' '))
    {
        string firstLetter = word.Substring(0, 1);
        string restOfWord = word.Substring(1, word.Length - 1);
        int currentLetter = vowels.IndexOf(firstLetter);

        if (currentLetter == -1)
        {
            pigWords.Add(restOfWord + firstLetter + "ay");
        }
        else
        {
            pigWords.Add(word + "way");
        }
    }
    return string.Join(" ", pigWords);
}

