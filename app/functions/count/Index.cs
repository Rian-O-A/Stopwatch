using System.Reflection.Metadata;

class Count{

    public static void Start(int bruteTime, string type){

        int time = type == "s" ? bruteTime * CONSTANTS.Secund_Multiplier : bruteTime *  CONSTANTS.Minut_Multiplier;

        int currentTime = 0;
                while(currentTime != time){
                    
                    Console.Clear();
                    currentTime++;
                    Console.WriteLine("🕒 "+ currentTime);
                    Thread.Sleep(1000);
                    
                }
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Stopwatch finished!");
                Thread.Sleep(2500);	
                Menu.Start();

    }
}