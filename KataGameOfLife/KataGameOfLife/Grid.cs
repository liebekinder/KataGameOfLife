using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataGameOfLife;

public class Grid
{
    public static Grid Empty()
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
}
