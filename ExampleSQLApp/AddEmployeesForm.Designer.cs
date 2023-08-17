namespace ExampleSQLApp
{
    partial class AddEmployeesForm
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
            TerminationDateField = new DateTimePicker();
            HireDateField = new DateTimePicker();
            BirthDateField = new DateTimePicker();
            PhoneNumberField = new TextBox();
            AddressField = new TextBox();
            FullNameField = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            LabelPhoneNumber = new Label();
            LabelAddress = new Label();
            LabelFullName = new Label();
            AddButton = new Button();
            TopPanel = new Panel();
            CloseButton = new Label();
            TitleLabel = new Label();
            TimerCreateTable = new System.Windows.Forms.Timer(components);
            MainPanel.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(TerminationDateField);
            MainPanel.Controls.Add(HireDateField);
            MainPanel.Controls.Add(BirthDateField);
            MainPanel.Controls.Add(PhoneNumberField);
            MainPanel.Controls.Add(AddressField);
            MainPanel.Controls.Add(FullNameField);
            MainPanel.Controls.Add(label1);
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
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // TerminationDateField
            // 
            TerminationDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TerminationDateField.Location = new Point(497, 318);
            TerminationDateField.Name = "TerminationDateField";
            TerminationDateField.Size = new Size(256, 34);
            TerminationDateField.TabIndex = 19;
            TerminationDateField.ValueChanged += TerminationDateField_ValueChanged;
            // 
            // HireDateField
            // 
            HireDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HireDateField.Location = new Point(497, 217);
            HireDateField.Name = "HireDateField";
            HireDateField.Size = new Size(256, 34);
            HireDateField.TabIndex = 18;
            HireDateField.ValueChanged += HireDateField_ValueChanged;
            // 
            // BirthDateField
            // 
            BirthDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BirthDateField.Location = new Point(497, 124);
            BirthDateField.Name = "BirthDateField";
            BirthDateField.Size = new Size(256, 34);
            BirthDateField.TabIndex = 15;
            BirthDateField.ValueChanged += BirthDateField_ValueChanged;
            // 
            // PhoneNumberField
            // 
            PhoneNumberField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberField.Location = new Point(41, 318);
            PhoneNumberField.Name = "PhoneNumberField";
            PhoneNumberField.Size = new Size(232, 34);
            PhoneNumberField.TabIndex = 14;
            PhoneNumberField.TextChanged += PhoneNumberField_TextChanged;
            // 
            // AddressField
            // 
            AddressField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddressField.Location = new Point(41, 217);
            AddressField.Name = "AddressField";
            AddressField.Size = new Size(232, 34);
            AddressField.TabIndex = 13;
            AddressField.TextChanged += AddressField_TextChanged;
            // 
            // FullNameField
            // 
            FullNameField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameField.Location = new Point(41, 124);
            FullNameField.Name = "FullNameField";
            FullNameField.Size = new Size(232, 34);
            FullNameField.TabIndex = 12;
            FullNameField.TextChanged += FullNameField_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(497, 288);
            label1.Name = "label1";
            label1.Size = new Size(174, 27);
            label1.TabIndex = 11;
            label1.Text = "Дата увольнения";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(497, 187);
            label2.Name = "label2";
            label2.Size = new Size(125, 27);
            label2.TabIndex = 10;
            label2.Text = "Дата найма";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(497, 94);
            label3.Name = "label3";
            label3.Size = new Size(155, 27);
            label3.TabIndex = 9;
            label3.Text = "Дата рождения";
            label3.Click += label3_Click;
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
            LabelPhoneNumber.Click += LabelPhoneNumber_Click;
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
            LabelAddress.Click += LabelAddress_Click;
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
            LabelFullName.Click += LabelFullName_Click;
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
            TopPanel.Paint += TopPanel_Paint;
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
            TitleLabel.Text = "Добавление сотрудника";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.Click += TitleLabel_Click;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // TimerCreateTable
            // 
            TimerCreateTable.Interval = 10000;
            TimerCreateTable.Tick += TimerCreateTable_Tick;
            // 
            // AddEmployeesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AddEmployeesForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AddEmployeesForm";
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel MainPanel;
        private Button AddButton;
        private Panel TopPanel;
        private Label CloseButton;
        private Label TitleLabel;
        private System.Windows.Forms.Timer TimerCreateTable;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label LabelPhoneNumber;
        private Label LabelAddress;
        private Label LabelFullName;
        private DateTimePicker TerminationDateField;
        private DateTimePicker HireDateField;
        private DateTimePicker BirthDateField;
        private TextBox PhoneNumberField;
        private TextBox AddressField;
        private TextBox FullNameField;
    }
}