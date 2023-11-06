using System.Collections.Generic;

public static class SaddlePoints
{
    public static IEnumerable<(int, int)> Calculate(int[,] matrix)
    {
        var rows_length = matrix.GetLength(0);
        var cols_length = matrix.GetLength(1);

        int[] max_in_row = new int[rows_length];
        int[] min_in_col = new int[cols_length];
        
        int max, min;
        for (int i = 0; i < rows_length; ++i)
        {
            max = matrix[i  , 0];
            for (int j = 0; j < cols_length; ++j)
            {
                if(matrix[i, j] > max){
                    max = matrix[i, j];
                }
            }
            max_in_row[i] = max;
        }

        for(int j = 0; j < cols_length; ++j)
        {
            min = matrix[0, j];
            for (int i = 0; i < rows_length; ++i)
            {
                if(matrix[i, j] < min){
                    min = matrix[i, j];
                }
            }
            min_in_col[j] = min;
        }

        for(int i = 0; i < rows_length; ++i)
        {
            for(int j = 0; j < cols_length; ++j)
            {
                if(matrix[i, j] >= max_in_row[i] && matrix[i, j] <= min_in_col[j])
                    yield return (i+1, j+1);
            }
        }
    }
}
