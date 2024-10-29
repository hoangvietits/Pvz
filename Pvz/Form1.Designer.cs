namespace Pvz
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
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            button3 = new Button();
            button6 = new Button();
            button5 = new Button();
            button4 = new Button();
            button2 = new Button();
            button1 = new Button();
            sunLabel = new Label();
            scoreLabel = new Label();
            roundLabel = new Label();
            playerLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1026, 626);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Paint += Paint;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button6);
            panel1.Controls.Add(button5);
            panel1.Controls.Add(button4);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Location = new Point(283, 610);
            panel1.Name = "panel1";
            panel1.Size = new Size(579, 73);
            panel1.TabIndex = 22;
            // 
            // button3
            // 
            button3.BackgroundImage = Properties.Resources.icone_noix;
            button3.BackgroundImageLayout = ImageLayout.Center;
            button3.Location = new Point(258, 3);
            button3.Name = "button3";
            button3.Size = new Size(85, 67);
            button3.TabIndex = 6;
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button6
            // 
            button6.BackgroundImage = Properties.Resources.shovel;
            button6.BackgroundImageLayout = ImageLayout.Center;
            button6.Location = new Point(480, 3);
            button6.Name = "button6";
            button6.Size = new Size(84, 67);
            button6.TabIndex = 5;
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button5
            // 
            button5.BackgroundImage = Properties.Resources.icone_gel;
            button5.BackgroundImageLayout = ImageLayout.Center;
            button5.Location = new Point(349, 3);
            button5.Name = "button5";
            button5.Size = new Size(84, 67);
            button5.TabIndex = 4;
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button4
            // 
            button4.BackgroundImage = Properties.Resources.icone_fleur;
            button4.BackgroundImageLayout = ImageLayout.Center;
            button4.Location = new Point(183, 3);
            button4.Name = "button4";
            button4.Size = new Size(69, 67);
            button4.TabIndex = 3;
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button2
            // 
            button2.BackgroundImage = Properties.Resources.icone_pois_double;
            button2.BackgroundImageLayout = ImageLayout.Center;
            button2.Location = new Point(93, 3);
            button2.Name = "button2";
            button2.Size = new Size(84, 67);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackgroundImage = Properties.Resources.icone_pois;
            button1.BackgroundImageLayout = ImageLayout.Center;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(84, 67);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // sunLabel
            // 
            sunLabel.AutoSize = true;
            sunLabel.Font = new Font("Colonna MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            sunLabel.Location = new Point(33, 17);
            sunLabel.Name = "sunLabel";
            sunLabel.Size = new Size(82, 37);
            sunLabel.TabIndex = 23;
            sunLabel.Text = "Sun:";
            // 
            // scoreLabel
            // 
            scoreLabel.AutoSize = true;
            scoreLabel.Font = new Font("Colonna MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            scoreLabel.Location = new Point(229, 17);
            scoreLabel.Name = "scoreLabel";
            scoreLabel.Size = new Size(120, 37);
            scoreLabel.TabIndex = 24;
            scoreLabel.Text = "Score: ";
            // 
            // roundLabel
            // 
            roundLabel.AutoSize = true;
            roundLabel.Font = new Font("Colonna MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            roundLabel.Location = new Point(466, 17);
            roundLabel.Name = "roundLabel";
            roundLabel.Size = new Size(139, 37);
            roundLabel.TabIndex = 25;
            roundLabel.Text = "Round: ";
            // 
            // playerLabel
            // 
            playerLabel.AutoSize = true;
            playerLabel.Font = new Font("Colonna MT", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playerLabel.Location = new Point(670, 17);
            playerLabel.Name = "playerLabel";
            playerLabel.Size = new Size(135, 37);
            playerLabel.TabIndex = 26;
            playerLabel.Text = "Player: ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1038, 684);
            Controls.Add(playerLabel);
            Controls.Add(roundLabel);
            Controls.Add(scoreLabel);
            Controls.Add(sunLabel);
            Controls.Add(panel1);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Pvz";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Button button6;
        private Button button5;
        private Button button4;
        private Button button2;
        private Button button1;
        private Button button3;
        private Label sunLabel;
        private Label scoreLabel;
        private Label roundLabel;
        private Label playerLabel;
    }
}
