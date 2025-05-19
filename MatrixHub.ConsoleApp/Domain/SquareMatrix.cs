namespace MatrixHub.ConsoleApp.Domain;

public class SquareMatrix(uint rowsAndColumns) : Matrix(rowsAndColumns, rowsAndColumns)
{
    public uint RowsAndColumns { get; private set; } = rowsAndColumns;
}