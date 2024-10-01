namespace Patterns.FactoryMethod;

public class HtmlButton: IButton
{
    public string Render()
    {
        return "html render";
    }

    public void OnClick()
    {
        Console.WriteLine("html clicked");
    }
}