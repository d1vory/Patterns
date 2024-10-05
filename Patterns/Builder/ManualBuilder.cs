namespace Patterns.Builder;

public class ManualBuilder:IBuilder
{
    // На відміну від інших породжувальних патернів, де продукти
// мають бути частиною одніє ієрархії класів або слідувати
// загальному інтерфейсу, будівельники можуть створювати
// абсолютно різні продукти, які не мають спільного предка.
    private CarManual _carManual;

    public ManualBuilder()
    {
        _carManual = new CarManual();
    }


    public void Reset()
    {
        _carManual = new CarManual();
    }

    public void SetSeats(int number)
    {
        _carManual.Seats = $"This vehicle has {number} seats";
    }

    public void SetEngine(string engine)
    {
        _carManual.Engine = $"This vehicale has {engine} engine";
    }

    public void SetTripComputer()
    {
        _carManual.TripComputer = "some info about computer";
    }

    public void SetGPS()
    {
        _carManual.GPS = "Some info about gps";
    }

    public CarManual GetResult()
    {
        return _carManual;
    }
}