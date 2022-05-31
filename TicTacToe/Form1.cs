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
            if (box1.Text == "")
            {
                box1.Text = "X";
            }
            else
            {
                box1.Text = "O";    
            }
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (box2.Text == "")
            {
                box2.Text = "X";
            }
            else
            {
                box2.Text = "O";
            }
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (box3.Text == "")
            {
                box3.Text = "X";
            }
            else
            {
                box3.Text = "O";
            }
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (box4.Text == "")
            {
                box4.Text = "X";
            }
            else
            {
                box4.Text = "O";
            }
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (box5.Text == "")
            {
                box5.Text = "X";
            }
            else
            {
                box5.Text = "O";
            }
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (box6.Text == "")
            {
                box6.Text = "X";
            }
            else
            {
                box6.Text = "O";
            }
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (box7.Text == "")
            {
                box7.Text = "X";
            }
            else
            {
                box7.Text = "O";
            }
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (box8.Text == "")
            {
                box8.Text = "X";
            }
            else
            {
                box8.Text = "O";
            }
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (box9.Text == "")
            {
                box9.Text = "X";
            }
            else
            {
                box9.Text = "O";
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box2.Text = "";
            box3.Text = "";
            box4.Text = "";
            box5.Text = "";
            box6.Text = "";
            box7.Text = "";
            box8.Text = "";
            box9.Text = "";

        }
    }
}