using System;
using System.Windows.Forms;

namespace Оргтехника
{
    public partial class Beginning : Form
    {
        public Beginning()
        {
            InitializeComponent();
        }
        #region Кнопки
        //Form Exit
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Go to login form
        private void Tntrance_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Entrance();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        //Go to the registration form
        private void Regisatration_Click(object sender, EventArgs e)
        {
            Form fRegistration = new Registration();
            fRegistration.Show();
            fRegistration.FormClosed += new FormClosedEventHandler(form_FormClosed1);
            this.Hide();
        }

        void form_FormClosed1(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
        #endregion 
    }
}
