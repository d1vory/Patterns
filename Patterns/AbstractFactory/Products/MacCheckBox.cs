namespace Patterns.AbstractFactory.Products;

public class MacCheckBox: ICheckBox
{
    public string Render()
    {
        return "Mac checkbox render";

    }

    public void OnCheck()
    {
        Console.WriteLine("mac check");
    }
}