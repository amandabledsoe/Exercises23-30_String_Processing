bool runningProgram = true;
string userInput;
bool isANumber;

Console.WriteLine("Welcome to the program for Exercises 23 - 30 in the 2022 Grand Circus C# .Net boot camp.");
Console.WriteLine("");
while (runningProgram)
{
    Console.WriteLine("Which exercise would you like to run?");
    Console.Write("Enter a number between 23 and 30 inclusive: ");
    userInput = Console.ReadLine();
    isANumber = int.TryParse(userInput, out int exerciseNumber);
    if (isANumber)
    {
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
                    //DoExercise24();
                    break;
                case 25:
                    Console.Clear();
                    //DoExercise25();
                    break;
                case 26:
                    Console.Clear();
                    //DoExercise26();
                    break;
                case 27:
                    Console.Clear();
                    //DoExercise27();
                    break;
                case 28:
                    Console.Clear();
                    //DoExercise28();
                    break;
                case 29:
                    Console.Clear();
                    //DoExercise29();
                    break;
                case 30:
                    Console.Clear();
                    //DoExercise30();
                    break;
            }
            runningProgram = RunProgramAgainPrompt();
        }
        else if (exerciseNumber < 14 || exerciseNumber > 22)
        {
            Console.WriteLine("");
            Console.WriteLine("Sorry, that number appears to be out of range. Please try again.");
            Console.WriteLine("");
        }
    }
    else
    {
        Console.WriteLine("");
        Console.WriteLine("Sorry, that doesnt appear to be a number. Please try again.");
        Console.WriteLine("");
    }
}
Console.WriteLine("This concludes Exercises 23 - 30 for the 2022 Grand Circus C# .Net boot camp.");
Console.WriteLine("Goodbye...");

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
static void DoExercise23()
{
    Console.WriteLine("EXERCISE 23:");
    Console.WriteLine("------------------------------");
    Console.WriteLine("Prompt the user for a number. Use a for loop to output the squares of all the numbers from 1 to that number.");
    Console.WriteLine("");
    Console.WriteLine("Press Enter to begin this exercise.");
    Console.ReadLine();
    Console.Clear();

    bool doingExercise23 = true;
    while (doingExercise23)
    {

    }
}