using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;


namespace TodoListManager
{
    public partial class ChartPage : Form
    {

        private string connectionString = "Data Source=C:\\Users\\salih\\source\\repos\\TodoListManager\\TodoListManager\\bin\\Debug\\todolist.db;Version=3;";

        public ChartPage()
        {
            InitializeComponent();
        }

        private void ChartPage_Load(object sender, EventArgs e)
        {
            LoadChartData(); // Load the chart data when the form is loaded
        }

        // Load the data and populate the chart
        private void LoadChartData()
        {
            // Create a new Series for the chart
            Series series = new Series("Task Status");
            series.ChartType = SeriesChartType.Bar; // Pie chart type

            // Fetch data from the database
            int completedCount = 0;
            int pendingCount = 0;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // SQL query to count completed and pending tasks
                string query = "SELECT IsCompleted, COUNT(*) FROM Tasks GROUP BY IsCompleted";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            bool isCompleted = Convert.ToBoolean(reader["IsCompleted"]);
                            int count = Convert.ToInt32(reader["COUNT(*)"]);

                            // Add data to the series based on completion status
                            if (isCompleted)
                            {
                                completedCount = count;
                            }
                            else
                            {
                                pendingCount = count;
                            }
                        }
                    }
                }
            }

            // Add the data to the series
            series.Points.AddXY("Completed", completedCount);
            series.Points.AddXY("Not Completed", pendingCount);

            // Clear any existing data and add the new series to the chart
            chart_tasks.Series.Clear();
            chart_tasks.Series.Add(series);

            // Optional: Set chart title
            chart_tasks.Titles.Clear();
            chart_tasks.Titles.Add("Task Completion Status");
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            TaskPage taskPage = new TaskPage();
            taskPage.Show();
            this.Hide();
        }
    }
}
