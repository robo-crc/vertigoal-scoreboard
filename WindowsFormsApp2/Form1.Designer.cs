namespace WindowsFormsApp2
{
    partial class Vertigoal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.BlueScore = new System.Windows.Forms.Label();
            this.YellowScore = new System.Windows.Forms.Label();
            this.GameTime = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.BlueOneScore = new System.Windows.Forms.Label();
            this.BlueTwoScore = new System.Windows.Forms.Label();
            this.YellowTwoScore = new System.Windows.Forms.Label();
            this.YellowOneScore = new System.Windows.Forms.Label();
            this.LowerTopTowerYellow = new System.Windows.Forms.Label();
            this.LowerTopTowerBlue = new System.Windows.Forms.Label();
            this.LowerBotTowerYellow = new System.Windows.Forms.Label();
            this.LowerBotTowerBlue = new System.Windows.Forms.Label();
            this.LowerTopTowerRed = new System.Windows.Forms.Label();
            this.LowerBotTowerRed = new System.Windows.Forms.Label();
            this.TopBoxRed = new System.Windows.Forms.Label();
            this.TopBoxBlue = new System.Windows.Forms.Label();
            this.TopBoxYellow = new System.Windows.Forms.Label();
            this.BotBoxRed = new System.Windows.Forms.Label();
            this.BotBoxBlue = new System.Windows.Forms.Label();
            this.BotBoxYellow = new System.Windows.Forms.Label();
            this.UpperBotRed = new System.Windows.Forms.Label();
            this.UpperTopRed = new System.Windows.Forms.Label();
            this.UpperBotTowerBlue = new System.Windows.Forms.Label();
            this.UpperBotTowerYellow = new System.Windows.Forms.Label();
            this.UpperTopTowerBlue = new System.Windows.Forms.Label();
            this.UpperTopTowerYellow = new System.Windows.Forms.Label();
            this.ResetButton = new System.Windows.Forms.PictureBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Dawson College ",
            "West Island College ",
            "John Abbott College ",
            "Centennial Regional H.S. ",
            "Collège Sainte-Marcelline ",
            "Collège André Grasset ",
            "Marianopolis College ",
            "É.S. Jules-Verne ",
            "Bois-de-Boulogne 1 ",
            "Bois-de-Boulogne 2 ",
            "Bishop\'s College School ",
            "Cégep du Vieux Montréal ",
            "Lower Canada College ",
            "Royal West Academy ",
            "Selwyn House School ",
            "Lake of Two Mountains H.S.",
            "Macdonald High School ",
            "St. George’s School of Montreal ",
            "É.S. Curé-Antoine-Labelle ",
            "Cégep Vanier College ",
            "Collège Montmorency ",
            "Collège Citoyen ",
            "É.S. Chomedey-De Maisonneuve ",
            "Rosemount Technology Centre ",
            "Saint-Lambert International H.S."});
            this.comboBox1.Location = new System.Drawing.Point(89, 10);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(449, 39);
            this.comboBox1.TabIndex = 0;
            // 
            // BlueScore
            // 
            this.BlueScore.AutoSize = true;
            this.BlueScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.BlueScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BlueScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlueScore.Location = new System.Drawing.Point(957, 11);
            this.BlueScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueScore.MinimumSize = new System.Drawing.Size(133, 123);
            this.BlueScore.Name = "BlueScore";
            this.BlueScore.Size = new System.Drawing.Size(133, 123);
            this.BlueScore.TabIndex = 4;
            this.BlueScore.Text = "0";
            this.BlueScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YellowScore
            // 
            this.YellowScore.AutoSize = true;
            this.YellowScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.YellowScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.YellowScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YellowScore.Location = new System.Drawing.Point(636, 11);
            this.YellowScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YellowScore.MinimumSize = new System.Drawing.Size(133, 123);
            this.YellowScore.Name = "YellowScore";
            this.YellowScore.Size = new System.Drawing.Size(133, 123);
            this.YellowScore.TabIndex = 5;
            this.YellowScore.Text = "0";
            this.YellowScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameTime
            // 
            this.GameTime.AutoSize = true;
            this.GameTime.BackColor = System.Drawing.Color.Black;
            this.GameTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.GameTime.Location = new System.Drawing.Point(727, 11);
            this.GameTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GameTime.MinimumSize = new System.Drawing.Size(267, 123);
            this.GameTime.Name = "GameTime";
            this.GameTime.Size = new System.Drawing.Size(267, 123);
            this.GameTime.TabIndex = 6;
            this.GameTime.Text = "5:00";
            this.GameTime.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameTime.Click += new System.EventHandler(this.GameTime_Click);
            this.GameTime.DoubleClick += new System.EventHandler(this.GameTime_DoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // BlueOneScore
            // 
            this.BlueOneScore.AutoSize = true;
            this.BlueOneScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.BlueOneScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BlueOneScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlueOneScore.Location = new System.Drawing.Point(1603, 10);
            this.BlueOneScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueOneScore.MinimumSize = new System.Drawing.Size(67, 62);
            this.BlueOneScore.Name = "BlueOneScore";
            this.BlueOneScore.Size = new System.Drawing.Size(67, 62);
            this.BlueOneScore.TabIndex = 12;
            this.BlueOneScore.Text = "0";
            this.BlueOneScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BlueTwoScore
            // 
            this.BlueTwoScore.AutoSize = true;
            this.BlueTwoScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.BlueTwoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.BlueTwoScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BlueTwoScore.Location = new System.Drawing.Point(1603, 94);
            this.BlueTwoScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BlueTwoScore.MinimumSize = new System.Drawing.Size(67, 62);
            this.BlueTwoScore.Name = "BlueTwoScore";
            this.BlueTwoScore.Size = new System.Drawing.Size(67, 62);
            this.BlueTwoScore.TabIndex = 13;
            this.BlueTwoScore.Text = "0";
            this.BlueTwoScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YellowTwoScore
            // 
            this.YellowTwoScore.AutoSize = true;
            this.YellowTwoScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.YellowTwoScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.YellowTwoScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YellowTwoScore.Location = new System.Drawing.Point(15, 102);
            this.YellowTwoScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YellowTwoScore.MinimumSize = new System.Drawing.Size(67, 62);
            this.YellowTwoScore.Name = "YellowTwoScore";
            this.YellowTwoScore.Size = new System.Drawing.Size(67, 62);
            this.YellowTwoScore.TabIndex = 14;
            this.YellowTwoScore.Text = "0";
            this.YellowTwoScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // YellowOneScore
            // 
            this.YellowOneScore.AutoSize = true;
            this.YellowOneScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.YellowOneScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.YellowOneScore.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.YellowOneScore.Location = new System.Drawing.Point(15, 10);
            this.YellowOneScore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.YellowOneScore.MinimumSize = new System.Drawing.Size(67, 62);
            this.YellowOneScore.Name = "YellowOneScore";
            this.YellowOneScore.Size = new System.Drawing.Size(67, 62);
            this.YellowOneScore.TabIndex = 15;
            this.YellowOneScore.Text = "0";
            this.YellowOneScore.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LowerTopTowerYellow
            // 
            this.LowerTopTowerYellow.AutoSize = true;
            this.LowerTopTowerYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.LowerTopTowerYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LowerTopTowerYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerTopTowerYellow.Location = new System.Drawing.Point(16, 378);
            this.LowerTopTowerYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerTopTowerYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.LowerTopTowerYellow.Name = "LowerTopTowerYellow";
            this.LowerTopTowerYellow.Size = new System.Drawing.Size(140, 74);
            this.LowerTopTowerYellow.TabIndex = 16;
            this.LowerTopTowerYellow.Text = "0";
            this.LowerTopTowerYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerTopTowerYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LowerTopTowerYellow_MouseClick);
            // 
            // LowerTopTowerBlue
            // 
            this.LowerTopTowerBlue.AutoSize = true;
            this.LowerTopTowerBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.LowerTopTowerBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerTopTowerBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerTopTowerBlue.Location = new System.Drawing.Point(400, 378);
            this.LowerTopTowerBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerTopTowerBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.LowerTopTowerBlue.Name = "LowerTopTowerBlue";
            this.LowerTopTowerBlue.Size = new System.Drawing.Size(140, 74);
            this.LowerTopTowerBlue.TabIndex = 17;
            this.LowerTopTowerBlue.Text = "0";
            this.LowerTopTowerBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerTopTowerBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LowerTopTowerBlue_MouseClick);
            // 
            // LowerBotTowerYellow
            // 
            this.LowerBotTowerYellow.AutoSize = true;
            this.LowerBotTowerYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.LowerBotTowerYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LowerBotTowerYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerBotTowerYellow.Location = new System.Drawing.Point(16, 582);
            this.LowerBotTowerYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerBotTowerYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.LowerBotTowerYellow.Name = "LowerBotTowerYellow";
            this.LowerBotTowerYellow.Size = new System.Drawing.Size(140, 74);
            this.LowerBotTowerYellow.TabIndex = 26;
            this.LowerBotTowerYellow.Text = "0";
            this.LowerBotTowerYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerBotTowerYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LowerBotTowerYellow_MouseClick);
            // 
            // LowerBotTowerBlue
            // 
            this.LowerBotTowerBlue.AutoSize = true;
            this.LowerBotTowerBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.LowerBotTowerBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LowerBotTowerBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerBotTowerBlue.Location = new System.Drawing.Point(400, 582);
            this.LowerBotTowerBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerBotTowerBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.LowerBotTowerBlue.Name = "LowerBotTowerBlue";
            this.LowerBotTowerBlue.Size = new System.Drawing.Size(140, 74);
            this.LowerBotTowerBlue.TabIndex = 27;
            this.LowerBotTowerBlue.Text = "0";
            this.LowerBotTowerBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerBotTowerBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LowerBotTowerBlue_MouseClick);
            // 
            // LowerTopTowerRed
            // 
            this.LowerTopTowerRed.AutoSize = true;
            this.LowerTopTowerRed.BackColor = System.Drawing.Color.Gray;
            this.LowerTopTowerRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LowerTopTowerRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerTopTowerRed.Location = new System.Drawing.Point(245, 378);
            this.LowerTopTowerRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerTopTowerRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.LowerTopTowerRed.Name = "LowerTopTowerRed";
            this.LowerTopTowerRed.Size = new System.Drawing.Size(80, 74);
            this.LowerTopTowerRed.TabIndex = 32;
            this.LowerTopTowerRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerTopTowerRed.Click += new System.EventHandler(this.LowerTopTowerRed_Click);
            // 
            // LowerBotTowerRed
            // 
            this.LowerBotTowerRed.AutoSize = true;
            this.LowerBotTowerRed.BackColor = System.Drawing.Color.Gray;
            this.LowerBotTowerRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.LowerBotTowerRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LowerBotTowerRed.Location = new System.Drawing.Point(245, 582);
            this.LowerBotTowerRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LowerBotTowerRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.LowerBotTowerRed.Name = "LowerBotTowerRed";
            this.LowerBotTowerRed.Size = new System.Drawing.Size(80, 74);
            this.LowerBotTowerRed.TabIndex = 33;
            this.LowerBotTowerRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LowerBotTowerRed.Click += new System.EventHandler(this.LowerBotTowerRed_Click);
            // 
            // TopBoxRed
            // 
            this.TopBoxRed.AutoSize = true;
            this.TopBoxRed.BackColor = System.Drawing.Color.Gray;
            this.TopBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TopBoxRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopBoxRed.Location = new System.Drawing.Point(811, 481);
            this.TopBoxRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopBoxRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.TopBoxRed.Name = "TopBoxRed";
            this.TopBoxRed.Size = new System.Drawing.Size(80, 74);
            this.TopBoxRed.TabIndex = 42;
            this.TopBoxRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopBoxRed.Click += new System.EventHandler(this.TopBoxRed_Click);
            // 
            // TopBoxBlue
            // 
            this.TopBoxBlue.AutoSize = true;
            this.TopBoxBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.TopBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TopBoxBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopBoxBlue.Location = new System.Drawing.Point(951, 481);
            this.TopBoxBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopBoxBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.TopBoxBlue.Name = "TopBoxBlue";
            this.TopBoxBlue.Size = new System.Drawing.Size(140, 74);
            this.TopBoxBlue.TabIndex = 41;
            this.TopBoxBlue.Text = "0";
            this.TopBoxBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopBoxBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TopBoxBlue_MouseClick);
            // 
            // TopBoxYellow
            // 
            this.TopBoxYellow.AutoSize = true;
            this.TopBoxYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.TopBoxYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.TopBoxYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TopBoxYellow.Location = new System.Drawing.Point(608, 481);
            this.TopBoxYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TopBoxYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.TopBoxYellow.Name = "TopBoxYellow";
            this.TopBoxYellow.Size = new System.Drawing.Size(140, 74);
            this.TopBoxYellow.TabIndex = 40;
            this.TopBoxYellow.Text = "0";
            this.TopBoxYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.TopBoxYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TopBoxYellow_MouseClick);
            // 
            // BotBoxRed
            // 
            this.BotBoxRed.AutoSize = true;
            this.BotBoxRed.BackColor = System.Drawing.Color.Gray;
            this.BotBoxRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.BotBoxRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotBoxRed.Location = new System.Drawing.Point(811, 753);
            this.BotBoxRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BotBoxRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.BotBoxRed.Name = "BotBoxRed";
            this.BotBoxRed.Size = new System.Drawing.Size(80, 74);
            this.BotBoxRed.TabIndex = 45;
            this.BotBoxRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotBoxRed.Click += new System.EventHandler(this.BotBoxRed_Click);
            // 
            // BotBoxBlue
            // 
            this.BotBoxBlue.AutoSize = true;
            this.BotBoxBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.BotBoxBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotBoxBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotBoxBlue.Location = new System.Drawing.Point(951, 753);
            this.BotBoxBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BotBoxBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.BotBoxBlue.Name = "BotBoxBlue";
            this.BotBoxBlue.Size = new System.Drawing.Size(140, 74);
            this.BotBoxBlue.TabIndex = 44;
            this.BotBoxBlue.Text = "0";
            this.BotBoxBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotBoxBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotBoxBlue_MouseClick);
            // 
            // BotBoxYellow
            // 
            this.BotBoxYellow.AutoSize = true;
            this.BotBoxYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.BotBoxYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.BotBoxYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.BotBoxYellow.Location = new System.Drawing.Point(608, 753);
            this.BotBoxYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.BotBoxYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.BotBoxYellow.Name = "BotBoxYellow";
            this.BotBoxYellow.Size = new System.Drawing.Size(140, 74);
            this.BotBoxYellow.TabIndex = 43;
            this.BotBoxYellow.Text = "0";
            this.BotBoxYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BotBoxYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.BotBoxYellow_MouseClick);
            // 
            // UpperBotRed
            // 
            this.UpperBotRed.AutoSize = true;
            this.UpperBotRed.BackColor = System.Drawing.Color.Gray;
            this.UpperBotRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.UpperBotRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperBotRed.Location = new System.Drawing.Point(1349, 582);
            this.UpperBotRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperBotRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.UpperBotRed.Name = "UpperBotRed";
            this.UpperBotRed.Size = new System.Drawing.Size(80, 74);
            this.UpperBotRed.TabIndex = 51;
            this.UpperBotRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperBotRed.Click += new System.EventHandler(this.UpperBotRed_Click);
            // 
            // UpperTopRed
            // 
            this.UpperTopRed.AutoSize = true;
            this.UpperTopRed.BackColor = System.Drawing.Color.Gray;
            this.UpperTopRed.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.UpperTopRed.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperTopRed.Location = new System.Drawing.Point(1349, 378);
            this.UpperTopRed.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperTopRed.MinimumSize = new System.Drawing.Size(80, 74);
            this.UpperTopRed.Name = "UpperTopRed";
            this.UpperTopRed.Size = new System.Drawing.Size(80, 74);
            this.UpperTopRed.TabIndex = 50;
            this.UpperTopRed.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperTopRed.Click += new System.EventHandler(this.UpperTopRed_Click);
            // 
            // UpperBotTowerBlue
            // 
            this.UpperBotTowerBlue.AutoSize = true;
            this.UpperBotTowerBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.UpperBotTowerBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperBotTowerBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperBotTowerBlue.Location = new System.Drawing.Point(1511, 582);
            this.UpperBotTowerBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperBotTowerBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.UpperBotTowerBlue.Name = "UpperBotTowerBlue";
            this.UpperBotTowerBlue.Size = new System.Drawing.Size(140, 74);
            this.UpperBotTowerBlue.TabIndex = 49;
            this.UpperBotTowerBlue.Text = "0";
            this.UpperBotTowerBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperBotTowerBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpperBotTowerBlue_MouseClick);
            // 
            // UpperBotTowerYellow
            // 
            this.UpperBotTowerYellow.AutoSize = true;
            this.UpperBotTowerYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.UpperBotTowerYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.UpperBotTowerYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperBotTowerYellow.Location = new System.Drawing.Point(1148, 582);
            this.UpperBotTowerYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperBotTowerYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.UpperBotTowerYellow.Name = "UpperBotTowerYellow";
            this.UpperBotTowerYellow.Size = new System.Drawing.Size(140, 74);
            this.UpperBotTowerYellow.TabIndex = 48;
            this.UpperBotTowerYellow.Text = "0";
            this.UpperBotTowerYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperBotTowerYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpperBotTowerYellow_MouseClick);
            // 
            // UpperTopTowerBlue
            // 
            this.UpperTopTowerBlue.AutoSize = true;
            this.UpperTopTowerBlue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(162)))), ((int)(((byte)(247)))));
            this.UpperTopTowerBlue.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpperTopTowerBlue.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperTopTowerBlue.Location = new System.Drawing.Point(1511, 378);
            this.UpperTopTowerBlue.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperTopTowerBlue.MinimumSize = new System.Drawing.Size(140, 74);
            this.UpperTopTowerBlue.Name = "UpperTopTowerBlue";
            this.UpperTopTowerBlue.Size = new System.Drawing.Size(140, 74);
            this.UpperTopTowerBlue.TabIndex = 47;
            this.UpperTopTowerBlue.Text = "0";
            this.UpperTopTowerBlue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperTopTowerBlue.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpperTopTowerBlue_MouseClick);
            // 
            // UpperTopTowerYellow
            // 
            this.UpperTopTowerYellow.AutoSize = true;
            this.UpperTopTowerYellow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(211)))), ((int)(((byte)(93)))));
            this.UpperTopTowerYellow.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.UpperTopTowerYellow.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.UpperTopTowerYellow.Location = new System.Drawing.Point(1148, 378);
            this.UpperTopTowerYellow.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UpperTopTowerYellow.MinimumSize = new System.Drawing.Size(140, 74);
            this.UpperTopTowerYellow.Name = "UpperTopTowerYellow";
            this.UpperTopTowerYellow.Size = new System.Drawing.Size(140, 74);
            this.UpperTopTowerYellow.TabIndex = 46;
            this.UpperTopTowerYellow.Text = "0";
            this.UpperTopTowerYellow.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.UpperTopTowerYellow.MouseClick += new System.Windows.Forms.MouseEventHandler(this.UpperTopTowerYellow_MouseClick);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.Transparent;
            this.ResetButton.Location = new System.Drawing.Point(716, 180);
            this.ResetButton.Margin = new System.Windows.Forms.Padding(4);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(248, 219);
            this.ResetButton.TabIndex = 52;
            this.ResetButton.TabStop = false;
            this.ResetButton.DoubleClick += new System.EventHandler(this.ResetButton_DoubleClick);
            // 
            // comboBox2
            // 
            this.comboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Dawson College ",
            "West Island College ",
            "John Abbott College ",
            "Centennial Regional H.S. ",
            "Collège Sainte-Marcelline ",
            "Collège André Grasset ",
            "Marianopolis College ",
            "É.S. Jules-Verne ",
            "Bois-de-Boulogne 1 ",
            "Bois-de-Boulogne 2 ",
            "Bishop\'s College School ",
            "Cégep du Vieux Montréal ",
            "Lower Canada College ",
            "Royal West Academy ",
            "Selwyn House School ",
            "Lake of Two Mountains H.S.",
            "Macdonald High School ",
            "St. George’s School of Montreal ",
            "É.S. Curé-Antoine-Labelle ",
            "Cégep Vanier College ",
            "Collège Montmorency ",
            "Collège Citoyen ",
            "É.S. Chomedey-De Maisonneuve ",
            "Rosemount Technology Centre ",
            "Saint-Lambert International H.S."});
            this.comboBox2.Location = new System.Drawing.Point(89, 102);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(449, 39);
            this.comboBox2.TabIndex = 56;
            // 
            // comboBox3
            // 
            this.comboBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Dawson College ",
            "West Island College ",
            "John Abbott College ",
            "Centennial Regional H.S. ",
            "Collège Sainte-Marcelline ",
            "Collège André Grasset ",
            "Marianopolis College ",
            "É.S. Jules-Verne ",
            "Bois-de-Boulogne 1 ",
            "Bois-de-Boulogne 2 ",
            "Bishop\'s College School ",
            "Cégep du Vieux Montréal ",
            "Lower Canada College ",
            "Royal West Academy ",
            "Selwyn House School ",
            "Lake of Two Mountains H.S.",
            "Macdonald High School ",
            "St. George’s School of Montreal ",
            "É.S. Curé-Antoine-Labelle ",
            "Cégep Vanier College ",
            "Collège Montmorency ",
            "Collège Citoyen ",
            "É.S. Chomedey-De Maisonneuve ",
            "Rosemount Technology Centre ",
            "Saint-Lambert International H.S."});
            this.comboBox3.Location = new System.Drawing.Point(1144, 11);
            this.comboBox3.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(449, 39);
            this.comboBox3.TabIndex = 57;
            // 
            // comboBox4
            // 
            this.comboBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Items.AddRange(new object[] {
            "Dawson College ",
            "West Island College ",
            "John Abbott College ",
            "Centennial Regional H.S. ",
            "Collège Sainte-Marcelline ",
            "Collège André Grasset ",
            "Marianopolis College ",
            "É.S. Jules-Verne ",
            "Bois-de-Boulogne 1 ",
            "Bois-de-Boulogne 2 ",
            "Bishop\'s College School ",
            "Cégep du Vieux Montréal ",
            "Lower Canada College ",
            "Royal West Academy ",
            "Selwyn House School ",
            "Lake of Two Mountains H.S.",
            "Macdonald High School ",
            "St. George’s School of Montreal ",
            "É.S. Curé-Antoine-Labelle ",
            "Cégep Vanier College ",
            "Collège Montmorency ",
            "Collège Citoyen ",
            "É.S. Chomedey-De Maisonneuve ",
            "Rosemount Technology Centre ",
            "Saint-Lambert International H.S."});
            this.comboBox4.Location = new System.Drawing.Point(1144, 95);
            this.comboBox4.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(449, 39);
            this.comboBox4.TabIndex = 58;
            // 
            // Vertigoal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp2.Properties.Resources.Scoring_Display_Background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1685, 838);
            this.Controls.Add(this.comboBox4);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.UpperBotRed);
            this.Controls.Add(this.UpperTopRed);
            this.Controls.Add(this.UpperBotTowerBlue);
            this.Controls.Add(this.UpperBotTowerYellow);
            this.Controls.Add(this.UpperTopTowerBlue);
            this.Controls.Add(this.UpperTopTowerYellow);
            this.Controls.Add(this.BotBoxRed);
            this.Controls.Add(this.BotBoxBlue);
            this.Controls.Add(this.BotBoxYellow);
            this.Controls.Add(this.TopBoxRed);
            this.Controls.Add(this.TopBoxBlue);
            this.Controls.Add(this.TopBoxYellow);
            this.Controls.Add(this.LowerBotTowerRed);
            this.Controls.Add(this.LowerTopTowerRed);
            this.Controls.Add(this.LowerBotTowerBlue);
            this.Controls.Add(this.LowerBotTowerYellow);
            this.Controls.Add(this.LowerTopTowerBlue);
            this.Controls.Add(this.LowerTopTowerYellow);
            this.Controls.Add(this.YellowOneScore);
            this.Controls.Add(this.YellowTwoScore);
            this.Controls.Add(this.BlueTwoScore);
            this.Controls.Add(this.BlueOneScore);
            this.Controls.Add(this.YellowScore);
            this.Controls.Add(this.BlueScore);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.GameTime);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vertigoal";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.ResetButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private int YellowLowerTopScore;
        private int YellowLowerBotScore;
        private int YellowUpperTopScore;
        private int YellowUpperBotScore;
        private int YellowTopBoxScore;
        private int YellowBotBoxScore;
        private int BlueLowerTopScore;
        private int BlueLowerBotScore;
        private int BlueUpperTopScore;
        private int BlueUpperBotScore;
        private int BlueBotBoxScore;
        private int BlueTopBoxScore;
        private bool LowerTopRedMultiply;
        private bool LowerBotRedMultiply;
        private bool UpperTopRedMultiply;
        private bool UpperBotRedMultiply;
        private bool TopBoxRedMultipy;
        private bool BotBoxRedMultiply;

        private int timeLeft;
    
        private System.Windows.Forms.ComboBox comboBox1;
        public System.Windows.Forms.Label BlueScore;
        public System.Windows.Forms.Label YellowScore;
        public System.Windows.Forms.Label GameTime;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label BlueOneScore;
        public System.Windows.Forms.Label BlueTwoScore;
        public System.Windows.Forms.Label YellowTwoScore;
        public System.Windows.Forms.Label YellowOneScore;
        public System.Windows.Forms.Label LowerTopTowerYellow;
        public System.Windows.Forms.Label LowerTopTowerBlue;
        public System.Windows.Forms.Label LowerBotTowerYellow;
        public System.Windows.Forms.Label LowerBotTowerBlue;
        public System.Windows.Forms.Label LowerTopTowerRed;
        public System.Windows.Forms.Label LowerBotTowerRed;
        public System.Windows.Forms.Label TopBoxRed;
        public System.Windows.Forms.Label TopBoxBlue;
        public System.Windows.Forms.Label TopBoxYellow;
        public System.Windows.Forms.Label BotBoxRed;
        public System.Windows.Forms.Label BotBoxBlue;
        public System.Windows.Forms.Label BotBoxYellow;
        public System.Windows.Forms.Label UpperBotRed;
        public System.Windows.Forms.Label UpperTopRed;
        public System.Windows.Forms.Label UpperBotTowerBlue;
        public System.Windows.Forms.Label UpperBotTowerYellow;
        public System.Windows.Forms.Label UpperTopTowerBlue;
        public System.Windows.Forms.Label UpperTopTowerYellow;
        private System.Windows.Forms.PictureBox ResetButton;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}

