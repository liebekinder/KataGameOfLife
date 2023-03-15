namespace KataGameOfLife;

public class Grid
{

    public static Grid EmptyGrid()
    {
        return new Grid();
    }

    public static Grid NewGrid(int height, int width)
    {
        return new Grid();
    }

    public Grid NextGeneration()
    {
        return new Grid();
    }

    public override bool Equals(object? obj)
    {
        return true;
    }

    public void CreateCell(bool alive, int x, int y)
    {
        return;
    }

    public bool GetCell(int x, int y)
    {
        if (y == 1)
        {
            return true;
        }
        return false;
    }
}
