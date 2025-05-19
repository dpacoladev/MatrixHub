using System.Text;

namespace MatrixHub.ConsoleApp.Domain;

public class Matrix(uint rows, uint columns)
{
    private readonly int[,] _matrixData = new int[rows, columns];
    public uint Rows { get; } = rows;
    public uint Columns { get; } = columns;

    public override string ToString()
    {
        var sb = new StringBuilder();
        
        for (uint row = 0; row < Rows; row++)
        {
            sb.Append('|');
            var line = string.Empty;
            
            for (uint column = 0; column < Columns; column++)
                line += $"{_matrixData[row, column]}".PadRight(4);
            
            sb.Append(line.Trim()).Append('|').AppendLine();
        }
        return sb.ToString();
    }

    public void AddElementByPosition(uint row, uint column, int element)
    {
        _matrixData[row, column] = element;
    }
}