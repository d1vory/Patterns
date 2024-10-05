namespace Patterns.Builder;

public class CarBuilder: IBuilder
{
    // Усі конкретні будівельники реалізують загальний інтерфейс по-
// своєму.
    private Car _car;
    
    public CarBuilder()
    {
        _car = new Car();
    }
    
    public void Reset()
    {
        _car = new Car();
    }

    public void SetSeats(int number)
    {
        _car.Seats = number;
    }

    public void SetEngine(string engine)
    {
        _car.Engine = engine;
    }

    public void SetTripComputer()
    {
        _car.TripComputer = true;
    }

    public void SetGPS()
    {
        _car.GPS = true;
    }

    public Car GetResult()
    {
        return _car;
    }
}