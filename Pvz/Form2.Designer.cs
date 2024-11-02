namespace Pvz
{
    partial class Form2
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
            loginPanel = new Panel();
            regisBtn = new Button();
            loginBtn = new Button();
            label2 = new Label();
            label1 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            newGameBtn = new Button();
            continueBtn = new Button();
            quitBtn = new Button();
            rankBtn = new Button();
            loginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // loginPanel
            // 
            loginPanel.BackColor = Color.SeaGreen;
            loginPanel.Controls.Add(regisBtn);
            loginPanel.Controls.Add(loginBtn);
            loginPanel.Controls.Add(label2);
            loginPanel.Controls.Add(label1);
            loginPanel.Controls.Add(textBox2);
            loginPanel.Controls.Add(textBox1);
            loginPanel.Location = new Point(259, 189);
            loginPanel.Name = "loginPanel";
            loginPanel.Size = new Size(576, 260);
            loginPanel.TabIndex = 0;
            // 
            // regisBtn
            // 
            regisBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            regisBtn.Location = new Point(220, 194);
            regisBtn.Name = "regisBtn";
            regisBtn.Size = new Size(118, 38);
            regisBtn.TabIndex = 5;
            regisBtn.Text = "Register";
            regisBtn.UseVisualStyleBackColor = true;
            regisBtn.Click += button2_Click;
            // 
            // loginBtn
            // 
            loginBtn.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginBtn.Location = new Point(80, 194);
            loginBtn.Name = "loginBtn";
            loginBtn.Size = new Size(118, 38);
            loginBtn.TabIndex = 4;
            loginBtn.Text = "Login";
            loginBtn.UseVisualStyleBackColor = true;
            loginBtn.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(388, 117);
            label2.Name = "label2";
            label2.Size = new Size(139, 37);
            label2.TabIndex = 3;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(388, 55);
            label1.Name = "label1";
            label1.Size = new Size(158, 37);
            label1.TabIndex = 2;
            label1.Text = "User Name";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox2.Location = new Point(83, 117);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(299, 43);
            textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(83, 55);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(299, 43);
            textBox1.TabIndex = 0;
            // 
            // newGameBtn
            // 
            newGameBtn.BackColor = Color.LimeGreen;
            newGameBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            newGameBtn.Location = new Point(812, 104);
            newGameBtn.Name = "newGameBtn";
            newGameBtn.Size = new Size(143, 62);
            newGameBtn.TabIndex = 1;
            newGameBtn.Text = "New game";
            newGameBtn.UseVisualStyleBackColor = false;
            newGameBtn.Click += newGameBtn_Click;
            // 
            // continueBtn
            // 
            continueBtn.BackColor = Color.LightCoral;
            continueBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            continueBtn.Location = new Point(812, 189);
            continueBtn.Name = "continueBtn";
            continueBtn.Size = new Size(143, 62);
            continueBtn.TabIndex = 2;
            continueBtn.Text = "Continue";
            continueBtn.UseVisualStyleBackColor = false;
            // 
            // quitBtn
            // 
            quitBtn.BackColor = Color.Chocolate;
            quitBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            quitBtn.Location = new Point(812, 358);
            quitBtn.Name = "quitBtn";
            quitBtn.Size = new Size(143, 62);
            quitBtn.TabIndex = 3;
            quitBtn.Text = "Quit";
            quitBtn.UseVisualStyleBackColor = false;
            quitBtn.Click += quitBtn_Click;
            // 
            // rankBtn
            // 
            rankBtn.BackColor = Color.Bisque;
            rankBtn.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            rankBtn.Location = new Point(812, 271);
            rankBtn.Name = "rankBtn";
            rankBtn.Size = new Size(143, 62);
            rankBtn.TabIndex = 4;
            rankBtn.Text = "Ranking";
            rankBtn.UseVisualStyleBackColor = false;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.menu;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1046, 646);
            Controls.Add(rankBtn);
            Controls.Add(quitBtn);
            Controls.Add(continueBtn);
            Controls.Add(newGameBtn);
            Controls.Add(loginPanel);
            Name = "Form2";
            Text = "Form2";
            Load += Form2_Load;
            loginPanel.ResumeLayout(false);
            loginPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel loginPanel;
        private Button regisBtn;
        private Button loginBtn;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button newGameBtn;
        private Button continueBtn;
        private Button quitBtn;
        private Button rankBtn;
    }
}