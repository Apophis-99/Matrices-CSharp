
using Matrices.lib;

var mat1 = new Matrix2x2();
var mat2 = new Matrix2x2();

mat1[0, 0] = 3;
mat1[0, 1] = 1;
mat1[1, 0] = 4;
mat1[1, 1] = 2;

mat2[0, 0] = 2;
mat2[0, 1] = 6;
mat2[1, 0] = 4;
mat2[1, 1] = 0;

var matrix = new Matrix2x2
{
    [0, 0] = 3,
    [0, 1] = 1,
    [1, 0] = 4,
    [1, 1] = 2
};
// or
var matrix2 = new Matrix2x2
{
    [0] = new double[]{ 3, 1 },
    [1] = new double[]{ 4, 2 },
};

var mat3 = mat1 * mat2;

Console.OutputEncoding = System.Text.Encoding.UTF8;
Console.WriteLine(mat1);
Console.WriteLine(mat2);
Console.WriteLine(mat3);
