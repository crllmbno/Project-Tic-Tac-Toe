namespace TicTacToe
{
    public partial class TicTacWindow : Form
    {
        bool order = true;
        public TicTacWindow()
        {
            InitializeComponent();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Firt to complete a row wins!");
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void box1_Click(object sender, EventArgs e)
        {
            if (order)
                box1.Text = "X";
            else
                box1.Text = "O";

            order = !order;
            box1.Enabled = false;
            checkwin();
        }

        private void box2_Click(object sender, EventArgs e)
        {
            if (order)
                box2.Text = "X";
            else
                box2.Text = "O";

            order = !order;
            box2.Enabled = false;
            checkwin();
        }

        private void box3_Click(object sender, EventArgs e)
        {
            if (order)
                box3.Text = "X";
            else
                box3.Text = "O";

            order = !order;
            box3.Enabled = false;
            checkwin();
        }

        private void box4_Click(object sender, EventArgs e)
        {
            if (order)
                box4.Text = "X";
            else
                box4.Text = "O";

            order = !order;
            box4.Enabled = false;
            checkwin();
        }

        private void box5_Click(object sender, EventArgs e)
        {
            if (order)
                box5.Text = "X";
            else
                box5.Text = "O";

            order = !order;
            box5.Enabled = false;
            checkwin();
        }

        private void box6_Click(object sender, EventArgs e)
        {
            if (order)
                box6.Text = "X";
            else
                box6.Text = "O";

            order = !order;
            box6.Enabled = false;
            checkwin();
        }

        private void box7_Click(object sender, EventArgs e)
        {
            if (order)
                box7.Text = "X";
            else
                box7.Text = "O";

            order = !order;
            box7.Enabled = false;
            checkwin();
        }

        private void box8_Click(object sender, EventArgs e)
        {
            if (order)
                box8.Text = "X";
            else
                box8.Text = "O";

            order = !order;
            box8.Enabled = false;
            checkwin();
        }

        private void box9_Click(object sender, EventArgs e)
        {
            if (order)
                box9.Text = "X";
            else
                box9.Text = "O";

            order = !order;
            box9.Enabled = false;
            checkwin();
        }
        private void checkwin()
        {
            bool winner = false;
            if ((box1.Text == box2.Text) && (box2.Text == box3.Text) && (!box1.Enabled))
                winner = true;
            else if ((box4.Text == box5.Text) && (box5.Text == box6.Text) && (!box4.Enabled))
                winner = true;
            else if ((box7.Text == box8.Text) && (box8.Text == box9.Text) && (!box7.Enabled))
                winner = true;
            else if ((box1.Text == box5.Text) && (box5.Text == box9.Text) && (!box1.Enabled))
                winner = true;
            else if ((box3.Text == box5.Text) && (box5.Text == box7.Text) && (!box3.Enabled))
                winner = true;
            else if ((box1.Text == box4.Text) && (box4.Text == box7.Text) && (!box1.Enabled))
                winner = true;
            else if ((box2.Text == box5.Text) && (box5.Text == box8.Text) && (!box2.Enabled))
                winner = true;
            else if ((box3.Text == box6.Text) && (box6.Text == box9.Text) && (!box3.Enabled))
                winner = true;

            if (winner)
            {
                MessageBox.Show("yey");
                box1.Text = "";
                box1.Enabled = true;
                box2.Text = "";
                box2.Enabled = true;
                box3.Text = "";
                box3.Enabled = true;
                box4.Text = "";
                box4.Enabled = true;
                box5.Text = "";
                box5.Enabled = true;
                box6.Text = "";
                box6.Enabled = true;
                box7.Text = "";
                box7.Enabled = true;
                box8.Text = "";
                box8.Enabled = true;
                box9.Text = "";
                box9.Enabled = true;
            }
        }
        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            box1.Text = "";
            box1.Enabled = true;
            box2.Text = "";
            box2.Enabled = true;
            box3.Text = "";
            box3.Enabled = true;
            box4.Text = "";
            box4.Enabled = true;
            box5.Text = "";
            box5.Enabled = true;
            box6.Text = "";
            box6.Enabled = true;
            box7.Text = "";
            box7.Enabled = true;
            box8.Text = "";
            box8.Enabled = true;
            box9.Text = "";
            box9.Enabled = true;
            bool winner = false;
        }
    }
}