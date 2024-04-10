using System.IO.Pipes;

public class Menu{

    public static void Start(){
         Console.Clear();
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("╔═════════════════════════╗");
        Console.WriteLine("║        Stopwatch        ║");
        Console.WriteLine("╚═════════════════════════╝\n");
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Choose the time unit to count:");
        Console.WriteLine("S - Seconds (Example: 1s)");
        Console.WriteLine("M - Minutes (Example: 1m)");
        Console.WriteLine("0 - Exit\n");
        Console.ResetColor();
        Console.Write(">>> ");
        Tuple<char, int> data = Input.GetInput(); 

        if(data == null){
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n❌ Invalid option. Please choose again.");
            Thread.Sleep(2500);
            Start();
        }else if(data.Item1 == '0'){
            Console.Clear();
            Console.WriteLine("Bye!");
            Environment.Exit(0);

        }

        PreStart.Start(data.Item2, data.Item1.ToString());

    }
}