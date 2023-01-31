namespace Matrices.lib;

public class Matrix3x3 : SquareMatrix
{
    public Matrix3x3() : base(3) {}

    public override double GetDeterminant()
    {
        var det = 0.0;

        for (var i = 0; i < 3; i++)
        {
            det += Data[0, i] * GetInverseValue(0, i);
        }

        return det;
    }

    private double GetInverseValue(int row, int col)
    {
        var coords = new[]
        {
            (row + 1, col + 1),
            (row + 2, col + 1),
            (row + 1, col + 2),
            (row + 2, col + 2)
        };

        for (var i = 0; i < coords.Length; i++)
        {
            if (coords[i].Item1 > 2)
                coords[i].Item1 = 0;
            if (coords[i].Item2 > 2)
                coords[i].Item2 = 0;
        }

        var val = Data[coords[0].Item1, coords[0].Item2] * Data[coords[3].Item1, coords[3].Item2] + Data[coords[1].Item1, coords[1].Item2] * Data[coords[2].Item1, coords[2].Item2];

        return val;
    }
    
    public override SquareMatrix GetInverse()
    {
        var mat = new Matrix3x3();

        var det = GetDeterminant();
        if (det == 0)
            throw new Exception("Matrix is singular, there is not an inverse as the determinant resulted in 0.");
        
        for (var r = 0; r < 3; r++)
        {
            for (var c = 0; c < 3; c++)
            {
                mat[r, c] = GetInverseValue(r, c);
                if (r % 2 != 0 || c % 2 != 0)
                    mat[r, c] = -mat[r, c];
            }
        }

        mat = (Matrix3x3) mat.GetTransposed();

        mat = (Matrix3x3) (mat * (1 / det));

        return mat;
    }
}
