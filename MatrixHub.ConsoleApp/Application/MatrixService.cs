using MatrixHub.ConsoleApp.Domain;
using MatrixHub.ConsoleApp.Utils;

namespace MatrixHub.ConsoleApp.Application;

public static class MatrixService
{
    public static Matrix CreateMatrix()
    {
        Console.WriteLine("\n---\nLet's create the Matrix!\n---\n");
        while (true)
        {
            Console.Write("Enter the number of rows: ");
            var rowsString = Console.ReadLine() ?? string.Empty;
            
            Console.Write("Enter the number of columns: ");
            var columnsString = Console.ReadLine() ?? string.Empty;
            
            try
            {
                var rows = StringParse.ToUInt(rowsString.Trim());
                var columns = StringParse.ToUInt(columnsString.Trim());
                Console.WriteLine("\n---\nMatrix was Created!\n---\n");
                return rows == columns ? new SquareMatrix(rows) : new Matrix(rows, columns);
            }
            catch (ArgumentException e)
            {
                Console.WriteLine($"\n---\n{e.Message}\n---\n");
            }
        }
    }
    
    private static void ManuallyPopulateMatrix(Matrix matrix)
    {
        for (uint row = 0; row < matrix.Rows; row++)
            for (uint column = 0; column < matrix.Columns; column++)
            {
                while (true)
                {
                    Console.Write($"Enter the element in the position [{row},{column}]: ");
                    var elementString = Console.ReadLine() ?? string.Empty;

                    try
                    {
                        var element = StringParse.ToInt(elementString);
                        matrix.AddElementByPosition(row, column, element);
                        break;
                    }
                    catch (ArgumentException e)
                    {
                        Console.WriteLine($"\n---\n{e.Message}\n---\n");
                    }
                }    
            }
    }
    
    private static void AutomaticallyPopulateMatrix(Matrix matrix)
    {
        var random = new Random();
        for (uint row = 0; row < matrix.Rows; row++)
            for (uint column = 0; column < matrix.Columns; column++)
                matrix.AddElementByPosition(row, column, random.Next(10));
    }
    
    public static void PopulateMatrix(Matrix matrix)
    {
        while (true)
        {
            Console.Write("Do you wanna populate the Matrix Manually or Automatically? [M/A]: ");
            var condition = Console.ReadLine() ?? string.Empty;

            switch (condition.Trim().ToLower())
            {
                case "m":
                    Console.WriteLine("\n---\nLet's populate the Matrix Manually!\n---\n");
                    ManuallyPopulateMatrix(matrix);
                    return;
                case "a":
                    Console.WriteLine("\n---\nLet's populate the Matrix Automatically!\n---\n");
                    AutomaticallyPopulateMatrix(matrix);
                    return;
                default:
                    Console.WriteLine($"\n---\n'{condition}' is invalid input!, Retry Again!\n---\n");
                    continue;
            }
        }
    }

    public static void ShowMatrix(Matrix matrix)
    {
        Console.WriteLine($"--- Matrix {matrix.Rows}x{matrix.Columns} ---");
        Console.WriteLine(matrix);
    }
}