using FluentAssertions;

namespace KataGameOfLife.Tests;

public class NextGenerationTests
{
    [Fact]
    public void NextGeneration_GivenEmptyGrid_ShouldREturnEmptyGrid()
    {
        // Arrange
        var initialGrid = Grid.EmptyGrid();

        // Act
        var actualGrid = initialGrid.NextGeneration();

        // Assert
        var expectedGrid = Grid.EmptyGrid();
        actualGrid.Should().BeEquivalentTo(expectedGrid);
    }

    [Fact]
    public void NextGeneration_GivenGridWithOneAliveCell_ThenCellShouldDie()
    {
        // Arrange
        var initialGrid = Grid.NewGrid(height: 1, width: 1);
        initialGrid.CreateCell(alive: true, x: 0, y: 0);

        // Act
        var actualGrid = initialGrid.NextGeneration();

        // Assert
        var expectedGetCellStatus = actualGrid.GetCell(x: 0, y: 0);
        expectedGetCellStatus.Should().BeFalse();
    }

    [Fact]
    public void NextGeneration_GivenOneAliveAndTwoAliveNeighbourg_ShouldSurvive()
    {
        // Arrange
        var initialGrid = Grid.NewGrid(height: 3, width: 1);
        initialGrid.CreateCell(alive: true, x: 0, y: 0);
        initialGrid.CreateCell(alive: true, x: 0, y: 1);
        initialGrid.CreateCell(alive: true, x: 0, y: 2);

        // Act
        var actualGrid = initialGrid.NextGeneration();

        // Assert
        var expectedGetCellStatus = actualGrid.GetCell(x: 0, y: 1);
        expectedGetCellStatus.Should().BeTrue();
    }
}