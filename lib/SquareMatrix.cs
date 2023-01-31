namespace Matrices.lib;

public abstract class SquareMatrix : Matrix
{
    protected SquareMatrix(int dim) : base(dim, dim)
    {}

    public SquareMatrix GetIdentity()
    {
        var mat = this;
        for (var r = 0; r < Rows; r++)
        {
            for (var c = 0; c < Cols; c++)
            {
                mat[r, c] = 0;
            }
        }

        for (var i = 0; i < Rows; i++)
        {
            mat[i, i] = 1;
        }

        return mat;
    }

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
