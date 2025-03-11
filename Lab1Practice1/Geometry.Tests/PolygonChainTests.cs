using FluentAssertions;

namespace Geometry.Tests;
public class PolygonChainTests
{
    [Fact]
    public void Intialization_with_point_0_2__6_5()
    {
        var polygonalChain = new PolygonalChain(new(0, 2), new(6, 5));
        polygonalChain.Start.X.Should().Be(0);
        polygonalChain.Start.Y.Should().Be(2);
        polygonalChain.End.X.Should().Be(6);
        polygonalChain.End.Y.Should().Be(5);
    }

    [Fact]
    public void AddMidpoint_4_5()
    {
        var polygonalChain = new PolygonalChain(new(0, 2), new(6, 5));
        polygonalChain.AddMidpoint(new(4, 5));
        polygonalChain.ToString().Should().Be("(0,2),(4,5),(6,5)");
    }

    [Fact]
    public void Move_should_be_4_5__8_8__10_8()
    {
        var polygonalChain = new PolygonalChain(new(0, 2), new(6, 5));
        polygonalChain.AddMidpoint(new(4, 5));
        polygonalChain.Move(4, 3);
        polygonalChain.ToString().Should().Be("(4,5),(8,8),(10,8)");
    }

    [Fact]
    public void Length_should_be_10()
    {
        var polygonalChain = new PolygonalChain(new(2, 2), new(2, 2));
        polygonalChain.AddMidpoint(new(5, 6));
        polygonalChain.Length.Should().Be(10);
    }
}
