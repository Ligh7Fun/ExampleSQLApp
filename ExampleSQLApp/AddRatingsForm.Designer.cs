namespace ExampleSQLApp
{
    partial class AddRatingsForm
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
            MainPanel = new Panel();
            CommentField = new TextBox();
            RatingField = new TextBox();
            ComboBoxMovie = new ComboBox();
            ComboBoxCustomer = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            LabelPhoneNumber = new Label();
            LabelFullName = new Label();
            AddButton = new Button();
            TopPanel = new Panel();
            CloseButton = new Label();
            TitleLabel = new Label();
            MainPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(CommentField);
            MainPanel.Controls.Add(RatingField);
            MainPanel.Controls.Add(ComboBoxMovie);
            MainPanel.Controls.Add(ComboBoxCustomer);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(LabelPhoneNumber);
            MainPanel.Controls.Add(LabelFullName);
            MainPanel.Controls.Add(AddButton);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 450);
            MainPanel.TabIndex = 4;
            // 
            // CommentField
            // 
            CommentField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CommentField.Location = new Point(494, 140);
            CommentField.MaxLength = 100;
            CommentField.Multiline = true;
            CommentField.Name = "CommentField";
            CommentField.Size = new Size(250, 212);
            CommentField.TabIndex = 41;
            // 
            // RatingField
            // 
            RatingField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RatingField.Location = new Point(41, 318);
            RatingField.Name = "RatingField";
            RatingField.Size = new Size(256, 34);
            RatingField.TabIndex = 40;
            RatingField.KeyPress += RatingField_KeyPress;
            // 
            // ComboBoxMovie
            // 
            ComboBoxMovie.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxMovie.FormattingEnabled = true;
            ComboBoxMovie.Location = new Point(41, 217);
            ComboBoxMovie.Name = "ComboBoxMovie";
            ComboBoxMovie.Size = new Size(256, 35);
            ComboBoxMovie.TabIndex = 21;
            // 
            // ComboBoxCustomer
            // 
            ComboBoxCustomer.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxCustomer.FormattingEnabled = true;
            ComboBoxCustomer.Location = new Point(41, 127);
            ComboBoxCustomer.Name = "ComboBoxCustomer";
            ComboBoxCustomer.Size = new Size(256, 35);
            ComboBoxCustomer.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(494, 110);
            label2.Name = "label2";
            label2.Size = new Size(139, 27);
            label2.TabIndex = 10;
            label2.Text = "Комментарий";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(41, 288);
            label3.Name = "label3";
            label3.Size = new Size(86, 27);
            label3.TabIndex = 9;
            label3.Text = "Рейтинг";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumber.Location = new Point(41, 187);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(71, 27);
            LabelPhoneNumber.TabIndex = 8;
            LabelPhoneNumber.Text = "Фильм";
            // 
            // LabelFullName
            // 
            LabelFullName.AutoSize = true;
            LabelFullName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFullName.Location = new Point(41, 94);
            LabelFullName.Name = "LabelFullName";
            LabelFullName.Size = new Size(79, 27);
            LabelFullName.TabIndex = 6;
            LabelFullName.Text = "Клиент";
            // 
            // AddButton
            // 
            AddButton.BackColor = Color.LightSeaGreen;
            AddButton.Cursor = Cursors.Hand;
            AddButton.Dock = DockStyle.Bottom;
            AddButton.FlatAppearance.BorderSize = 0;
            AddButton.FlatAppearance.MouseDownBackColor = Color.Green;
            AddButton.FlatAppearance.MouseOverBackColor = Color.Moccasin;
            AddButton.FlatStyle = FlatStyle.Flat;
            AddButton.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            AddButton.Location = new Point(0, 386);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(800, 64);
            AddButton.TabIndex = 5;
            AddButton.Text = "Добавить";
            AddButton.UseVisualStyleBackColor = false;
            AddButton.Click += AddButton_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.LemonChiffon;
            TopPanel.Controls.Add(CloseButton);
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(800, 65);
            TopPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Gray;
            CloseButton.Location = new Point(770, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 1;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Salmon;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(800, 65);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Добавление оценки";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // AddRatingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRatingsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddRatingsForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private ComboBox ComboBoxMovie;
        private ComboBox ComboBoxCustomer;
        private Label label2;
        private Label label3;
        private Label LabelPhoneNumber;
        private Label LabelFullName;
        private Button AddButton;
        private Panel TopPanel;
        private Label CloseButton;
        private Label TitleLabel;
        private TextBox CommentField;
        private TextBox RatingField;
    }
}