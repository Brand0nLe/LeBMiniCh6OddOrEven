//Cuong Brandon Le
//10-20-22
//Mini Challenge 6 - Odd or Even
//Project will take user's input and print into the terminal whether
//the number is even or odd. It will also have an error for when user
//input is not a number. Will also have play again function.
//Peer Review: Arely Martinez - The program did what it was intended. The number i input was declared as odd or even.
//There was also data confirmation for both if it was a vaild entry when i first entered in a number.
//I like how after the second time i inputed a invaild option it returned me to the begining of the program. However there was a small issue with data confirmation
//at the end of Brandon's work. So when i enterered in something that wasnt 'yes' or 'no' the program would make me replay the game.
//I told Brandon about the issue and he said he would correct it, which is great that he is willing to change his errors.


string userInput;
string userInputEnd;
int remainder = 0;
int total = 0;
int validNum = 0;
bool canParse;
bool playAgain = true;


while (playAgain == true)
{
    Console.Clear();
    Console.WriteLine("Hello! If you give me a number I'll tell you if it's odd or even!");
    Console.WriteLine("Enter your favorite number:");
    userInput = Console.ReadLine();
    canParse = Int32.TryParse(userInput, out validNum);

if (canParse == false)
{
    Console.WriteLine("ERROR invalid entry. You can only input numbers!");
}
else
{
    if(remainder == (validNum % 2))
    {
        Console.WriteLine($"Your number {userInput} is even.");
        Console.WriteLine("Would you like to play again? (YES/NO)");
    }
    else
    {
        Console.WriteLine($"You number {userInput} is odd");
        Console.WriteLine("Would you like to play again? (YES/NO)");
        total = (validNum % 2);
    }
}

userInputEnd = Console.ReadLine().ToUpper();

while(userInputEnd != "YES" && userInputEnd != "NO")
{
    Console.WriteLine("ERROR! Please enter YES or NO:");
    userInputEnd = Console.ReadLine().ToUpper();
}

if(userInputEnd == "YES")
{
    playAgain = true;
}
if(userInputEnd == "NO")
{
    playAgain = false;
    Console.WriteLine("It was fun while it lasted! See you next time!");
}




}


