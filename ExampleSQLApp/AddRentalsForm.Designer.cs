namespace ExampleSQLApp
{
    partial class AddRentalsForm
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
            RentalReturnDate = new DateTimePicker();
            RentalStartDate = new DateTimePicker();
            CloseButton = new Label();
            label2 = new Label();
            LabelPhoneNumber = new Label();
            LabelAddress = new Label();
            LabelFullName = new Label();
            AddButton = new Button();
            TopPanel = new Panel();
            TitleLabel = new Label();
            label3 = new Label();
            MainPanel = new Panel();
            ComboBoxMovie = new ComboBox();
            ComboBoxEmployee = new ComboBox();
            ComboBoxCustomer = new ComboBox();
            TopPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // RentalReturnDate
            // 
            RentalReturnDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RentalReturnDate.Location = new Point(497, 217);
            RentalReturnDate.Name = "RentalReturnDate";
            RentalReturnDate.Size = new Size(256, 34);
            RentalReturnDate.TabIndex = 18;
            // 
            // RentalStartDate
            // 
            RentalStartDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RentalStartDate.Location = new Point(497, 124);
            RentalStartDate.Name = "RentalStartDate";
            RentalStartDate.Size = new Size(256, 34);
            RentalStartDate.TabIndex = 15;
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
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(497, 187);
            label2.Name = "label2";
            label2.Size = new Size(146, 27);
            label2.TabIndex = 10;
            label2.Text = "Дата возврата";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumber.Location = new Point(41, 288);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(71, 27);
            LabelPhoneNumber.TabIndex = 8;
            LabelPhoneNumber.Text = "Фильм";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddress.Location = new Point(41, 187);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(108, 27);
            LabelAddress.TabIndex = 7;
            LabelAddress.Text = "Сотрудник";
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
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Salmon;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(800, 65);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "Добавление аренды";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(497, 94);
            label3.Name = "label3";
            label3.Size = new Size(166, 27);
            label3.TabIndex = 9;
            label3.Text = "Дата получения";
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(ComboBoxMovie);
            MainPanel.Controls.Add(ComboBoxEmployee);
            MainPanel.Controls.Add(ComboBoxCustomer);
            MainPanel.Controls.Add(RentalReturnDate);
            MainPanel.Controls.Add(RentalStartDate);
            MainPanel.Controls.Add(label2);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(LabelPhoneNumber);
            MainPanel.Controls.Add(LabelAddress);
            MainPanel.Controls.Add(LabelFullName);
            MainPanel.Controls.Add(AddButton);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(800, 450);
            MainPanel.TabIndex = 3;
            // 
            // ComboBoxMovie
            // 
            ComboBoxMovie.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxMovie.FormattingEnabled = true;
            ComboBoxMovie.Location = new Point(41, 318);
            ComboBoxMovie.Name = "ComboBoxMovie";
            ComboBoxMovie.Size = new Size(256, 35);
            ComboBoxMovie.TabIndex = 21;
            // 
            // ComboBoxEmployee
            // 
            ComboBoxEmployee.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxEmployee.FormattingEnabled = true;
            ComboBoxEmployee.Location = new Point(41, 220);
            ComboBoxEmployee.Name = "ComboBoxEmployee";
            ComboBoxEmployee.Size = new Size(256, 35);
            ComboBoxEmployee.TabIndex = 20;
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
            // AddRentalsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddRentalsForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddRentalsForm";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion
        private DateTimePicker RentalReturnDate;
        private DateTimePicker RentalStartDate;
        private Label CloseButton;
        private Label label2;
        private Label LabelPhoneNumber;
        private Label LabelAddress;
        private Label LabelFullName;
        private Button AddButton;
        private Panel TopPanel;
        private Label TitleLabel;
        private Label label3;
        private Panel MainPanel;
        private ComboBox ComboBoxCustomer;
        private ComboBox ComboBoxMovie;
        private ComboBox ComboBoxEmployee;
    }
}