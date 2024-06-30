namespace МДК_03._01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Vlad_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Vlad1();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
        void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Close();
        }

        private void Serg_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Serg1();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Vlad2();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Serg2();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Serg3();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form fEntrance = new Vlad3();
            fEntrance.Show();
            fEntrance.FormClosed += new FormClosedEventHandler(form_FormClosed);
            this.Hide();
        }
    }
}