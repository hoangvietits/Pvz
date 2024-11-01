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
            radioButton6 = new RadioButton();
            radioButton5 = new RadioButton();
            radioButton4 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton1 = new RadioButton();
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
            pictureBox1.MouseDown += Form1_MouseDown;
            // 
            // panel1
            // 
            panel1.BackColor = Color.IndianRed;
            panel1.Controls.Add(radioButton6);
            panel1.Controls.Add(radioButton5);
            panel1.Controls.Add(radioButton4);
            panel1.Controls.Add(radioButton3);
            panel1.Controls.Add(radioButton2);
            panel1.Controls.Add(radioButton1);
            panel1.Location = new Point(283, 592);
            panel1.Name = "panel1";
            panel1.Size = new Size(651, 91);
            panel1.TabIndex = 22;
            // 
            // radioButton6
            // 
            radioButton6.Appearance = Appearance.Button;
            radioButton6.BackColor = Color.Transparent;
            radioButton6.BackgroundImage = Properties.Resources.shovel;
            radioButton6.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton6.Location = new Point(553, 11);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(95, 69);
            radioButton6.TabIndex = 5;
            radioButton6.TabStop = true;
            radioButton6.UseVisualStyleBackColor = false;
            radioButton6.CheckedChanged += radioButton6_CheckedChanged;
            // 
            // radioButton5
            // 
            radioButton5.Appearance = Appearance.Button;
            radioButton5.BackColor = Color.Transparent;
            radioButton5.BackgroundImage = Properties.Resources.icone_noix;
            radioButton5.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton5.Location = new Point(404, 11);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(95, 69);
            radioButton5.TabIndex = 4;
            radioButton5.TabStop = true;
            radioButton5.UseVisualStyleBackColor = false;
            radioButton5.CheckedChanged += radioButton5_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.Appearance = Appearance.Button;
            radioButton4.BackColor = Color.Transparent;
            radioButton4.BackgroundImage = Properties.Resources.icone_gel;
            radioButton4.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton4.Location = new Point(303, 11);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(95, 69);
            radioButton4.TabIndex = 3;
            radioButton4.TabStop = true;
            radioButton4.UseVisualStyleBackColor = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.Appearance = Appearance.Button;
            radioButton3.BackColor = Color.Transparent;
            radioButton3.BackgroundImage = Properties.Resources.icone_fleur;
            radioButton3.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton3.Location = new Point(202, 11);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(95, 69);
            radioButton3.TabIndex = 2;
            radioButton3.TabStop = true;
            radioButton3.UseVisualStyleBackColor = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.Appearance = Appearance.Button;
            radioButton2.BackColor = Color.Transparent;
            radioButton2.BackgroundImage = Properties.Resources.icone_pois_double;
            radioButton2.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton2.Location = new Point(101, 11);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(95, 69);
            radioButton2.TabIndex = 1;
            radioButton2.TabStop = true;
            radioButton2.UseVisualStyleBackColor = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton1
            // 
            radioButton1.Appearance = Appearance.Button;
            radioButton1.BackColor = Color.White;
            radioButton1.BackgroundImage = Properties.Resources.icone_pois;
            radioButton1.BackgroundImageLayout = ImageLayout.Stretch;
            radioButton1.Location = new Point(0, 11);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(95, 69);
            radioButton1.TabIndex = 0;
            radioButton1.TabStop = true;
            radioButton1.UseVisualStyleBackColor = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
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
            Paint += Form_Paint;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }



        #endregion

        private PictureBox pictureBox1;
        private Panel panel1;
        private Label sunLabel;
        private Label scoreLabel;
        private Label roundLabel;
        private Label playerLabel;
        private RadioButton radioButton6;
        private RadioButton radioButton5;
        private RadioButton radioButton4;
        private RadioButton radioButton3;
        private RadioButton radioButton2;
        private RadioButton radioButton1;
    }
}
