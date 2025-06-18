namespace ND_Housing_TEST_Project_CAMDen
{
    internal static class Program
    {
        // Form: ND (Main Form)
        // Loads and displays CSV data in a table.
        // Double-clicking a cell opens a popup showing the cell's value and position.
        // Errors are logged to a text file on the Desktop.
        [STAThread]
        static void Main()
        {

            ApplicationConfiguration.Initialize();
            Application.Run(new ND());
        }
    }
}