namespace Patterns.Builder;

public class Director
{
    // Директор знає, в якій послідовності потрібно змушувати
// працювати будівельника, щоб отримати ту чи іншу версію
// продукту. Зауважте, що директор працює з будівельником через
// загальний інтерфейс, завдяки чому він не знає тип продукту,
// який виготовляє будівельник.

    public static IBuilder MakeSUV(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(5);
        builder.SetEngine("2l diesel");
        builder.SetGPS();
        builder.SetTripComputer();
        return builder;
    }

    public static IBuilder MakeSportsCar(IBuilder builder)
    {
        builder.Reset();
        builder.SetSeats(2);
        builder.SetEngine("Turbo v8");
        return builder;
    }
}