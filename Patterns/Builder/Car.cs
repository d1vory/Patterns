namespace Patterns.Builder;

public class Car
{
    // Автомобілі можуть відрізнятися комплектацією: типом
    // двигуна, кількістю сидінь, можуть мати або не мати GPS і
    // систему навігації тощо. Крім того, автомобілі можуть бути
    // міськими, спортивними або позашляховиками.
    public int Seats { get; set; }
    public string Engine { get; set; }
    public bool TripComputer { get; set; } = false;
    public bool GPS { get; set; } = false;
    
}

public class CarManual
{
    // Посібник користувача для даної конфігурації автомобіля.

    public string Seats { get; set; }
    public string Engine { get; set; }
    public string TripComputer { get; set; } = "Trip computer is not supported";
    public string GPS { get; set; } = "gps is not supported";

}