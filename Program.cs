using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RockPaper
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputPlayer, inputCPU;
            int randomInt;
            
            bool playAgain = true;

            while (playAgain)
            {
                int scoreplayer = 0;
                int scoreCPU = 0;


                while (scoreplayer < 3 && scoreCPU < 3)
                {

                    Console.Write("Choose Between ROCK, PAPER and SCISSORS:     ");
                    inputPlayer = Console.ReadLine();
                    inputPlayer = inputPlayer.ToUpper();

                    Random rnd = new Random();

                    randomInt = rnd.Next(1, 4);

                    switch (randomInt)
                    {
                        case 1:
                            inputCPU = "ROCK";
                            Console.WriteLine("Computer Choose ROCK");
                            if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scoreplayer++;
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("COMPUTER WINS!!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 2:
                            inputCPU = "PAPER";
                            Console.WriteLine("Computer Choose PAPER");
                            if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scoreplayer++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("COMPUTER WINS!!!\n\n");
                                scoreCPU++;
                            }
                            break;
                        case 3:
                            inputCPU = "SCISSORS";
                            Console.WriteLine("Computer Choose SCISSORS");
                            if (inputPlayer == "SCISSORS")
                            {
                                Console.WriteLine("DRAW!!!\n\n");
                            }
                            else if (inputPlayer == "PAPER")
                            {
                                Console.WriteLine("COMPUTER WINS!!!\n\n");
                                scoreCPU++;
                            }
                            else if (inputPlayer == "ROCK")
                            {
                                Console.WriteLine("PLAYER WINS!!!\n\n");
                                scoreplayer++;
                            }
                            break;
                        default:
                            Console.WriteLine("Invalid Entry! ");
                            break;
                    }

                    Console.WriteLine("\n\nSCORES:\tPLAYER:\t{0}\tCPU:\t{1}", scoreplayer, scoreCPU);

                }
                if (scoreplayer == 3)
                {
                    Console.WriteLine("PLAYER WON!!!");
                }
                else if (scoreCPU == 3)
                {
                    Console.WriteLine("COMPUTER WON!!!");
                }
                else
                {

                }

                Console.WriteLine("Do you want to play again?(y/n)");
                string loop = Console.ReadLine();
                if (loop == "y")
                {
                    playAgain = true;
                    Console.Clear();
                }
                else if (loop == "n")
                {
                    playAgain = false;
                }
                else
                {

                }


            }

        }

    }
}
