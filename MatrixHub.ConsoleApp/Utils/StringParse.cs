namespace MatrixHub.ConsoleApp.Utils;

public static class StringParse
{
    public static uint ToUInt(string s)
    {
        if (!uint.TryParse(s, out var result))
            throw new ArgumentException($"'{s}' is not a valid uint.");
        return result;
    }

    public static int ToInt(string s)
    {
        if (!int.TryParse(s, out var result))
            throw new ArgumentException($"'{s}' is not a valid int.");
        return result;
    }
}