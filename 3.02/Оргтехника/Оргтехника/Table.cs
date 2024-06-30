using System;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Collections.Generic;

namespace Оргтехника
{
    public partial class Table : Form
    {
        public Table()
        {
            InitializeComponent();

        }
        #region Database connection and form transition
        private SQLiteConnection OficeEqipment;
        private void button1_Click(object sender, EventArgs e)
        {
            Form fAdd = new Add();
            fAdd.Show();
            fAdd.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //adding data to table
        private async void Table_Load(object sender, EventArgs e)
        {
            OficeEqipment = new SQLiteConnection(DB.connectionString);
            await OficeEqipment.OpenAsync();
            LoadingTable();
        }
        #endregion

        #region Adding data to the database and table
        //Adding data to a table
        private async void LoadingTable()
        {
            TableDataGridView.Rows.Clear();
            SQLiteDataReader sqlReader = null;
            SQLiteCommand command = new SQLiteCommand($"SELECT * FROM [{Tables_table.main}]", OficeEqipment);
            List<string[]> data = new List<string[]>();
            try
            {
                sqlReader = (SQLiteDataReader)await command.ExecuteReaderAsync();
                while (await sqlReader.ReadAsync())
                {
                    data.Add(new string[6]);

                    data[data.Count - 1][0] = Convert.ToString($"{sqlReader[$"{Tables_table.Id}"]}");
                    data[data.Count - 1][1] = Convert.ToString($"{sqlReader[$"{Tables_table.Code}"]}");
                    data[data.Count - 1][2] = Convert.ToString($"{sqlReader[$"{Tables_table.Name}"]}");
                    data[data.Count - 1][3] = Convert.ToString($"{sqlReader[$"{Tables_table.DateJfPurchase}"]}");
                    data[data.Count - 1][4] = Convert.ToString($"{sqlReader[$"{Tables_table.NumberOfEquipment}"]}");
                    data[data.Count - 1][5] = Convert.ToString($"{sqlReader[$"{Tables_table.EquipmentNumber}"]}");
                }

                foreach (string[] s in data)
                {
                    TableDataGridView.Rows.Add(s);
                }
                TableDataGridView.ClearSelection();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message}", $"{ex.Source}");
            }
            finally
            {
                if (sqlReader != null)
                    sqlReader.Close();
            }
        }
        //Removing data from a table
        private async void DeleteButton_Click(object sender, EventArgs e)
        {

            if (TableDataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = TableDataGridView.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = TableDataGridView.Rows[selectedrowindex];
                string id = Convert.ToString(selectedRow.Cells["IdColumn"].Value);
                SQLiteCommand commandDelete = new SQLiteCommand($"DELETE FROM {Tables_table.main} WHERE [{Tables_table. Id}]=@Id", OficeEqipment);
                commandDelete.Parameters.AddWithValue("id", id);
                await commandDelete.ExecuteNonQueryAsync();
                LoadingTable();
                MessageBox.Show("Удаление прошло успешно!");
            }
        }
        #endregion
    }
}
