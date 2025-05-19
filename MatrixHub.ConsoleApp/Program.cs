using MatrixHub.ConsoleApp.Application;

namespace MatrixHub.ConsoleApp;

public static class Program
{
    public static void Main()
    {
        Start();
        var matrix = MatrixService.CreateMatrix();
        MatrixService.PopulateMatrix(matrix);
        MatrixService.ShowMatrix(matrix);
    }

    private static void Start()
    {
        Console.Clear();
        Console.WriteLine(
            """
            
            $$\      $$\            $$\               $$\           $$\   $$\           $$\       
            $$$\    $$$ |           $$ |              \__|          $$ |  $$ |          $$ |      
            $$$$\  $$$$ | $$$$$$\ $$$$$$\    $$$$$$\  $$\ $$\   $$\ $$ |  $$ |$$\   $$\ $$$$$$$\  
            $$\$$\$$ $$ | \____$$\\_$$  _|  $$  __$$\ $$ |\$$\ $$  |$$$$$$$$ |$$ |  $$ |$$  __$$\ 
            $$ \$$$  $$ | $$$$$$$ | $$ |    $$ |  \__|$$ | \$$$$  / $$  __$$ |$$ |  $$ |$$ |  $$ |
            $$ |\$  /$$ |$$  __$$ | $$ |$$\ $$ |      $$ | $$  $$<  $$ |  $$ |$$ |  $$ |$$ |  $$ |
            $$ | \_/ $$ |\$$$$$$$ | \$$$$  |$$ |      $$ |$$  /\$$\ $$ |  $$ |\$$$$$$  |$$$$$$$  |
            \__|     \__| \_______|  \____/ \__|      \__|\__/  \__|\__|  \__| \______/ \_______/ 
                                                                                                                   
            MatrixHub Version: 0.0.1
            MatrixHub Repository: www.github.com/dpacoladev/MatrixHub
            Dotnet SDK Version: 9.0.106
            C-SHARP Version: 13.0
            Developed with IDE: Linux Ubuntu 24.04.02 Noble Numbat LTS
            Developed with OS: JetBrains Rider Non-Commercial Use
            Last Update: May 19 2025
            
            Project Created By: Dalton P. Franco
            Github: www.github.com/dpacoladev
            
            Press any key to continue...
            """
        );
        Console.ReadKey();
    }
}