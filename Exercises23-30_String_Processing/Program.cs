bool runningProgram = true;
int exerciseNumber;

Introduction();

while (runningProgram)
{
    exerciseNumber = GetExerciseNumber();
    if (exerciseNumber >= 23 && exerciseNumber <= 30)
    {
        Console.WriteLine("");
        switch (exerciseNumber)
        {
            case 23:
                Console.Clear();
                DoExercise23();
                break;
            case 24:
                Console.Clear();
                DoExercise24();
                break;
            case 25:
                Console.Clear();
                DoExercise25();
                break;
            case 26:
                Console.Clear();
                DoExercise26();
                break;
            case 27:
                Console.Clear();
                DoExercise27();
                break;
            case 28:
                Console.Clear();
                DoExercise28();
                break;
            case 29:
                Console.Clear();
                DoExercise29();
                break;
            case 30:
                Console.Clear();
                DoExercise30();
                break;
        }
        runningProgram = RunProgramAgainPrompt();
    }
    else if (exerciseNumber < 23 || exerciseNumber > 23)
    {
        Console.WriteLine("");
        Console.WriteLine("Sorry, that number appears to be out of the specified range. Please try again.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
    }
}
Console.WriteLine("This concludes Exercises 23 - 30 for the 2022 Grand Circus C# .Net boot camp.");
Console.WriteLine("Goodbye...");

static void Introduction()
{
    Console.WriteLine("Welcome to the program for Exercises 23 - 30 in the 2022 Grand Circus C# .Net boot camp.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to Continue.");
    Console.ReadLine();
    Console.Clear();
}
static int GetExerciseNumber()
{
    bool gettingUserNumber = true;
    while (gettingUserNumber)
    {
        Console.WriteLine("Which exercise would you like to run?");
        Console.Write("Enter a number between 23 and 30 inclusive: ");
        string userInput = Console.ReadLine();
        bool isANumber = int.TryParse(userInput, out int exerciseNumber);
        if (isANumber)
        {
            return exerciseNumber;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, that doesnt appear to be a number. Please try again.");
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
        }
    }
    return -1;
}
static void DoExercise23()
{
    Console.WriteLine("EXERCISE 23:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter a string.  Extract and output the first ten characters of the string.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise23 = true;
    while (doingExercise23)
    {
        Console.WriteLine("This is meant to represent exercise 23.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise23 = AskingUserToRepeat();
    }
}
static void DoExercise24()
{
    Console.WriteLine("EXERCISE 24:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter a string.  Extract and output the last ten characters of the string.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise24 = true;
    while (doingExercise24)
    {
        Console.WriteLine("This is meant to represent exercise 24.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise24 = AskingUserToRepeat();
    }
}
static void DoExercise25()
{
    Console.WriteLine("EXERCISE 25:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter a sentence.  Split the sentence into individual words and " +
        "display each word on its own line.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise25 = true;
    while (doingExercise25)
    {
        Console.WriteLine("This is meant to represent exercise 25.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise25 = AskingUserToRepeat();
    }
}
static void DoExercise26()
{
    Console.WriteLine("EXERCISE 26:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter text.  Count and output how many vowels are in the string.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise26 = true;
    while (doingExercise26)
    {
        Console.WriteLine("This is meant to represent exercise 26.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise26 = AskingUserToRepeat();
    }
}
static void DoExercise27()
{
    Console.WriteLine("EXERCISE 27:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter text.  Count and output how many consonants are in the string.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise27 = true;
    while (doingExercise27)
    {
        Console.WriteLine("This is meant to represent exercise 27.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise27 = AskingUserToRepeat();
    }
}
static void DoExercise28()
{
    Console.WriteLine("EXERCISE 28:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter text.  Remove all the vowels and output the text.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise28 = true;
    while (doingExercise28)
    {
        Console.WriteLine("This is meant to represent exercise 28.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise28 = AskingUserToRepeat();
    }
}
static void DoExercise29()
{
    Console.WriteLine("EXERCISE 29:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter text.  Remove all the vowels in the middle of the word, " +
        "but leave any that start or end the word.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise29 = true;
    while (doingExercise29)
    {
        Console.WriteLine("This is meant to represent exercise 29.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise29 = AskingUserToRepeat();
    }
}
static void DoExercise30()
{
    Console.WriteLine("EXERCISE 30:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user to enter text.  Reverse the text.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise30 = true;
    while (doingExercise30)
    {
        Console.WriteLine("This is meant to represent exercise 30.");
        Console.WriteLine("");
        Console.WriteLine("Press Enter to Continue.");
        Console.ReadLine();
        Console.Clear();
        doingExercise30 = AskingUserToRepeat();
    }
}
static bool AskingUserToRepeat()
{
    bool askingUser = true;
    while (askingUser)
    {
        Console.WriteLine("Would you like to do this exercise again?");
        Console.Write("Enter 'y' or 'yes' to run again, or enter 'n' or 'no' to stop: ");
        string answer = Console.ReadLine().ToLower();
        if (answer == "y" || answer == "y")
        {
            Console.WriteLine("");
            Console.Clear();
            return true;
        }
        else if (answer == "n" || answer == "no")
        {
            Console.WriteLine("");
            Console.WriteLine("Press Enter to Continue.");
            Console.ReadLine();
            Console.Clear();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("I'm sorry, I didn't understand that response. Please try again.");
            Console.WriteLine("");
        }
    }
    return false;
}
static bool RunProgramAgainPrompt()
{
    bool promptingUser = true;
    while (promptingUser)
    {
        Console.WriteLine("Would you like to do another exercise?");
        Console.WriteLine("Enter 'y' or 'yes' to do another exercise, or enter 'n' or 'no' to exit the program.");
        string userInput = Console.ReadLine().ToLower();
        if (userInput == "y" || userInput == "yes")
        {
            Console.WriteLine("");
            Console.Clear();
            return true;
        }
        else if (userInput == "n" || userInput == "no")
        {
            Console.WriteLine("");
            Console.Clear();
            return false;
        }
        else
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, I didn't understand that response. Please try again.");
            Console.WriteLine("");
        }
    }
    return false;
}