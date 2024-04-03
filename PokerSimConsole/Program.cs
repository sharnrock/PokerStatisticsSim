

using PokerSimConsole;

class TestClass
{
    private const int EXIT_SUCCESS = 0;

    static int Main(string[] args)
    {
        foreach (var arg in args)
        {
            if (arg == "-h" || arg == "--help")
            {
                ShowHelp();
            }
            else if (arg == "-o")
            {
                Console.WriteLine("Count outs");
            }
            else if (arg == "-s")
            {
                Console.WriteLine("Show statistics");
            }
            else
            {
                Console.WriteLine("Hello, World!");
            }
        }

        return EXIT_SUCCESS;
    }

    private static void ShowHelp()
    {
        Console.WriteLine("-h is help\n");
        Console.WriteLine("-o is outs\n");
        Console.WriteLine("-s is statistics\n");
    }
}
