using Matrices.lib;

var mat = new Matrix3x3
{
    [0] = new double[]{ 1, 4, 2 },
    [1] = new double[]{ 3, 0, 9 },
    [2] = new double[]{ 12, 6, 2 }
};

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(mat);
Console.WriteLine(mat.GetDeterminant());
Console.WriteLine(mat.GetInverse());
