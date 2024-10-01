namespace Patterns.FactoryMethod;

public class FactoryMethodTesting
{
    public static void RunTest()
    {
        var windowsDialog = new WindowsDialog();
        windowsDialog.Render();
        
        Console.WriteLine("===============================================");

        var webDialog = new WebDialog();
        webDialog.Render();
    }
    
}