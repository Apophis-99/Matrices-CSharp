namespace Matrices.lib;

public class Matrix2x2 : SquareMatrix
{
    public Matrix2x2() : base(2) {}

    public override double GetDeterminant()
    {
        return Data[0, 0] * Data[1, 1] - Data[0, 1] * Data[1, 0];
    }
    public override SquareMatrix GetInverse()
    {
        var mat = this;

        var det = GetDeterminant();
        if (det == 0)
            throw new Exception("Matrix is singular, there is not an inverse as the determinant resulted in 0.");
        
        (mat[0, 0], mat[1, 1]) = (mat[1, 1], mat[0, 0]);
        mat[0, 1] = -mat[0, 1];
        mat[1, 0] = -mat[1, 0];

        mat = (Matrix2x2) (mat * (1 / det));

        return mat;
    }
}
