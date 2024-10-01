using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories;

public class WinFactory: IGuiFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new WinCheckBox();
    }
}