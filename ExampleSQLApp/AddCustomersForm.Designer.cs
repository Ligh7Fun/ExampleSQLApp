namespace ExampleSQLApp
{
    partial class AddCustomersForm
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
            TitleLabel = new Label();
            RegistrationDateField = new DateTimePicker();
            BirthDateField = new DateTimePicker();
            PhoneNumberField = new TextBox();
            AddressField = new TextBox();
            FullNameField = new TextBox();
            LabelRegistrationDate = new Label();
            LabelBirthDate = new Label();
            LabelPhoneNumber = new Label();
            LabelAddress = new Label();
            LabelFullName = new Label();
            AddButton = new Button();
            TopPanel = new Panel();
            CloseButton = new Label();
            MainPanel = new Panel();
            TopPanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
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
            TitleLabel.Text = "Добавление клиента";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // RegistrationDateField
            // 
            RegistrationDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationDateField.Location = new Point(499, 318);
            RegistrationDateField.Name = "RegistrationDateField";
            RegistrationDateField.Size = new Size(256, 34);
            RegistrationDateField.TabIndex = 18;
            // 
            // BirthDateField
            // 
            BirthDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BirthDateField.Location = new Point(499, 225);
            BirthDateField.Name = "BirthDateField";
            BirthDateField.Size = new Size(256, 34);
            BirthDateField.TabIndex = 15;
            // 
            // PhoneNumberField
            // 
            PhoneNumberField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberField.Location = new Point(41, 318);
            PhoneNumberField.Name = "PhoneNumberField";
            PhoneNumberField.Size = new Size(232, 34);
            PhoneNumberField.TabIndex = 14;
            // 
            // AddressField
            // 
            AddressField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddressField.Location = new Point(41, 217);
            AddressField.Name = "AddressField";
            AddressField.Size = new Size(232, 34);
            AddressField.TabIndex = 13;
            // 
            // FullNameField
            // 
            FullNameField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameField.Location = new Point(41, 124);
            FullNameField.Name = "FullNameField";
            FullNameField.Size = new Size(232, 34);
            FullNameField.TabIndex = 12;
            // 
            // LabelRegistrationDate
            // 
            LabelRegistrationDate.AutoSize = true;
            LabelRegistrationDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRegistrationDate.Location = new Point(499, 288);
            LabelRegistrationDate.Name = "LabelRegistrationDate";
            LabelRegistrationDate.Size = new Size(184, 27);
            LabelRegistrationDate.TabIndex = 10;
            LabelRegistrationDate.Text = "Дата регистрации";
            // 
            // LabelBirthDate
            // 
            LabelBirthDate.AutoSize = true;
            LabelBirthDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBirthDate.Location = new Point(499, 195);
            LabelBirthDate.Name = "LabelBirthDate";
            LabelBirthDate.Size = new Size(155, 27);
            LabelBirthDate.TabIndex = 9;
            LabelBirthDate.Text = "Дата рождения";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumber.Location = new Point(41, 288);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(96, 27);
            LabelPhoneNumber.TabIndex = 8;
            LabelPhoneNumber.Text = "Телефон";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddress.Location = new Point(41, 187);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(68, 27);
            LabelAddress.TabIndex = 7;
            LabelAddress.Text = "Адрес";
            // 
            // LabelFullName
            // 
            LabelFullName.AutoSize = true;
            LabelFullName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFullName.Location = new Point(41, 94);
            LabelFullName.Name = "LabelFullName";
            LabelFullName.Size = new Size(53, 27);
            LabelFullName.TabIndex = 6;
            LabelFullName.Text = "ФИО";
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
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(RegistrationDateField);
            MainPanel.Controls.Add(BirthDateField);
            MainPanel.Controls.Add(PhoneNumberField);
            MainPanel.Controls.Add(AddressField);
            MainPanel.Controls.Add(FullNameField);
            MainPanel.Controls.Add(LabelRegistrationDate);
            MainPanel.Controls.Add(LabelBirthDate);
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
            // AddCustomersForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddCustomersForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddCustomersForm";
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private DateTimePicker RegistrationDateField;
        private DateTimePicker BirthDateField;
        private TextBox PhoneNumberField;
        private TextBox AddressField;
        private TextBox FullNameField;
        private Label LabelRegistrationDate;
        private Label LabelBirthDate;
        private Label LabelPhoneNumber;
        private Label LabelAddress;
        private Label LabelFullName;
        private Button AddButton;
        private Panel TopPanel;
        private Label CloseButton;
        private Panel MainPanel;
    }
}