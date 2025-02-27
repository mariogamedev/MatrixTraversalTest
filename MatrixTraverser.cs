using System.Text;

public class MatrixTraverser
{
    private int _top;
    private int _bottom;
    private int _left;
    private int _right;
    private int[] _matrix; 

    public MatrixTraverser(int[] matrix)
    {
        _matrix = matrix; 
    }

    private void InitializeBoundaries(int rows, int columns)
    {
        _top = 0;
        _bottom = rows - 1;
        _left = 0;
        _right = columns - 1;
    }

    public string Traversal(int rows, int columns)
    {
        InitializeBoundaries(rows, columns);
        StringBuilder result = new StringBuilder();

        while (_top <= _bottom && _left <= _right)
        {
            TraverseLeftToRight(result, columns);
            TraverseTopToBottom(result, columns);
            if (_top <= _bottom)
            {
                TraverseRightToLeft(result, columns);
            }
            if (_left <= _right)
            {
                TraverseBottomToTop(result, columns);
            }
        }

        // Use the ResultFormatter to clean up the result
        return ResultFormatter.RemoveTrailingCharacters(result.ToString());
    }

    private void TraverseLeftToRight(StringBuilder result, int columns)
    {
        for (int i = _left; i <= _right; i++)
        {
            result.Append(_matrix[_top * columns + i] + ", ");
        }
        _top++;
    }

    private void TraverseTopToBottom(StringBuilder result, int columns)
    {
        for (int i = _top; i <= _bottom; i++)
        {
            result.Append(_matrix[i * columns + _right] + ", ");
        }
        _right--;
    }

    private void TraverseRightToLeft(StringBuilder result, int columns)
    {
        for (int i = _right; i >= _left; i--)
        {
            result.Append(_matrix[_bottom * columns + i] + ", ");
        }
        _bottom--;
    }

    private void TraverseBottomToTop(StringBuilder result, int columns)
    {
        for (int i = _bottom; i >= _top; i--)
        {
            result.Append(_matrix[i * columns + _left] + ", ");
        }
        _left++;
    }

    public static void Main()
    {
        MatrixTraverserTests tests = new MatrixTraverserTests();
        bool allTestsPassed = tests.RunTests();
        
        Console.WriteLine($"All tests passed: {allTestsPassed}");    }
} 