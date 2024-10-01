using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories;

public class MacFactory: IGuiFactory
{
    public IButton CreateButton()
    {
        return new MacButton();
    }

    public ICheckBox CreateCheckBox()
    {
        return new MacCheckBox();
    }
}