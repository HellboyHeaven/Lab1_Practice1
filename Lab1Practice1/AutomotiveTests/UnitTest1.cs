using Automotive;
using FluentAssertions;

namespace AutomotiveTests;

public class CarTests
{
    [Fact]
    public void Intialization_with_different_params()
    {
        Action action_1 = () => new Car("", 0, 0);
        Action action_2 = () => new Car("Tayota", 0, 0);
        Action action_3 = () => new Car("Tayota", 100, 0);
        var car = new Car("Tayota", 100, 30);

        action_1.Should().Throw<ArgumentException>();
        action_2.Should().Throw<ArgumentOutOfRangeException>();
        action_3.Should().Throw<ArgumentOutOfRangeException>();

        car.Should().NotBeNull();
        car.Brand.Should().Be("Toyota");
        car.TankCapacity.Should().Be(100);
        car.FuelConsumptionPer100Km.Should().Be(30);
    }
}
