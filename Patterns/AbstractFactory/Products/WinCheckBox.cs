namespace Patterns.AbstractFactory.Products;

public class WinCheckBox: ICheckBox
{
    public string Render()
    {
        return "win checkbox render";

    }

    public void OnCheck()
    {
        Console.WriteLine("win check");
    }
}