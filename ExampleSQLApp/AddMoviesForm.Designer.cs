namespace ExampleSQLApp
{
    partial class AddMoviesForm
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
            DailyRentalCostField = new TextBox();
            DurationField = new TextBox();
            CountryField = new TextBox();
            DirectorField = new TextBox();
            ReleaseYearField = new TextBox();
            TitleField = new TextBox();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            EnterButton = new Button();
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
            MainPanel.Controls.Add(DailyRentalCostField);
            MainPanel.Controls.Add(DurationField);
            MainPanel.Controls.Add(CountryField);
            MainPanel.Controls.Add(DirectorField);
            MainPanel.Controls.Add(ReleaseYearField);
            MainPanel.Controls.Add(TitleField);
            MainPanel.Controls.Add(label6);
            MainPanel.Controls.Add(label5);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label1);
            MainPanel.Controls.Add(EnterButton);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 450);
            MainPanel.TabIndex = 2;
            // 
            // DailyRentalCostField
            // 
            DailyRentalCostField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DailyRentalCostField.Location = new Point(518, 306);
            DailyRentalCostField.Name = "DailyRentalCostField";
            DailyRentalCostField.Size = new Size(232, 34);
            DailyRentalCostField.TabIndex = 18;
            // 
            // DurationField
            // 
            DurationField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DurationField.Location = new Point(518, 213);
            DurationField.Name = "DurationField";
            DurationField.Size = new Size(232, 34);
            DurationField.TabIndex = 17;
            // 
            // CountryField
            // 
            CountryField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CountryField.Location = new Point(518, 128);
            CountryField.Name = "CountryField";
            CountryField.Size = new Size(232, 34);
            CountryField.TabIndex = 16;
            // 
            // DirectorField
            // 
            DirectorField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DirectorField.Location = new Point(47, 306);
            DirectorField.Name = "DirectorField";
            DirectorField.Size = new Size(232, 34);
            DirectorField.TabIndex = 15;
            // 
            // ReleaseYearField
            // 
            ReleaseYearField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseYearField.Location = new Point(47, 213);
            ReleaseYearField.Name = "ReleaseYearField";
            ReleaseYearField.Size = new Size(232, 34);
            ReleaseYearField.TabIndex = 14;
            // 
            // TitleField
            // 
            TitleField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleField.Location = new Point(47, 128);
            TitleField.Name = "TitleField";
            TitleField.Size = new Size(232, 34);
            TitleField.TabIndex = 13;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(518, 276);
            label6.Name = "label6";
            label6.Size = new Size(230, 27);
            label6.TabIndex = 11;
            label6.Text = "Стоимость в день (руб)";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(518, 186);
            label5.Name = "label5";
            label5.Size = new Size(200, 27);
            label5.TabIndex = 10;
            label5.Text = "Продолжительность";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(518, 98);
            label4.Name = "label4";
            label4.Size = new Size(76, 27);
            label4.TabIndex = 9;
            label4.Text = "Страна";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(47, 276);
            label3.Name = "label3";
            label3.Size = new Size(99, 27);
            label3.TabIndex = 8;
            label3.Text = "Режиссёр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(47, 186);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 7;
            label2.Text = "Год выпуска";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(47, 98);
            label1.Name = "label1";
            label1.Size = new Size(152, 27);
            label1.TabIndex = 6;
            label1.Text = "Наименование";
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
            EnterButton.Location = new Point(0, 386);
            EnterButton.Name = "EnterButton";
            EnterButton.Size = new Size(800, 64);
            EnterButton.TabIndex = 5;
            EnterButton.Text = "Добавить";
            EnterButton.UseVisualStyleBackColor = false;
            EnterButton.Click += EnterButton_Click;
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
            CloseButton.Location = new Point(767, 0);
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
            TitleLabel.Text = "Добавление фильма";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // AddMoviesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddMoviesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddMoviesForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button EnterButton;
        private Panel TopPanel;
        private Label CloseButton;
        private Label TitleLabel;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox DailyRentalCostField;
        private TextBox DurationField;
        private TextBox CountryField;
        private TextBox DirectorField;
        private TextBox ReleaseYearField;
        private TextBox TitleField;
    }
}