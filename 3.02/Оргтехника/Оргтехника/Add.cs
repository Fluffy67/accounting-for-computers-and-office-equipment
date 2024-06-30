using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Оргтехника
{
    public partial class Add : Form
    {

        public Add()
        {
            InitializeComponent();
        }
        #region adding data to a table

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Switching to a form with a table
        private void Back_Click(object sender, EventArgs e)
        {
            Form fTable = new Table();
            fTable.Show();
            fTable.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void form_FormClosed(object sender, EventArgs e)
        {
           Application.Exit();
        }
        #endregion

        #region Аdding user to database
        //Adding data to table and database
        private void Add1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=OficeEqipment.db;Integrated Security=False; MultipleActiveResultSets=True";
            using (SQLiteConnection connection = new SQLiteConnection(connectionString))
            {
                connection.Open();
                string sql = $"INSERT INTO Tables (Code, Name, DateJfPurchase, NumberOfEquipment, EquipmentNumber ) " +
                             $"VALUES ('{CodeTextBox.Text}', '{NameTextBox.Text}' ,'{DateTextBox.Text}' ,'{NumberTextBox.Text}','{NumberOborTextBox.Text}')";
                using (SQLiteCommand command = new SQLiteCommand(sql, connection))
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Добавленно в таблицу :)");
                }
            }
            Form fTable = new Table();
            fTable.Show();
            fTable.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        #endregion

        private void DateTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
