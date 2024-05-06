using System;

class Program
{
    static int[] snakes = { 16, 47, 49, 56, 62, 64, 87, 93, 95, 98 };
    static int[] ladders = { 1, 4, 9, 21, 28, 36, 51, 71, 80 };

    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder Game!");

        int player1Position = 0;
        int player2Position = 0;
        bool player1Turn = true;

        while (player1Position < 100 && player2Position < 100)
        {
            if (player1Turn)
            {
                player1Position = PlayTurn("Player 1", player1Position);
                player1Turn = false;
            }
            else
            {
                player2Position = PlayTurn("Player 2", player2Position);
                player1Turn = true;
            }
        }

        if (player1Position >= 100)
            Console.WriteLine("Player 1 wins!");
        else
            Console.WriteLine("Player 2 wins!");

        Console.ReadLine();
    }

    static int RollDice()
    {
        Random random = new Random();
        return random.Next(1, 7);
    }

    static int PlayTurn(string player, int position)
    {
        Console.WriteLine($"{player}'s turn:");
        Console.WriteLine("Press any key to roll the dice...");
        Console.ReadKey();

        int diceValue = RollDice();
        Console.WriteLine($"You rolled a {diceValue}");

        position += diceValue;

        if (position > 100)
        {
            position = 100 - (position - 100);
        }

        Console.WriteLine($"Current position: {position}");

        foreach (int snake in snakes)
        {
            if (position == snake)
            {
                Console.WriteLine("Oops! You got bit by a snake.");
                position -= 10;
                Console.WriteLine($"New position after snake bite: {position}");
                break;
            }
        }

        foreach (int ladder in ladders)
        {
            if (position == ladder)
            {
                Console.WriteLine("Great! You found a ladder.");
                position += 10;
                Console.WriteLine($"New position after climbing the ladder: {position}");
                break;
            }
        }

        return position;
    }
}
