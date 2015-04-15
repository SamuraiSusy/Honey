using System;

namespace RunMyBadger
{
#if WINDOWS || XBOX
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main(string[] args)
        {
            using (Level1 game = new Level1())
            {
                game.Run();
            }
        }
    }
#endif
}

