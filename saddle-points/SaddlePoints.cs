using System.Collections.Generic;
using System.Linq;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var rows = Enumerable.Range(0, matrix.GetLength(0));
        var cols = Enumerable.Range(0, matrix.GetLength(1));

        

        var maxInRows = rows.Select(r => cols.Max(c => matrix[r, c]));
        var minInCols = cols.Select(c => rows.Min(r => matrix[r, c]));

        return from r in rows
               from c in cols
               where matrix[r, c] == maxInRows.ElementAt(r)
                   && matrix[r, c] == minInCols.ElementAt(c)
               select (r + 1, c + 1);
    }
}
