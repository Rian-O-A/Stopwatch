
public class OptionMenu{
    public static bool Check(char option)
    {
        if (CONSTANTS.OPC.Contains(option))
        {
            return true;
        }
        else
        {
            return false;
        }
    }

}
