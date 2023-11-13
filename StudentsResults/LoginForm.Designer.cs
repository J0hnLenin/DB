namespace StudentsResults
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            MainLabel = new Label();
            LoginTextBox = new TextBox();
            PasswordTextBox = new TextBox();
            EnterButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(61, 82);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(73, 72);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Key;
            pictureBox2.Location = new Point(61, 177);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(73, 74);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // MainLabel
            // 
            MainLabel.AutoSize = true;
            MainLabel.BackColor = SystemColors.GradientInactiveCaption;
            MainLabel.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            MainLabel.Location = new Point(152, 25);
            MainLabel.Name = "MainLabel";
            MainLabel.Size = new Size(418, 37);
            MainLabel.TabIndex = 2;
            MainLabel.Text = "Введите данные учётной записи";
            MainLabel.Click += MainLabel_Click;
            // 
            // LoginTextBox
            // 
            LoginTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            LoginTextBox.Location = new Point(152, 96);
            LoginTextBox.Name = "LoginTextBox";
            LoginTextBox.Size = new Size(509, 43);
            LoginTextBox.TabIndex = 3;
            // 
            // PasswordTextBox
            // 
            PasswordTextBox.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordTextBox.Location = new Point(152, 193);
            PasswordTextBox.Name = "PasswordTextBox";
            PasswordTextBox.PasswordChar = '*';
            PasswordTextBox.Size = new Size(509, 43);
            PasswordTextBox.TabIndex = 4;
            // 
            // EnterButton
            // 
            EnterButton.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            EnterButton.Location = new Point(244, 265);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(235, 53);
            EnterButton.TabIndex = 5;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.GradientInactiveCaption;
            ClientSize = new Size(734, 361);
            Controls.Add(EnterButton);
            Controls.Add(PasswordTextBox);
            Controls.Add(LoginTextBox);
            Controls.Add(MainLabel);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "LoginForm";
            Text = "Авторизация";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label MainLabel;
        private TextBox LoginTextBox;
        private TextBox PasswordTextBox;
        private Button EnterButton;
    }
}