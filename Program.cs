using System;

namespace XO
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("X-O\n");
            game gg = new game();
            Console.WriteLine(" " + 7 + " | " + 8 + " | " + 9);
            Console.WriteLine(" ---------");
            Console.WriteLine(" " + 4 + " | " + 5 + " | " + 6);
            Console.WriteLine(" ---------");
            Console.WriteLine(" " + 1 + " | " + 2+ " | " + 3);
            Boolean winner = true;

            do
            {
                Console.WriteLine("\n X Select number : ");
                String num_p1 = Console.ReadLine();
                gg.set_num_p1(num_p1);
                gg.dislay_game();
                winner = gg.checkwinner();
                if (winner ==false)
                {
                    Console.WriteLine("\nX is winner :)");
                    break;
                }
                Console.WriteLine("\n O Select number : ");
                String num_p2 = Console.ReadLine();
                gg.set_num_p2(num_p2);
                gg.dislay_game();
                winner = gg.checkwinner2();
                if (winner == false)
                {
                    Console.WriteLine("\nO is winner :)");
                    break;
                }
            } while (winner);
        }
    }
}
