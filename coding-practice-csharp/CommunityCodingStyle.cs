namespace coding_practice_csharp;

public class CommunityCodingStyle
{
    public static int classStaticValue = 2;

    private int fieldValue;

    public CommunityCodingStyle(int val)
    {
        fieldValue = val;
    }

    public void javaStyleMethod() {
    }

    public void LocalVariableNaming()
    {
        int Variable1 = 3;
        
        Console.WriteLine("The value is " + Variable1);
    }
}
