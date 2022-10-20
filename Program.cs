//Cuong Brandon Le
//10-20-22
//Mini Challenge 6 - Odd or Even
//Project will take user's input and print into the terminal whether
//the number is even or odd. It will also have an error for when user
//input is not a number. Will also have play again function.


string playAgainDelete = "";
string userInput;
string userInputEnd;
int remainder = 0;
int total = 0;
int validNum = 0;
bool canParse;
bool playAgain = true;


while (playAgain == true)
{
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


