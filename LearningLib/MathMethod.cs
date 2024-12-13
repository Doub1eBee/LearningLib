namespace LearningLib;

public class MathMethod
{
    static public int Add(int a, int b)
    {
        return a + b;
    }
    static public int Multiply(int a, int b)
    {
        return a * b;
    }
    
    static protected void ShowStart(int time)
    {
        Console.WriteLine($"Show starts in {time} minutes");
    }
}
