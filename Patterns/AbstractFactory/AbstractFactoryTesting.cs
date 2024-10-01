using Patterns.AbstractFactory.Factories;

namespace Patterns.AbstractFactory;

public class AbstractFactoryTesting
{
    public static void TestAbstractFactory()
    {
        var winFactory = new WinFactory();
        var macFactory = new MacFactory();

        var appWin = new Application(winFactory);
        var appMac = new Application(macFactory);
        
        appWin.Render();
        appMac.Render();


    }
}