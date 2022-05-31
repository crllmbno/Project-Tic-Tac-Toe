namespace TicTacToe
{
    public partial class TicTacWindow : Form
    {
        public TicTacWindow()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void box1_Click(object sender, EventArgs e)
        {

        }

        private void box2_Click(object sender, EventArgs e)
        {

        }

        private void box3_Click(object sender, EventArgs e)
        {

        }

        private void box4_Click(object sender, EventArgs e)
        {

        }

        private void box5_Click(object sender, EventArgs e)
        {

        }

        private void box6_Click(object sender, EventArgs e)
        {

        }

        private void box7_Click(object sender, EventArgs e)
        {

        }

        private void box8_Click(object sender, EventArgs e)
        {

        }

        private void box9_Click(object sender, EventArgs e)
        {

        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box1.BackColor = Color.White;
            box2.Text = "";
            box2.BackColor = Color.White;
            box3.Text = "";
            box3.BackColor = Color.White;
            box4.Text = "";
            box4.BackColor = Color.White;
            box5.Text = "";
            box5.BackColor = Color.White;
            box6.Text = "";
            box6.BackColor = Color.White;
            box7.Text = "";
            box7.BackColor = Color.White;
            box8.Text = "";
            box8.BackColor = Color.White;
            box9.Text = "";
            box9.BackColor = Color.White;

        }
    }
}