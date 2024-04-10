
public class PreStart()
{
     public static void Start(int bruteTime, string type){

        Console.Clear();
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("Ready...");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("Set...");
        Thread.Sleep(1000);
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("Go...");
        Console.ResetColor();
        Thread.Sleep(2500);
        Count.Start(bruteTime, type);

    }
}