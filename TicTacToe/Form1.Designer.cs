namespace TicTacToe
{
    partial class TicTacWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.box1 = new System.Windows.Forms.Button();
            this.box3 = new System.Windows.Forms.Button();
            this.box6 = new System.Windows.Forms.Button();
            this.box9 = new System.Windows.Forms.Button();
            this.box2 = new System.Windows.Forms.Button();
            this.box5 = new System.Windows.Forms.Button();
            this.box8 = new System.Windows.Forms.Button();
            this.box4 = new System.Windows.Forms.Button();
            this.box7 = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(336, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "Menu";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // box1
            // 
            this.box1.BackColor = System.Drawing.Color.White;
            this.box1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box1.Location = new System.Drawing.Point(21, 37);
            this.box1.Name = "box1";
            this.box1.Size = new System.Drawing.Size(93, 83);
            this.box1.TabIndex = 1;
            this.box1.TabStop = false;
            this.box1.UseVisualStyleBackColor = false;
            this.box1.Click += new System.EventHandler(this.box1_Click);
            // 
            // box3
            // 
            this.box3.BackColor = System.Drawing.Color.White;
            this.box3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box3.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box3.Location = new System.Drawing.Point(219, 37);
            this.box3.Name = "box3";
            this.box3.Size = new System.Drawing.Size(93, 83);
            this.box3.TabIndex = 2;
            this.box3.TabStop = false;
            this.box3.UseVisualStyleBackColor = false;
            this.box3.Click += new System.EventHandler(this.box3_Click);
            // 
            // box6
            // 
            this.box6.BackColor = System.Drawing.Color.White;
            this.box6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box6.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box6.Location = new System.Drawing.Point(219, 126);
            this.box6.Name = "box6";
            this.box6.Size = new System.Drawing.Size(93, 83);
            this.box6.TabIndex = 3;
            this.box6.TabStop = false;
            this.box6.UseVisualStyleBackColor = false;
            this.box6.Click += new System.EventHandler(this.box6_Click);
            // 
            // box9
            // 
            this.box9.BackColor = System.Drawing.Color.White;
            this.box9.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box9.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box9.Location = new System.Drawing.Point(219, 215);
            this.box9.Name = "box9";
            this.box9.Size = new System.Drawing.Size(93, 83);
            this.box9.TabIndex = 4;
            this.box9.TabStop = false;
            this.box9.UseVisualStyleBackColor = false;
            this.box9.Click += new System.EventHandler(this.box9_Click);
            // 
            // box2
            // 
            this.box2.BackColor = System.Drawing.Color.White;
            this.box2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box2.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box2.Location = new System.Drawing.Point(120, 37);
            this.box2.Name = "box2";
            this.box2.Size = new System.Drawing.Size(93, 83);
            this.box2.TabIndex = 5;
            this.box2.TabStop = false;
            this.box2.UseVisualStyleBackColor = false;
            this.box2.Click += new System.EventHandler(this.box2_Click);
            // 
            // box5
            // 
            this.box5.BackColor = System.Drawing.Color.White;
            this.box5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box5.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box5.Location = new System.Drawing.Point(120, 126);
            this.box5.Name = "box5";
            this.box5.Size = new System.Drawing.Size(93, 83);
            this.box5.TabIndex = 6;
            this.box5.TabStop = false;
            this.box5.UseVisualStyleBackColor = false;
            this.box5.Click += new System.EventHandler(this.box5_Click);
            // 
            // box8
            // 
            this.box8.BackColor = System.Drawing.Color.White;
            this.box8.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box8.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box8.Location = new System.Drawing.Point(120, 215);
            this.box8.Name = "box8";
            this.box8.Size = new System.Drawing.Size(93, 83);
            this.box8.TabIndex = 7;
            this.box8.TabStop = false;
            this.box8.UseVisualStyleBackColor = false;
            this.box8.Click += new System.EventHandler(this.box8_Click);
            // 
            // box4
            // 
            this.box4.BackColor = System.Drawing.Color.White;
            this.box4.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box4.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box4.Location = new System.Drawing.Point(21, 126);
            this.box4.Name = "box4";
            this.box4.Size = new System.Drawing.Size(93, 83);
            this.box4.TabIndex = 9;
            this.box4.TabStop = false;
            this.box4.UseVisualStyleBackColor = false;
            this.box4.Click += new System.EventHandler(this.box4_Click);
            // 
            // box7
            // 
            this.box7.BackColor = System.Drawing.Color.White;
            this.box7.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.box7.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.box7.Location = new System.Drawing.Point(21, 215);
            this.box7.Name = "box7";
            this.box7.Size = new System.Drawing.Size(93, 83);
            this.box7.TabIndex = 10;
            this.box7.TabStop = false;
            this.box7.UseVisualStyleBackColor = false;
            this.box7.Click += new System.EventHandler(this.box7_Click);
            // 
            // TicTacWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(336, 316);
            this.ControlBox = false;
            this.Controls.Add(this.box7);
            this.Controls.Add(this.box4);
            this.Controls.Add(this.box8);
            this.Controls.Add(this.box5);
            this.Controls.Add(this.box2);
            this.Controls.Add(this.box9);
            this.Controls.Add(this.box6);
            this.Controls.Add(this.box3);
            this.Controls.Add(this.box1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "TicTacWindow";
            this.Text = "TIC TAC TOE";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem newGameToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private Button box1;
        private Button box3;
        private Button box6;
        private Button box9;
        private Button box2;
        private Button box5;
        private Button box8;
        private Button box4;
        private Button box7;
    }
}