# Matrices (C#)
- Implements a class called Matrix which takes a ```Matrix.Row``` count and ```Matrix.Column``` count
- Individual values can be fetched and altered using ```[row, col]``` operator.
- Overloads several operators to allow **addition**, **subtraction** and **multiplication** of matrices *(division is not possible unless using SquareMatrix)*
- Implements an abstract class called SquareMatrix which has the same number of rows and columns and must be used as a base class. (Used by Matrix2x2 and Matrix3x3). Must override functions ```GetDeterminant()``` and ```GetInverse()```. It also provides ```GetTransposed()``` for any derived class of SquareMatrix.

### TODO
- Implement multiplication of two matrices.
- Implement ```class Matrix3x3```