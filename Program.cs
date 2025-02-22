var date = DateTime.Now.ToString();
string? name = GetName();
static string? GetName()
{
    Console.WriteLine("Please type your name");

    var name = Console.ReadLine();
    return name;
}

string Menu(string? name)
{
    Console.WriteLine("-------------------------------");
    Console.WriteLine($"Hello {name}, It's {date}. Welcome!!");
    Console.WriteLine("\n");
    Console.WriteLine("What game would you like to play today? Choose from below options");
    Console.WriteLine("A - Addition");
    Console.WriteLine("S - Subtraction");
    Console.WriteLine("M - Multiplication");
    Console.WriteLine("D - Division");
    Console.WriteLine("Q - Quit the game");
    Console.WriteLine("-------------------------------");

    var gameSelected = Console.ReadLine();

    switch (gameSelected.Trim().ToLower())
    {
        case "a":
            AdditionGame();
            break;
        case "s":
            SubtractionGame();
            break;
        case "m":
            MultiplicationGame();
            break;
        case "d":
            DivisionGame();
            break;
        case "q":
            Console.WriteLine("Goodbye!");
            Environment.Exit(1);
            break;
        default:
            Console.WriteLine("Invalid Input");
            Environment.Exit(1);
            break;
    }

    return gameSelected;
}
string? gameSelected = Menu(name);


void DivisionGame()
{
    throw new NotImplementedException();
}

void MultiplicationGame()
{
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;
    for (int i = 0; i < 4; i++)
    {
        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);
        Console.WriteLine($"{firstNumber} * {secondNumber} = ?");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber * secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer was incorrect :( ");
        }

        if (i == 3)
        {
            Console.WriteLine($"Your score is {score}");
        }
    }
}

void SubtractionGame()
{
    Random random = new Random();
    int firstNumber;
    int secondNumber;
    int score = 0;
    for (int i = 0; i < 4; i++)
    {
        firstNumber = random.Next(1, 10);
        secondNumber = random.Next(1, 10);
        Console.WriteLine($"{firstNumber} - {secondNumber} = ?");
        var result = Console.ReadLine();
        if (int.Parse(result) == firstNumber - secondNumber)
        {
            Console.WriteLine("Your answer was correct!");
            score++;
        }
        else
        {
            Console.WriteLine("You answer was incorrect :( ");
        }

        if (i == 3)
        {
            Console.WriteLine($"Your score is {score}");
        }
    }
}

 void AdditionGame()
{ 
    Random random = new Random();
        int firstNumber;
        int secondNumber;
        int score = 0;
        for (int i = 0; i < 4; i++)
        {
            firstNumber = random.Next(1, 10);
            secondNumber = random.Next(1, 10);
            Console.WriteLine($"{firstNumber} + {secondNumber} = ?");
            var result = Console.ReadLine();
            if (int.Parse(result) == firstNumber + secondNumber)
            {
                Console.WriteLine("Your answer was correct!");
                score++;
            }
            else
            {
                Console.WriteLine("You answer was incorrect :( ");
            }

            if (i == 3)
            {
                Console.WriteLine($"Your score is {score}");
            }
        }
 }

