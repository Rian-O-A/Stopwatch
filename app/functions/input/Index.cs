public class Input
{
    public static Tuple<char, int> GetInput()
    {
        string data = Console.ReadLine().ToLower();
        
        if (data.Length == 1 && data == "0")
        {
            return Tuple.Create('0', 0);
        }
        else if (data.Length > 1)
        {
            char type = data[^1]; // Usando índice inverso do C# 8 para obter o último caractere
            int time;

            if (int.TryParse(data.Substring(0, data.Length - 1), out time))
            {   
                if(OptionMenu.Check(type)){

                    return Tuple.Create(type, time);
                }
                return null;
            }
        }

        return null; // ou uma Tuple padrão se necessário
    }
}
