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

namespace TodoListManager
{
    public partial class TaskPage : Form
    {

        private string connectionString = "Data Source=C:\\Users\\salih\\source\\repos\\TodoListManager\\TodoListManager\\bin\\Debug\\todolist.db;Version=3;";


        public TaskPage()
        {
            InitializeComponent();
            LoadTasks();
        }

        private void btn_newtask_Click(object sender, EventArgs e)
        {
            // Get the task name from the TextBox (assuming you have a TextBox for task name)
            string taskName = txt_task.Text.Trim();

            // Check if task name is empty
            if (string.IsNullOrEmpty(taskName))
            {
                MessageBox.Show("Please enter a task name.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Add the task to the database
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // SQL query to insert a new task
                string query = "INSERT INTO Tasks (TaskName, IsCompleted) VALUES (@TaskName, 0)"; // Default IsCompleted to 0 (Pending)

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@TaskName", taskName);

                    // Execute the insert query
                    command.ExecuteNonQuery();
                }
            }

            // Clear the TextBox after adding the task
            txt_task.Clear();

            // Reload the tasks to show the new task in the ListView
            LoadTasks();

            // Show a success message
            MessageBox.Show("Task added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void LoadTasks()
        {
            lv_tasks.Items.Clear(); // Clear existing items in the ListView

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT TaskName, IsCompleted FROM Tasks"; // Query to fetch tasks
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    using (SQLiteDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string taskName = reader["TaskName"].ToString(); // Get task name
                            string status = Convert.ToBoolean(reader["IsCompleted"]) ? "Completed" : "Not Completed"; // Get task status

                            // Create a new ListViewItem for each task
                            ListViewItem item = new ListViewItem(taskName);
                            item.SubItems.Add(status); // Add status as a subitem

                            // Add the item to the ListView
                            lv_tasks.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void lvTasks_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            int taskId = (int)e.Item.Tag;
            bool isCompleted = e.Item.Checked;

            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string query = "UPDATE Tasks SET IsCompleted = @IsCompleted WHERE Id = @Id";
                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@IsCompleted", isCompleted ? 1 : 0);
                    command.Parameters.AddWithValue("@Id", taskId);
                    command.ExecuteNonQuery();
                }
            }
        }

        private void MarkTaskAsCompleted(string taskName)
        {
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();

                // SQL query to update the task's status to "Completed"
                string query = "UPDATE Tasks SET IsCompleted = 1 WHERE TaskName = @TaskName";

                using (SQLiteCommand command = new SQLiteCommand(query, connection))
                {
                    // Add parameter to prevent SQL injection
                    command.Parameters.AddWithValue("@TaskName", taskName);

                    // Execute the update query
                    command.ExecuteNonQuery();
                }
            }
        }

        private void btn_done_Click(object sender, EventArgs e)
        {
            // Check if any task is selected
            if (lv_tasks.SelectedItems.Count > 0)
            {
                // Get the selected task name
                ListViewItem selectedItem = lv_tasks.SelectedItems[0];
                string taskName = selectedItem.Text;

                // Update the task status in the database to "Completed"
                MarkTaskAsCompleted(taskName);

                // Reload tasks to reflect the updated status in the ListView
                LoadTasks();

                // Show a success message
                MessageBox.Show("Task marked as completed!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                // Show an error message if no task is selected
                MessageBox.Show("Please select a task to mark as completed.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_logoff_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            loginPage.Show();
            this.Hide();
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            // Check if any task is selected
            if (lv_tasks.SelectedItems.Count > 0)
            {
                // Get the selected task name
                ListViewItem selectedItem = lv_tasks.SelectedItems[0];
                string taskName = selectedItem.Text;

                // Ask for confirmation before deleting
                DialogResult result = MessageBox.Show($"Are you sure you want to delete the task: {taskName}?", "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Delete the task from the database
                    using (SQLiteConnection connection = new SQLiteConnection(connectionString))
                    {
                        connection.Open();

                        // SQL query to delete the task by its name
                        string query = "DELETE FROM Tasks WHERE TaskName = @TaskName";

                        using (SQLiteCommand command = new SQLiteCommand(query, connection))
                        {
                            // Add parameter to prevent SQL injection
                            command.Parameters.AddWithValue("@TaskName", taskName);

                            // Execute the delete query
                            command.ExecuteNonQuery();
                        }
                    }

                    // Reload tasks to reflect the updated list
                    LoadTasks();

                    // Show a success message
                    MessageBox.Show("Task deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Show an error message if no task is selected
                MessageBox.Show("Please select a task to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_stats_Click(object sender, EventArgs e)
        {
            ChartPage chartPage = new ChartPage();
            chartPage.Show();
            this.Hide();
        }
    }
}
