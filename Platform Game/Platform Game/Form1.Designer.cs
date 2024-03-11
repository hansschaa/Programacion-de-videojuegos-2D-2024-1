namespace Platform_Game
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            txtScore = new Label();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            pictureBox5 = new PictureBox();
            pictureBox6 = new PictureBox();
            player = new PictureBox();
            door = new PictureBox();
            enemyOne = new PictureBox();
            enemyTwo = new PictureBox();
            coin = new PictureBox();
            pictureBox7 = new PictureBox();
            pictureBox8 = new PictureBox();
            pictureBox9 = new PictureBox();
            pictureBox10 = new PictureBox();
            pictureBox11 = new PictureBox();
            horizontalPlatform = new PictureBox();
            verticalPlatform = new PictureBox();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            ((System.ComponentModel.ISupportInitialize)door).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)coin).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).BeginInit();
            ((System.ComponentModel.ISupportInitialize)horizontalPlatform).BeginInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).BeginInit();
            SuspendLayout();
            // 
            // txtScore
            // 
            txtScore.Location = new Point(463, 9);
            txtScore.Name = "txtScore";
            txtScore.Size = new Size(173, 81);
            txtScore.TabIndex = 0;
            txtScore.Text = "Score: 0";
            txtScore.TextAlign = ContentAlignment.TopRight;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox1.Location = new Point(2, 711);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(425, 36);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Tag = "platform";
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox2.Location = new Point(387, 615);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(183, 36);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            pictureBox2.Tag = "platform";
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox3.Location = new Point(166, 548);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(183, 36);
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            pictureBox3.Tag = "platform";
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox4.Location = new Point(12, 465);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(183, 36);
            pictureBox4.TabIndex = 4;
            pictureBox4.TabStop = false;
            pictureBox4.Tag = "platform";
            // 
            // pictureBox5
            // 
            pictureBox5.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox5.Location = new Point(233, 356);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(383, 36);
            pictureBox5.TabIndex = 5;
            pictureBox5.TabStop = false;
            pictureBox5.Tag = "platform";
            // 
            // pictureBox6
            // 
            pictureBox6.BackColor = Color.FromArgb(192, 192, 0);
            pictureBox6.Location = new Point(31, 112);
            pictureBox6.Name = "pictureBox6";
            pictureBox6.Size = new Size(383, 36);
            pictureBox6.TabIndex = 6;
            pictureBox6.TabStop = false;
            pictureBox6.Tag = "platform";
            // 
            // player
            // 
            player.BackColor = Color.FromArgb(255, 192, 192);
            player.Location = new Point(95, 643);
            player.Name = "player";
            player.Size = new Size(28, 62);
            player.TabIndex = 7;
            player.TabStop = false;
            // 
            // door
            // 
            door.BackColor = Color.FromArgb(0, 192, 0);
            door.Location = new Point(31, 44);
            door.Name = "door";
            door.Size = new Size(66, 62);
            door.TabIndex = 8;
            door.TabStop = false;
            door.Tag = "door";
            // 
            // enemyOne
            // 
            enemyOne.BackColor = Color.Red;
            enemyOne.Location = new Point(31, 424);
            enemyOne.Name = "enemyOne";
            enemyOne.Size = new Size(28, 35);
            enemyOne.TabIndex = 9;
            enemyOne.TabStop = false;
            enemyOne.Tag = "enemy";
            // 
            // enemyTwo
            // 
            enemyTwo.BackColor = Color.Red;
            enemyTwo.Location = new Point(588, 315);
            enemyTwo.Name = "enemyTwo";
            enemyTwo.Size = new Size(28, 35);
            enemyTwo.TabIndex = 10;
            enemyTwo.TabStop = false;
            enemyTwo.Tag = "enemy";
            // 
            // coin
            // 
            coin.BackColor = Color.FromArgb(255, 255, 128);
            coin.Location = new Point(482, 315);
            coin.Name = "coin";
            coin.Size = new Size(28, 35);
            coin.TabIndex = 11;
            coin.TabStop = false;
            coin.Tag = "coin";
            // 
            // pictureBox7
            // 
            pictureBox7.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox7.Location = new Point(427, 315);
            pictureBox7.Name = "pictureBox7";
            pictureBox7.Size = new Size(28, 35);
            pictureBox7.TabIndex = 12;
            pictureBox7.TabStop = false;
            pictureBox7.Tag = "coin";
            // 
            // pictureBox8
            // 
            pictureBox8.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox8.Location = new Point(219, 507);
            pictureBox8.Name = "pictureBox8";
            pictureBox8.Size = new Size(28, 35);
            pictureBox8.TabIndex = 14;
            pictureBox8.TabStop = false;
            pictureBox8.Tag = "coin";
            // 
            // pictureBox9
            // 
            pictureBox9.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox9.Location = new Point(274, 507);
            pictureBox9.Name = "pictureBox9";
            pictureBox9.Size = new Size(28, 35);
            pictureBox9.TabIndex = 13;
            pictureBox9.TabStop = false;
            pictureBox9.Tag = "coin";
            // 
            // pictureBox10
            // 
            pictureBox10.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox10.Location = new Point(444, 574);
            pictureBox10.Name = "pictureBox10";
            pictureBox10.Size = new Size(28, 35);
            pictureBox10.TabIndex = 16;
            pictureBox10.TabStop = false;
            pictureBox10.Tag = "coin";
            // 
            // pictureBox11
            // 
            pictureBox11.BackColor = Color.FromArgb(255, 255, 128);
            pictureBox11.Location = new Point(499, 574);
            pictureBox11.Name = "pictureBox11";
            pictureBox11.Size = new Size(28, 35);
            pictureBox11.TabIndex = 15;
            pictureBox11.TabStop = false;
            pictureBox11.Tag = "coin";
            // 
            // horizontalPlatform
            // 
            horizontalPlatform.BackColor = Color.FromArgb(192, 192, 0);
            horizontalPlatform.Location = new Point(95, 258);
            horizontalPlatform.Name = "horizontalPlatform";
            horizontalPlatform.Size = new Size(67, 36);
            horizontalPlatform.TabIndex = 17;
            horizontalPlatform.TabStop = false;
            horizontalPlatform.Tag = "horizontalPlatform";
            // 
            // verticalPlatform
            // 
            verticalPlatform.BackColor = Color.FromArgb(192, 192, 0);
            verticalPlatform.Location = new Point(549, 506);
            verticalPlatform.Name = "verticalPlatform";
            verticalPlatform.Size = new Size(67, 36);
            verticalPlatform.TabIndex = 18;
            verticalPlatform.TabStop = false;
            verticalPlatform.Tag = "verticalPlatform";
            // 
            // gameTimer
            // 
            gameTimer.Enabled = true;
            gameTimer.Interval = 20;
            gameTimer.Tick += MainGameTimerEvent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 255, 255);
            ClientSize = new Size(648, 749);
            Controls.Add(verticalPlatform);
            Controls.Add(horizontalPlatform);
            Controls.Add(pictureBox10);
            Controls.Add(pictureBox11);
            Controls.Add(pictureBox8);
            Controls.Add(pictureBox9);
            Controls.Add(pictureBox7);
            Controls.Add(coin);
            Controls.Add(enemyTwo);
            Controls.Add(enemyOne);
            Controls.Add(door);
            Controls.Add(player);
            Controls.Add(pictureBox6);
            Controls.Add(pictureBox5);
            Controls.Add(pictureBox4);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(txtScore);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            HelpButton = true;
            Name = "Form1";
            Text = "Platform game";
            Load += Form1_Load;
            KeyDown += KeyIsDown;
            KeyUp += KeyIsUp;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox6).EndInit();
            ((System.ComponentModel.ISupportInitialize)player).EndInit();
            ((System.ComponentModel.ISupportInitialize)door).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyOne).EndInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).EndInit();
            ((System.ComponentModel.ISupportInitialize)coin).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox7).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox8).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox9).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox10).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox11).EndInit();
            ((System.ComponentModel.ISupportInitialize)horizontalPlatform).EndInit();
            ((System.ComponentModel.ISupportInitialize)verticalPlatform).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Label txtScore;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private PictureBox pictureBox5;
        private PictureBox pictureBox6;
        private PictureBox player;
        private PictureBox door;
        private PictureBox enemyOne;
        private PictureBox enemyTwo;
        private PictureBox coin;
        private PictureBox pictureBox7;
        private PictureBox pictureBox8;
        private PictureBox pictureBox9;
        private PictureBox pictureBox10;
        private PictureBox pictureBox11;
        private PictureBox horizontalPlatform;
        private PictureBox verticalPlatform;
        private System.Windows.Forms.Timer gameTimer;
    }
}