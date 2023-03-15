namespace KataGameOfLife.Tests;

public class NextGenerationTests
{
    [Fact]
    public void NextGeneration_GivenEmptyGrid_ShouldREturnEmptyGrid()
    {
        // Arrange
        var initialGrid = Grid.Empty();
        var expectedGrid = Grid.Empty();

        // Act
        var actualGrid = initialGrid.NextGeneration();

        // Assert
        actualGrid.Should().BeEquivalentTo(expectedGrid);
    }
}