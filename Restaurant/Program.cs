namespace Restaurant;

internal static class Program
{
    /// <summary>
    /// By: Onnarin Mingmid 155
    ///  The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[]args)
    {
        // To customize application configuration such as set high DPI settings or default font,
        // see https://aka.ms/applicationconfiguration.
        ApplicationConfiguration.Initialize();

        if (args.Length > 0 && args[0].ToLower() == "-k")
            Application.Run(new KitchenForm());
        else
            Application.Run(new Waiterform());
    }
}