namespace Patterns.AbstractFactory.Products;

public class MacButton: IButton
{
    public string Render()
    {
        return "Mac render";
    }

    public void OnClick()
    {
        Console.WriteLine("Mac click");
    }
}