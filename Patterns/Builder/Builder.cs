namespace Patterns.Builder;

public interface IBuilder
{
    // Інтерфейс будівельників оголошує всі можливі етапи та кроки
// конфігурації продукту.
    public void Reset();
    public void SetSeats(int number);
    public void SetEngine(string engine);
    public void SetTripComputer();
    public void SetGPS();
    
}