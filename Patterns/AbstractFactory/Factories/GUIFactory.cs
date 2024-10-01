using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory.Factories;

public interface IGuiFactory
{
    public IButton CreateButton();
    public ICheckBox CreateCheckBox();


}