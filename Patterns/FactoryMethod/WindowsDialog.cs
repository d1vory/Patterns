namespace Patterns.FactoryMethod;

public class WindowsDialog: Dialog
{
    protected override IButton CreateButton()
    {
        return new WindowsButton();
    }
}