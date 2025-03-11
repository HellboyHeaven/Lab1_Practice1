using FluentAssertions;

namespace Geometry.Tests;
public class SegmentTests
{
    [Fact]
    public void Intialization_with_point_0_2__6_5()
    {
        var segment = new Segment(new(0,2), new(6, 5));
        segment.Start.X.Should().Be(0);
        segment.Start.Y.Should().Be(2);
        segment.End.X.Should().Be(6);
        segment.End.Y.Should().Be(5);
    }
    [Fact]
    public void Distance_should_be_5()
    {
        var segment = new Segment(new(2, 2), new(6, 5));
        segment.Length.Should().Be(5);
    }
}
