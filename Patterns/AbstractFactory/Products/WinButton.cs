namespace Patterns.AbstractFactory.Products;

public class WinButton: IButton
{
    public string Render()
    {
        return "Win render";
    }

    public void OnClick()
    {
        Console.WriteLine("Win click");
    }
}