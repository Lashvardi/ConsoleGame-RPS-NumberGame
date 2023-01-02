
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

Console.Title = ("Random Game");
///


Console.WriteLine("Romeli Tamashis Tamashi indat: a b");
var input = Console.ReadLine();

if(input == "a")
{
    while (true)
    {
        Console.WriteLine("Choose Your Level");
        Console.WriteLine();

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("[1] -- Easy");
        Console.WriteLine("[2] -- Medium");
        Console.WriteLine("[3] -- Hard");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("4 To exit");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine();
        var playerInput = int.Parse(Console.ReadLine());
        if (playerInput == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("[→] Easy Mode");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You Have 10 Tries To get The Correct Number");
            Console.ForegroundColor = ConsoleColor.White;
            Random Rand = new Random();
            var RandomNumber = Rand.Next(0, 11);
            var leftLives = 10;
            if (leftLives <= 0)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("[X]You are Dead");
                Console.ForegroundColor = ConsoleColor.White;

                break;
            }
            for (int i = 1; i < 11; i++)
            {

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"                                              ♥Lives Left {leftLives}");
                Console.ForegroundColor = ConsoleColor.White;
                var PlayerGuess = int.Parse(Console.ReadLine());
                if (PlayerGuess != RandomNumber)
                {
                    leftLives -= 1;
                    Console.WriteLine("Try Another One!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You Are Correct The Number is {RandomNumber}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
            }
        }
        if (playerInput == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("[→] Medium Mode");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You Have 8 Tries To get The Correct Number");
            Console.ForegroundColor = ConsoleColor.White;
            Random Rand = new Random();
            var RandomNumber = Rand.Next(0, 11);
            var leftLives = 8;
            for (int i = 1; i < 21; i++)
            {
                leftLives -= 1;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"                                              ♥Lives Left {leftLives}");
                Console.ForegroundColor = ConsoleColor.White;
                var PlayerGuess = int.Parse(Console.ReadLine());

                if (leftLives <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[X]You are Dead");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                if (PlayerGuess != RandomNumber)
                {
                    leftLives -= 1;
                    Console.WriteLine("Try Another One!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You Are Correct The Number is {RandomNumber}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.WriteLine("Try Another One!");
            }
        }
        if (playerInput == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("[→] Hard Mode");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("You Have 5 Tries To get The Correct Number");
            Console.ForegroundColor = ConsoleColor.White;
            Random Rand = new Random();
            var RandomNumber = Rand.Next(0, 11);
            var leftLives = 5;
            for (int i = 1; i < 31; i++)
            {
                leftLives -= 1;

                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine($"                                              ♥Lives Left {leftLives}");
                Console.ForegroundColor = ConsoleColor.White;
                var PlayerGuess = int.Parse(Console.ReadLine());

                if (leftLives <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[X]You are Dead");
                    Console.ForegroundColor = ConsoleColor.White;

                    break;
                }
                if (PlayerGuess != RandomNumber)
                {
                    leftLives -= 1;
                    Console.WriteLine("Try Another One!");

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"You Are Correct The Number is {RandomNumber}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                }
                Console.WriteLine("Try Another One!");
            }
        }
        if (playerInput == 4)
        {
            Console.WriteLine("Bye Bye...");
            return;
        }
    }
}
else
{


    while (true)
    {
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.WriteLine("This Is Rock Paper scissors");
        Console.ForegroundColor = ConsoleColor.White;

        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("[1] -- Makrateli");
        Console.WriteLine("[2] -- Furceli");
        Console.WriteLine("[3] -- Cha");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("4 To exit");
        Console.ForegroundColor = ConsoleColor.White;

        Random Rand = new Random();
        var randomNumber = Rand.Next(1, 4);

        var playerChoise = int.Parse(Console.ReadLine());
        Console.WriteLine(randomNumber);


        if (playerChoise == 1 && randomNumber == 3)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Tkven Waaget Cha Amarcxebs Makratels");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 1 && randomNumber == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Tkven Moiget Makrateli Amarcxebs Furcels");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 2 && randomNumber == 1)
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine("Tkven Waaget Makrateli Amarcxebs Furcels");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 1 && randomNumber == 1)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Nichia");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 2 && randomNumber == 3)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Tkven Moiget Furceli Amarcxebs Chas");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 3 && randomNumber == 2)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Tkven Moiget Cha Amarcxebs Makratels");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 2 && randomNumber == 2)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Nichia");
            Console.ForegroundColor = ConsoleColor.White;

        }


        if (playerChoise == 3 && randomNumber == 1)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("Tkven Moiget Furceli Amarcxebs Chas");
            Console.ForegroundColor = ConsoleColor.White;

        }

        if (playerChoise == 3 && randomNumber == 3)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            Console.WriteLine("Nichia");
            Console.ForegroundColor = ConsoleColor.White;

        }

    }
}