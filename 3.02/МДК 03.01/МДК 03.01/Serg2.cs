using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace МДК_03._01
{
    public partial class Serg2 : Form
    {
        public Serg2()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fForm1 = new Form1();
            fForm1.Show();
            fForm1.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }
    }
}
