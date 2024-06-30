using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Оргтехника
{
    public partial class Entrance : Form
    {
        public Entrance()
        {
            InitializeComponent();
        }
        #region entrance
        //Adding data to database
        private void LoginBtn_Click(object sender, EventArgs e)
        {
            string username = EmailTexBox.Text;
            string password = PasswordTexBox.Text;

            using (var connection = new SQLiteConnection("Data Source=OficeEqipment.db"))
            {
                // Open the database connection
                connection.Open();

                // Prepare the SQL query
                using (var command = new SQLiteCommand("SELECT * FROM Inputs WHERE Email = @Email " +
                    "AND Password = @Password", connection))
                {
                    // Bind the parameters
                    command.Parameters.AddWithValue("@Email", username);
                    command.Parameters.AddWithValue("@Password", password);

                    // Execute the query
                    using (var reader = command.ExecuteReader())
                    {
                        // Check if the user exists
                        if (reader.HasRows)
                        {
                            // User exists, show success message
                            MessageBox.Show("Successful login");

                            // Open a new window
                            Form fTable = new Table();
                            fTable.Show();
                            fTable.FormClosed += new FormClosedEventHandler(form_FormClosed);
                            this.Hide();

                        }
                        else
                        {
                            // User does not exist or incorrect password, show error message
                            MessageBox.Show("Incorrect username or password");
                        }
                    }
                }
            }
        }
        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        //Form Exit
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Change from form to start form
        private void Back_Click(object sender, EventArgs e)
        {
            Form fBeginning = new Beginning();
            fBeginning.Show();
            fBeginning.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

    }
    #endregion 
}
