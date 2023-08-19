namespace ExampleSQLApp
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
            components = new System.ComponentModel.Container();
            MainPanel = new Panel();
            EnterButton = new Button();
            PassField = new TextBox();
            PasswordImg = new PictureBox();
            LoginField = new TextBox();
            UserImg = new PictureBox();
            TopPanel = new Panel();
            CloseButton = new Label();
            TitleLabel = new Label();
            TimerCreateTable = new System.Windows.Forms.Timer(components);
            LabelMessage = new Label();
            MainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordImg).BeginInit();
            ((System.ComponentModel.ISupportInitialize)UserImg).BeginInit();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(EnterButton);
            MainPanel.Controls.Add(PassField);
            MainPanel.Controls.Add(PasswordImg);
            MainPanel.Controls.Add(LoginField);
            MainPanel.Controls.Add(UserImg);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(423, 365);
            MainPanel.TabIndex = 0;
            // 
            // EnterButton
            // 
            EnterButton.BackColor = Color.LightSeaGreen;
            EnterButton.Cursor = Cursors.Hand;
            EnterButton.Dock = DockStyle.Bottom;
            EnterButton.FlatAppearance.BorderSize = 0;
            EnterButton.FlatAppearance.MouseDownBackColor = Color.Green;
            EnterButton.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            EnterButton.FlatStyle = FlatStyle.Flat;
            EnterButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            EnterButton.Location = new Point(0, 301);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(423, 64);
            EnterButton.TabIndex = 5;
            EnterButton.Text = "Войти";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
            // 
            // PassField
            // 
            PassField.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            PassField.Location = new Point(95, 197);
            PassField.Name = "PassField";
            PassField.PasswordChar = '#';
            PassField.PlaceholderText = "Пароль";
            PassField.Size = new Size(300, 57);
            PassField.TabIndex = 4;
            // 
            // PasswordImg
            // 
            PasswordImg.Image = Properties.Resources._lock;
            PasswordImg.Location = new Point(25, 197);
            PasswordImg.Name = "PasswordImg";
            PasswordImg.Size = new Size(64, 64);
            PasswordImg.SizeMode = PictureBoxSizeMode.StretchImage;
            PasswordImg.TabIndex = 3;
            PasswordImg.TabStop = false;
            // 
            // LoginField
            // 
            LoginField.Font = new Font("Segoe UI", 28F, FontStyle.Regular, GraphicsUnit.Point);
            LoginField.Location = new Point(95, 109);
            LoginField.Multiline = true;
            LoginField.Name = "LoginField";
            LoginField.PlaceholderText = "Пользователь";
            LoginField.Size = new Size(300, 64);
            LoginField.TabIndex = 2;
            // 
            // UserImg
            // 
            UserImg.Image = Properties.Resources.user;
            UserImg.Location = new Point(25, 109);
            UserImg.Name = "UserImg";
            UserImg.Size = new Size(64, 64);
            UserImg.SizeMode = PictureBoxSizeMode.StretchImage;
            UserImg.TabIndex = 1;
            UserImg.TabStop = false;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.LemonChiffon;
            TopPanel.Controls.Add(CloseButton);
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(423, 65);
            TopPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Gray;
            CloseButton.Location = new Point(396, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            CloseButton.MouseEnter += CloseButton_MouseEnter;
            CloseButton.MouseLeave += CloseButton_MouseLeave;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Salmon;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(423, 65);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Авторизация";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // TimerCreateTable
            // 
            TimerCreateTable.Interval = 10000;
            TimerCreateTable.Tick += TimerCreateTable_Tick;
            // 
            // LabelMessage
            // 
            LabelMessage.AutoSize = true;
            LabelMessage.Location = new Point(0, 0);
            LabelMessage.Name = "LabelMessage";
            LabelMessage.Size = new Size(0, 15);
            LabelMessage.TabIndex = 1;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(423, 365);
            Controls.Add(LabelMessage);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "LoginForm";
            Text = "LoginForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)PasswordImg).EndInit();
            ((System.ComponentModel.ISupportInitialize)UserImg).EndInit();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel MainPanel;
        private Panel TopPanel;
        private Label TitleLabel;
        private Label CloseButton;
        private PictureBox UserImg;
        private TextBox PassField;
        private PictureBox PasswordImg;
        private TextBox LoginField;
        private Button EnterButton;
        private System.Windows.Forms.Timer TimerCreateTable;
        private Label LabelMessage;
    }
}