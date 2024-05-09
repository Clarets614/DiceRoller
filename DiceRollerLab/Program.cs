

//Dice Roller Lab



//5 dice combinations should be recognized when 6-sided die are rolled

//------------------------------------

//main code
//Greeting, Program asks user to enter the number of sides for a pair of dice
Console.WriteLine("Welcome to the Dice Roller Extravaganza Game!");
Console.WriteLine("We will roll a pair of dice today.");


//while loop for entire program
bool runDiceRoller = true;
int total = 0;

while (runDiceRoller)
{
    Console.WriteLine("\nPlease choose the number of sides for the pair of dice you will roll:");

//while loop for question about what type of dice are rolled
// an input line allows the user to put in what type of dice


    int sides = 0;

//exception handing message is built into input field to give error message to user if they do not enter numbers

    while (int.TryParse(Console.ReadLine(), out sides) == false || sides < 1)
    {
        Console.WriteLine("Invalid Input, try again");


    }

    Console.WriteLine($"You have chosen to roll a pair of {sides} sided-die\n");
    Console.WriteLine("\n\tRrrrrrolllling.....\n");

    int resultdice1 = RollingtheDice1(sides);
    int resultdice2 = RollingtheDice2(sides);

//program displays the results of each
    Console.WriteLine($"Dice one has rolled a {resultdice1}");
    Console.WriteLine($"Dice two has rolled a {resultdice2}");

//program displays the total when dice are added together

    TotallingtheDice(resultdice1 , resultdice2 );

    if (issixsided(sides))
    {
        specialSixOutput(resultdice1, resultdice2);
    }

    if (istwentysided(sides))
    {
        specialTwentyOutput(resultdice1, resultdice2);
    }


    while (true)
    {

//program asks if user wants to roll again

    Console.WriteLine("\nWould you like to play again? y/n");
    string choice = Console.ReadLine().ToLower().Trim();
    if (choice == "y")
    {
        break;
    }
    else if (choice == "n")
    {
        runDiceRoller = false;
        break;
    }
    else
    {
        Console.WriteLine("that answer is invalid, please type only y or n");
    }
    }

}











Console.WriteLine("Thank you for playing! Press any key to exit program.");


//methods


//program "rolls" the dice
//dice roller method
static int RollingtheDice1(int sides)
{
    Random dice1 = new Random();
    int randomdice1 = dice1.Next(1,sides + 1);
    return randomdice1;
}
static int RollingtheDice2(int sides)
{
    Random dice2 = new Random();
    int randomdice2 = dice2.Next(1, sides + 1);
    return randomdice2;
}

static void TotallingtheDice(int resultdice1, int resultdice2)
{
    int total = resultdice1 + resultdice2;
    Console.WriteLine($"The total of your dice roll is {total}\n");
}


//6-sided die Combinations method
static bool issixsided(int sides)
{
    if(sides == 6)
    {
        return true;
    }
    else
    {
        return false;
    }
}
//6sided die Win method
static void specialSixOutput(int resultdice1, int resultdice2)
{   
    if((resultdice1 == 1) && (resultdice2 == 1))
    {
        Console.WriteLine($"You have rolled Snake Eyes! {resultdice1}-{resultdice2}");
    }
    else if ((resultdice1 + resultdice2) == 3)
    {
        Console.WriteLine( $"You have rolled {resultdice1} and {resultdice2}! That's an Ace Deuce! ");
        Console.WriteLine($"This roll is a Craps!");
    }
    if ((resultdice1 == 6) && (resultdice2 == 6))
    {
        Console.WriteLine($"You have rolled Box Cars! {resultdice1}-{resultdice2}");
    }
    else if ((resultdice1 + resultdice2) == 7 || (resultdice1 + resultdice2) == 11)
    {
        Console.WriteLine($"{resultdice1 + resultdice2}!!! Do you know what this means?");
        Console.WriteLine($"This roll is a Win!");
    }

    else
    {
        Console.WriteLine("");
    }

}
static bool istwentysided(int sides)
{
    if (sides == 20)
    {
        return true;
    }
    else
    {
        return false;
    }
}
static void specialTwentyOutput(int resultdice1, int resultdice2)
{
    if ((resultdice1 == 20) || (resultdice2 == 20) || (resultdice1 + resultdice2) == 20)
    {
        Console.WriteLine($"You have rolled a Crit! {resultdice1}-{resultdice2}");
    }
    else
    {
        Console.WriteLine("");
    }

}


