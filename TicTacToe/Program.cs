using System;

namespace TicTacToe
{
    internal class Program
    {
        // the playfield
        static char[,] playField =
        {
            {'1','2','3'},
            {'4','5','6'},
            {'7','8','9'},
        };

        //the player
        static void Main(string[] args)
        {
            int player = 2; //Player 1 starts
            int input = 0;
            bool inputCorrect = true;

            SetField();
            Console.ReadKey();


            do
            {
                if (player == 2)
                    player = 1;
                else if (player == 1)
                    player = 2;


            } while (true);

        }

        public static void SetField()
        {
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[0, 0], playField[0, 1], playField[0, 2]);
            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[1, 0], playField[1, 1], playField[1, 2]);            Console.WriteLine("_____|_____|_____");
            Console.WriteLine("     |     |     ");
            Console.WriteLine("  {0}  |  {1}  |  {2}", playField[2, 0], playField[2, 1], playField[2, 2]);
            Console.WriteLine("     |     |     ");
        }
    }
}
