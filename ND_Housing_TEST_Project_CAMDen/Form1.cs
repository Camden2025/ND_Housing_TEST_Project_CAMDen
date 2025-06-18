using System.Data;
namespace ND_Housing_TEST_Project_CAMDen
{
    public partial class ND : Form
    {
        public ND()
        {
            InitializeComponent();
        }
        //runs when form is laoded
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                // Loads CSV file below.
                // If the CSV file is in the same folder as the executable, you can omit the full file path and just use "YourFileName.csv".

                string filepath = "C:\\Users\\Camde\\Documents\\data.csv"; //replace with the new path or file name here.

                if (File.Exists(filepath))
                {
                    var lines = File.ReadAllLines(filepath);
                    var table = new DataTable();
                    // for each is building the tabels columns from first row of values
                    foreach (var line in lines)
                    {
                        var values = line.Split(',');
                        if (table.Columns.Count == 0)
                        {
                            for (int i = 0; i < values.Length; i++)
                            {
                                table.Columns.Add($"Column {i + 1}");
                            }
                        }
                        table.Rows.Add(values);// add each of the row's of values to the tabel
                    }
                    dataGridView1.DataSource = table;// display the tabel in our dataGridView1 we pput itno form1.cs designer 
                }
                else
                {
                    // if the CSV is not foudn then the code will throw the exception so it can trigger a catch and log it

                    throw new FileNotFoundException("CSV file not found at path: " + filepath);
                }
            }
            catch (Exception ex)
            { //if it fails to find a csv or any error we log it.
                LogError(ex);
                MessageBox.Show("Failed to load CSV. Please see log for detials");
            }
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)//Make sure the user clicked on a valid cell (not a header or empty space)
                {
                    var cell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];//Gets our value from the cell clicked
                    string value = cell.Value?.ToString();

                    // If a blank space is left after a number in the CSV (e.g., 1,2,), it will appear as an empty cell.
                    // When double-clicked, the popup will display a message explaining why the cell is empty.
                    if (string.IsNullOrEmpty(value))
                    {
                        value = "This cell was empty in the CSV. It may be due to a formatting issue, such as a missing value (e.g., 1,2,).";
                    }
                    var popup = new ValueDisplayFormWhenDoubleClicked(e.RowIndex, e.ColumnIndex, value);//Opens the popup window 
                    popup.ShowDialog();

                }

            }
            catch (Exception ex)
            {
                // Log and display any errors related to the popup
                LogError(ex);
                MessageBox.Show("Error displaying value. Please see error log for more details.");

            }
        }
        // Logs any caught exceptions to a text file on the Desktop
        private void LogError(Exception ex)
        {
            try
            {
                string DesktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string logFilePath = Path.Combine(DesktopPath, "app_error_log.txt");

                string LogEntry = $"[{DateTime.Now}] {ex.Message}\n{ex.StackTrace}\n\n";
                File.AppendAllText(logFilePath, LogEntry);
            }
            catch
            {
            }
        }
    }
}
