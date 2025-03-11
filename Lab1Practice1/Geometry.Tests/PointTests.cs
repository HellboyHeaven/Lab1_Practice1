using FluentAssertions;

namespace Geometry.Tests;

public class PointTests
{
    [Fact]
    public void Initialization_with_different_parameters()
    {
        var point_1 = new Point();
        point_1.X.Should().Be(0);
        point_1.Y.Should().Be(0);

        var point_2 = new Point(5);
        point_2.X.Should().Be(5);
        point_2.Y.Should().Be(5);

        var point_3 = new Point(6, 7);
        point_3.X.Should().Be(6);
        point_3.Y.Should().Be(7);
    }

    [Fact]
    public void Move_should_return_7_10()
    {
        var point = new Point(6, 7);
        point.Move(1, 3);

        point.X.Should().Be(7);
        point.Y.Should().Be(10);
    }


    [Fact]
    public void Distance_should_be_5()
    {
        var point = new Point(3, 4);
        var distance = point.Distance();

        distance.Should().Be(5);
    }
}
