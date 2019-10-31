using System;

namespace Lrouge
{
    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Run();

            Console.WriteLine("thank for playing");
            Console.Run();
        }
    }
}
