using System;

namespace Myprogram1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool playagain = true;
            String player;
            String computer;
            String answer;

            while (playagain)
            {
                player = "";
                computer = "";
                answer = "";

                while (player != "ROCK" && player != "PAPER" && player != "SCISSORS")
                {
                    Console.WriteLine("Enter rock, paper , or scissors: ");
                    player = Console.ReadLine();
                    player = player.ToUpper();
                }

                switch (random.Next(1, 4))
                {
                    case 1:
                        computer = "ROCK";
                        break;
                        case 2:
                        computer = "PAPER";
                        break ;
                    case 3:
                        computer = "SCISSORS";
                        break;
                }
                Console.WriteLine("Player : " +player);
                Console.WriteLine("Computer : " + computer);

                switch (player)
                {
                    case "ROCK":
                        if (computer == "ROCK")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "PAPER")
                        {
                            Console.WriteLine("You Lose! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win! ");
                        }
                        break;
                    case "PAPER":
                        if (computer == "PAPER")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "SCISSORS")
                        {
                            Console.WriteLine("You Lose! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win! ");
                        }
                        break ;
                    case "SCISSORS":
                        if (computer == "SCISSORS")
                        {
                            Console.WriteLine("It's a draw");
                        }
                        else if (computer == "ROCK")
                        {
                            Console.WriteLine("You Lose! ");
                        }
                        else
                        {
                            Console.WriteLine("You Win! ");
                        }
                        break;

                }

                Console.WriteLine("Would you like to play again (Y/N): ");
                answer = Console.ReadLine();
                answer = answer.ToUpper();

                if (answer == "Y")
                {
                    playagain = true;
                }
                else
                {
                    playagain = false; 
                }

            }

            Console.WriteLine("thx for playing: ");


            Console.ReadKey();

        }
        

        
        
    }
}

