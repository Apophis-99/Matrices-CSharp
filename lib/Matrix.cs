namespace Matrices.lib;

public class Matrix
{
    protected readonly int Rows;
    protected readonly int Cols;

    protected readonly double[,] Data;

    public double this[int row, int col]
    {
        get => Data[row, col];
        set => Data[row, col] = value;
    }

    public double[] this[int row]
    {
        get
        {
            var temp = new double[Cols];
            for (var i = 0; i < Cols; i++)
            {
                temp[i] = Data[row, i];
            }

            return temp;
        }
        set
        {
            for (var i = 0; i < value.Length; i++)
            {
                Data[row, i] = value[i];
            }
        }
    }

    public Matrix(int rows, int cols)
    {
        Rows = rows;
        Cols = cols;
        Data = new double[Rows, Cols];
    }

    public (int, int) GetDimensions()
    {
        return ( Rows, Cols );
    }

    public static Matrix operator +(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new Exception("Rows and columns must be the same in both matrices to add them together");

        var tmpMat = new Matrix(a.Rows, a.Cols);
        
        for (var r = 0; r < a.Rows; r++)
        {
            for (var c = 0; c < a.Cols; c++)
            {
                tmpMat[r, c] = a[r, c] + b[r, c];
            }
        }

        return tmpMat;
    }
    public static Matrix operator -(Matrix a, Matrix b)
    {
        if (a.Rows != b.Rows || a.Cols != b.Cols)
            throw new Exception("Rows and columns must be the same in both matrices to add them together");

        var tmpMat = new Matrix(a.Rows, a.Cols);
        
        for (var r = 0; r < a.Rows; r++)
        {
            for (var c = 0; c < a.Cols; c++)
            {
                tmpMat[r, c] = a[r, c] - b[r, c];
            }
        }

        return tmpMat;
    }
    public static Matrix operator *(Matrix a, Matrix b)
    {
        if (a.Cols != b.Rows)
            throw new Exception("The number of columns in Matrix A must be equal to the number of rows in Matrix B");
        var mat = new Matrix(a.Rows, b.Cols);

        // TODO finish making algorithm to multiply two matrices
        
        // multiply 0 row of A by 0 column of B
        // sum of previous calculation = 0 row, 0 col
        
        // multiply 0 row of A by 1 column of B
        // sum of previous calculation = 0 row, 1 col

        for (var r = 0; r < mat.Rows; r++)
        {
            for (var c = 0; c < mat.Cols; c++)
            {
                
            }
        }

        return mat;
    }
    public static Matrix operator *(Matrix a, double mult)
    {
        for (var r = 0; r < a.Rows; r++)
        {
            for (var c = 0; c < a.Cols; c++)
            {
                a[r, c] *= mult;
            }
        }

        return a;
    }
    
    public override string ToString()
    {
        var mat = "";

        for (var r = 0; r < Rows; r++)
        {
            if (r == 0)
                mat += "⎧ ";
            else if (r == Rows - 1)
                mat += "⎩ ";
            else
                mat += "⎢ ";
            
            for (var c = 0; c < Cols; c++)
            {
                mat += Data[r, c] + " ";
            }
            
            if (r == 0)
                mat += "⎫\n";
            else if (r == Rows - 1)
                mat += "⎭\n";
            else
                mat += "⎥\n";
        }

        return mat;
    }
}
