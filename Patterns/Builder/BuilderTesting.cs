namespace Patterns.Builder;

public class BuilderTesting
{
    public static void TestBuilder()
    {
        var carBuilder = new CarBuilder();
        var carManualBuilder = new ManualBuilder();

        Director.MakeSUV(carBuilder);
        var suvCar = carBuilder.GetResult();
        Director.MakeSUV(carManualBuilder);
        var suvmanual = carManualBuilder.GetResult();

        
        Director.MakeSportsCar(carBuilder);
        var sportsCar = carBuilder.GetResult();
        Director.MakeSportsCar(carManualBuilder);
        var sportsCarmanual = carManualBuilder.GetResult();
    }
}