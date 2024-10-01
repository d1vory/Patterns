namespace Patterns.FactoryMethod;

public class WindowsButton: IButton
{
    public string Render()
    {
        return "Windows render";
    }

    public void OnClick()
    {
        Console.WriteLine("Windows on click");
    }
}