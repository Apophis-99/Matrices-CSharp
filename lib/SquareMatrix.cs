namespace Matrices.lib;

public abstract class SquareMatrix : Matrix
{
    protected SquareMatrix(int dim) : base(dim, dim)
    {}

    public abstract double GetDeterminant();
    public abstract SquareMatrix GetInverse();

    public SquareMatrix GetTransposed()
    {
        var temp = this;

        for (var r = 0; r < Rows; r++)
        {
            for (var c = 0; c < Cols; c++)
            {
                temp.Data[r, c] = Data[c, r];
            }
        }
        
        return temp;
    }
    
    public static Matrix operator /(SquareMatrix a, SquareMatrix b)
    {
        return a * b.GetInverse();
    }
}
