
public class MatrixTraverserTests
{
    public bool RunTests()
    {
        int[] matrix = {
            1, 2, 3, 4, 5,
            6, 7, 8, 9, 10,
            11, 12, 13, 14, 15,
            16, 17, 18, 19, 20,
            21, 22, 23, 24, 25
        };

        MatrixTraverser matrixTraverser = new MatrixTraverser(matrix);
        try
        {
            Console.WriteLine("Traversal Output: " + matrixTraverser.Traversal(5, 5));
            return true;
        }
        
        catch (Exception)
        {
            return false; 
        }
    }
}