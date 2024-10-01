namespace Patterns.FactoryMethod;

public class WebDialog: Dialog
{
    protected override IButton CreateButton()
    {
        return new HtmlButton();
    }
}