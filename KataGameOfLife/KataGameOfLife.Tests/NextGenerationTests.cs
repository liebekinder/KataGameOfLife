using FluentAssertions;

namespace KataGameOfLife.Tests;

public class NextGenerationTests
{
    [Fact]
    public void NextGeneration_GivenEmptyGrid_ShouldREturnEmptyGrid()
    {
        // Arrange
        var initialGrid = Grid.Empty();

        // Act
        var actualGrid = initialGrid.NextGeneration();

        // Assert
        var expectedGrid = Grid.Empty();
        actualGrid.Should().BeEquivalentTo(expectedGrid);
    }
}