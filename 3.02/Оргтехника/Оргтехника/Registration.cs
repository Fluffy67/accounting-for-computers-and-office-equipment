using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Оргтехника
{
    public partial class Registration : Form
    {
        #region database connection
        //database connection
        private SQLiteConnection connection;
        public Registration()
        {
            InitializeComponent();
            connection = new SQLiteConnection("Data Source=OficeEqipment.db");
            connection.Open();
        }
        #endregion 

        #region Registration
        private void Regisatration_Click(object sender, EventArgs e)
        {
            string login = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            // Inserting a new user into the "users" table
            string insertQuery = $@"INSERT INTO Inputs (Email, Password) VALUES 
                                ('{login}', '{password}')";
            SQLiteCommand Command = new SQLiteCommand(insertQuery, connection);
            Command.ExecuteNonQuery();

            MessageBox.Show("Регистрация прошла успешно!");
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Form fBeginning = new Beginning();
            fBeginning.Show();
            fBeginning.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    #endregion 
    }
}
