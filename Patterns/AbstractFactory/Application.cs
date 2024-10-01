using Patterns.AbstractFactory.Factories;
using Patterns.AbstractFactory.Products;

namespace Patterns.AbstractFactory;

public class Application
{
    public IGuiFactory Factory;
    public IButton Button;
    public ICheckBox CheckBox;

    public Application(IGuiFactory factory)
    {
        Factory = factory;
        Button = factory.CreateButton();
        CheckBox = factory.CreateCheckBox();
    }

    public void Render()
    {
        Console.WriteLine(Button.Render());
        Console.WriteLine(CheckBox.Render());
    }
    
}