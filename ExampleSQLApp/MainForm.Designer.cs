namespace ExampleSQLApp
{
    partial class MainForm
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
            TitleLabel = new Label();
            MainPanel = new Panel();
            TabControl = new TabControl();
            Employees = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            listViewEmployees = new ListView();
            panelEmployees = new Panel();
            buttonClear = new Button();
            TerminationDateField = new DateTimePicker();
            HireDateField = new DateTimePicker();
            BirthDateField = new DateTimePicker();
            LabelTerminationDate = new Label();
            LabelHireDate = new Label();
            LabelBirthDate = new Label();
            LabelPhoneNumber = new Label();
            LabelAddress = new Label();
            LabelFullName = new Label();
            PhoneNumberField = new TextBox();
            AddressField = new TextBox();
            FullNameField = new TextBox();
            buttonEditEmployees = new Button();
            buttonDelEmployees = new Button();
            buttonAddEmployees = new Button();
            Customers = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            listViewCustomers = new ListView();
            panelCustomers = new Panel();
            RegistrationDateFieldC = new DateTimePicker();
            BirthDateFieldC = new DateTimePicker();
            LabelRegistrationDateC = new Label();
            LabelBirthDateC = new Label();
            LabelPhoneNumberC = new Label();
            LabelAddressC = new Label();
            LabelFullNameC = new Label();
            PhoneNumberFieldC = new TextBox();
            AddressFieldC = new TextBox();
            FullNameFieldC = new TextBox();
            buttonEditCustomers = new Button();
            buttonDelCustomers = new Button();
            buttonAddCustomers = new Button();
            Movies = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            listViewMovies = new ListView();
            panelMovies = new Panel();
            buttonEditMovies = new Button();
            buttonDelMovies = new Button();
            buttonAddMovies = new Button();
            Rentals = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            listViewRentals = new ListView();
            panelRentals = new Panel();
            buttonEditRentals = new Button();
            buttonDelRentals = new Button();
            buttonAddRentals = new Button();
            Ratings = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            listViewRatings = new ListView();
            panelRatings = new Panel();
            buttonEditRatings = new Button();
            buttonDelRatings = new Button();
            buttonAddRatings = new Button();
            TopPanel = new Panel();
            CloseButton = new Label();
            TimerCreateTable = new System.Windows.Forms.Timer(components);
            MainPanel.SuspendLayout();
            TabControl.SuspendLayout();
            Employees.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panelEmployees.SuspendLayout();
            Customers.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panelCustomers.SuspendLayout();
            Movies.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panelMovies.SuspendLayout();
            Rentals.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            panelRentals.SuspendLayout();
            Ratings.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            panelRatings.SuspendLayout();
            TopPanel.SuspendLayout();
            SuspendLayout();
            // 
            // TitleLabel
            // 
            TitleLabel.Dock = DockStyle.Fill;
            TitleLabel.Font = new Font("Comic Sans MS", 32F, FontStyle.Bold, GraphicsUnit.Point);
            TitleLabel.ForeColor = Color.Salmon;
            TitleLabel.Location = new Point(0, 0);
            TitleLabel.Name = "TitleLabel";
            TitleLabel.Size = new Size(1350, 65);
            TitleLabel.TabIndex = 0;
            TitleLabel.Text = "ExampleSQLApp";
            TitleLabel.TextAlign = ContentAlignment.MiddleCenter;
            TitleLabel.MouseDown += TitleLabel_MouseDown;
            TitleLabel.MouseMove += TitleLabel_MouseMove;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.Teal;
            MainPanel.Controls.Add(TabControl);
            MainPanel.Controls.Add(TopPanel);
            MainPanel.Dock = DockStyle.Fill;
            MainPanel.Location = new Point(0, 0);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(1350, 729);
            MainPanel.TabIndex = 2;
            // 
            // TabControl
            // 
            TabControl.Controls.Add(Employees);
            TabControl.Controls.Add(Customers);
            TabControl.Controls.Add(Movies);
            TabControl.Controls.Add(Rentals);
            TabControl.Controls.Add(Ratings);
            TabControl.Dock = DockStyle.Fill;
            TabControl.Location = new Point(0, 65);
            TabControl.Name = "TabControl";
            TabControl.SelectedIndex = 0;
            TabControl.Size = new Size(1350, 664);
            TabControl.TabIndex = 1;
            TabControl.SelectedIndexChanged += TabControl_SelectedIndexChanged;
            // 
            // Employees
            // 
            Employees.Controls.Add(tableLayoutPanel1);
            Employees.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Employees.Location = new Point(4, 24);
            Employees.Name = "Employees";
            Employees.Padding = new Padding(3);
            Employees.Size = new Size(1342, 636);
            Employees.TabIndex = 0;
            Employees.Text = "Сотрудники";
            Employees.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(listViewEmployees, 0, 0);
            tableLayoutPanel1.Controls.Add(panelEmployees, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(1336, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Dock = DockStyle.Fill;
            listViewEmployees.FullRowSelect = true;
            listViewEmployees.GridLines = true;
            listViewEmployees.Location = new Point(3, 3);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(1330, 498);
            listViewEmployees.TabIndex = 0;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            listViewEmployees.SelectedIndexChanged += listViewEmployees_SelectedIndexChanged;
            listViewEmployees.MouseClick += listViewEmployees_MouseClick;
            // 
            // panelEmployees
            // 
            panelEmployees.Controls.Add(buttonClear);
            panelEmployees.Controls.Add(TerminationDateField);
            panelEmployees.Controls.Add(HireDateField);
            panelEmployees.Controls.Add(BirthDateField);
            panelEmployees.Controls.Add(LabelTerminationDate);
            panelEmployees.Controls.Add(LabelHireDate);
            panelEmployees.Controls.Add(LabelBirthDate);
            panelEmployees.Controls.Add(LabelPhoneNumber);
            panelEmployees.Controls.Add(LabelAddress);
            panelEmployees.Controls.Add(LabelFullName);
            panelEmployees.Controls.Add(PhoneNumberField);
            panelEmployees.Controls.Add(AddressField);
            panelEmployees.Controls.Add(FullNameField);
            panelEmployees.Controls.Add(buttonEditEmployees);
            panelEmployees.Controls.Add(buttonDelEmployees);
            panelEmployees.Controls.Add(buttonAddEmployees);
            panelEmployees.Dock = DockStyle.Fill;
            panelEmployees.Location = new Point(3, 507);
            panelEmployees.Name = "panelEmployees";
            panelEmployees.Size = new Size(1330, 120);
            panelEmployees.TabIndex = 3;
            // 
            // buttonClear
            // 
            buttonClear.Location = new Point(1280, 87);
            buttonClear.Name = "buttonClear";
            buttonClear.Size = new Size(26, 33);
            buttonClear.TabIndex = 33;
            buttonClear.Text = "C";
            buttonClear.UseVisualStyleBackColor = true;
            buttonClear.Click += button1_Click_1;
            // 
            // TerminationDateField
            // 
            TerminationDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TerminationDateField.Location = new Point(1018, 86);
            TerminationDateField.Name = "TerminationDateField";
            TerminationDateField.Size = new Size(256, 34);
            TerminationDateField.TabIndex = 32;
            TerminationDateField.Value = new DateTime(2023, 8, 18, 12, 48, 0, 0);
            TerminationDateField.ValueChanged += TerminationDateField_ValueChanged;
            // 
            // HireDateField
            // 
            HireDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            HireDateField.Location = new Point(1018, 43);
            HireDateField.Name = "HireDateField";
            HireDateField.Size = new Size(256, 34);
            HireDateField.TabIndex = 31;
            // 
            // BirthDateField
            // 
            BirthDateField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BirthDateField.Location = new Point(1018, 3);
            BirthDateField.Name = "BirthDateField";
            BirthDateField.Size = new Size(256, 34);
            BirthDateField.TabIndex = 30;
            // 
            // LabelTerminationDate
            // 
            LabelTerminationDate.AutoSize = true;
            LabelTerminationDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelTerminationDate.Location = new Point(838, 84);
            LabelTerminationDate.Name = "LabelTerminationDate";
            LabelTerminationDate.Size = new Size(174, 27);
            LabelTerminationDate.TabIndex = 29;
            LabelTerminationDate.Text = "Дата увольнения";
            // 
            // LabelHireDate
            // 
            LabelHireDate.AutoSize = true;
            LabelHireDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelHireDate.Location = new Point(887, 50);
            LabelHireDate.Name = "LabelHireDate";
            LabelHireDate.Size = new Size(125, 27);
            LabelHireDate.TabIndex = 28;
            LabelHireDate.Text = "Дата найма";
            // 
            // LabelBirthDate
            // 
            LabelBirthDate.AutoSize = true;
            LabelBirthDate.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBirthDate.Location = new Point(857, 10);
            LabelBirthDate.Name = "LabelBirthDate";
            LabelBirthDate.Size = new Size(155, 27);
            LabelBirthDate.TabIndex = 27;
            LabelBirthDate.Text = "Дата рождения";
            // 
            // LabelPhoneNumber
            // 
            LabelPhoneNumber.AutoSize = true;
            LabelPhoneNumber.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumber.Location = new Point(359, 84);
            LabelPhoneNumber.Name = "LabelPhoneNumber";
            LabelPhoneNumber.Size = new Size(96, 27);
            LabelPhoneNumber.TabIndex = 26;
            LabelPhoneNumber.Text = "Телефон";
            // 
            // LabelAddress
            // 
            LabelAddress.AutoSize = true;
            LabelAddress.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddress.Location = new Point(387, 46);
            LabelAddress.Name = "LabelAddress";
            LabelAddress.Size = new Size(68, 27);
            LabelAddress.TabIndex = 25;
            LabelAddress.Text = "Адрес";
            // 
            // LabelFullName
            // 
            LabelFullName.AutoSize = true;
            LabelFullName.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFullName.Location = new Point(402, 10);
            LabelFullName.Name = "LabelFullName";
            LabelFullName.Size = new Size(53, 27);
            LabelFullName.TabIndex = 24;
            LabelFullName.Text = "ФИО";
            // 
            // PhoneNumberField
            // 
            PhoneNumberField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberField.Location = new Point(461, 84);
            PhoneNumberField.Name = "PhoneNumberField";
            PhoneNumberField.Size = new Size(232, 34);
            PhoneNumberField.TabIndex = 23;
            // 
            // AddressField
            // 
            AddressField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddressField.Location = new Point(461, 43);
            AddressField.Name = "AddressField";
            AddressField.Size = new Size(232, 34);
            AddressField.TabIndex = 22;
            // 
            // FullNameField
            // 
            FullNameField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameField.Location = new Point(461, 3);
            FullNameField.Name = "FullNameField";
            FullNameField.Size = new Size(232, 34);
            FullNameField.TabIndex = 21;
            // 
            // buttonEditEmployees
            // 
            buttonEditEmployees.Enabled = false;
            buttonEditEmployees.Location = new Point(2, 39);
            buttonEditEmployees.Name = "buttonEditEmployees";
            buttonEditEmployees.Size = new Size(215, 30);
            buttonEditEmployees.TabIndex = 3;
            buttonEditEmployees.Text = "Изменить сотрудника";
            buttonEditEmployees.UseVisualStyleBackColor = true;
            buttonEditEmployees.Click += buttonEditEmployees_Click;
            // 
            // buttonDelEmployees
            // 
            buttonDelEmployees.Location = new Point(2, 87);
            buttonDelEmployees.Name = "buttonDelEmployees";
            buttonDelEmployees.Size = new Size(215, 30);
            buttonDelEmployees.TabIndex = 2;
            buttonDelEmployees.Text = "Удалить сотрудника";
            buttonDelEmployees.UseVisualStyleBackColor = true;
            buttonDelEmployees.Click += button1_Click;
            // 
            // buttonAddEmployees
            // 
            buttonAddEmployees.Location = new Point(3, 3);
            buttonAddEmployees.Name = "buttonAddEmployees";
            buttonAddEmployees.Size = new Size(215, 30);
            buttonAddEmployees.TabIndex = 1;
            buttonAddEmployees.Text = "Добавить сотрудника";
            buttonAddEmployees.UseVisualStyleBackColor = true;
            buttonAddEmployees.Click += buttonAddEmployees_Click;
            // 
            // Customers
            // 
            Customers.Controls.Add(tableLayoutPanel2);
            Customers.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Customers.Location = new Point(4, 24);
            Customers.Name = "Customers";
            Customers.Padding = new Padding(3);
            Customers.Size = new Size(1342, 636);
            Customers.TabIndex = 1;
            Customers.Text = "Клиенты";
            Customers.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Controls.Add(listViewCustomers, 0, 0);
            tableLayoutPanel2.Controls.Add(panelCustomers, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(1336, 630);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // listViewCustomers
            // 
            listViewCustomers.Dock = DockStyle.Fill;
            listViewCustomers.FullRowSelect = true;
            listViewCustomers.GridLines = true;
            listViewCustomers.Location = new Point(3, 3);
            listViewCustomers.Name = "listViewCustomers";
            listViewCustomers.Size = new Size(1330, 498);
            listViewCustomers.TabIndex = 0;
            listViewCustomers.UseCompatibleStateImageBehavior = false;
            listViewCustomers.View = View.Details;
            listViewCustomers.SelectedIndexChanged += listViewCustomers_SelectedIndexChanged;
            // 
            // panelCustomers
            // 
            panelCustomers.Controls.Add(RegistrationDateFieldC);
            panelCustomers.Controls.Add(BirthDateFieldC);
            panelCustomers.Controls.Add(LabelRegistrationDateC);
            panelCustomers.Controls.Add(LabelBirthDateC);
            panelCustomers.Controls.Add(LabelPhoneNumberC);
            panelCustomers.Controls.Add(LabelAddressC);
            panelCustomers.Controls.Add(LabelFullNameC);
            panelCustomers.Controls.Add(PhoneNumberFieldC);
            panelCustomers.Controls.Add(AddressFieldC);
            panelCustomers.Controls.Add(FullNameFieldC);
            panelCustomers.Controls.Add(buttonEditCustomers);
            panelCustomers.Controls.Add(buttonDelCustomers);
            panelCustomers.Controls.Add(buttonAddCustomers);
            panelCustomers.Dock = DockStyle.Fill;
            panelCustomers.Location = new Point(3, 507);
            panelCustomers.Name = "panelCustomers";
            panelCustomers.Size = new Size(1330, 120);
            panelCustomers.TabIndex = 3;
            // 
            // RegistrationDateFieldC
            // 
            RegistrationDateFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RegistrationDateFieldC.Location = new Point(1041, 43);
            RegistrationDateFieldC.Name = "RegistrationDateFieldC";
            RegistrationDateFieldC.Size = new Size(256, 34);
            RegistrationDateFieldC.TabIndex = 43;
            // 
            // BirthDateFieldC
            // 
            BirthDateFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BirthDateFieldC.Location = new Point(1041, 3);
            BirthDateFieldC.Name = "BirthDateFieldC";
            BirthDateFieldC.Size = new Size(256, 34);
            BirthDateFieldC.TabIndex = 42;
            // 
            // LabelRegistrationDateC
            // 
            LabelRegistrationDateC.AutoSize = true;
            LabelRegistrationDateC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRegistrationDateC.Location = new Point(851, 49);
            LabelRegistrationDateC.Name = "LabelRegistrationDateC";
            LabelRegistrationDateC.Size = new Size(184, 27);
            LabelRegistrationDateC.TabIndex = 40;
            LabelRegistrationDateC.Text = "Дата регистарции";
            // 
            // LabelBirthDateC
            // 
            LabelBirthDateC.AutoSize = true;
            LabelBirthDateC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBirthDateC.Location = new Point(880, 10);
            LabelBirthDateC.Name = "LabelBirthDateC";
            LabelBirthDateC.Size = new Size(155, 27);
            LabelBirthDateC.TabIndex = 39;
            LabelBirthDateC.Text = "Дата рождения";
            // 
            // LabelPhoneNumberC
            // 
            LabelPhoneNumberC.AutoSize = true;
            LabelPhoneNumberC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumberC.Location = new Point(382, 84);
            LabelPhoneNumberC.Name = "LabelPhoneNumberC";
            LabelPhoneNumberC.Size = new Size(96, 27);
            LabelPhoneNumberC.TabIndex = 38;
            LabelPhoneNumberC.Text = "Телефон";
            // 
            // LabelAddressC
            // 
            LabelAddressC.AutoSize = true;
            LabelAddressC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddressC.Location = new Point(410, 46);
            LabelAddressC.Name = "LabelAddressC";
            LabelAddressC.Size = new Size(68, 27);
            LabelAddressC.TabIndex = 37;
            LabelAddressC.Text = "Адрес";
            // 
            // LabelFullNameC
            // 
            LabelFullNameC.AutoSize = true;
            LabelFullNameC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFullNameC.Location = new Point(425, 10);
            LabelFullNameC.Name = "LabelFullNameC";
            LabelFullNameC.Size = new Size(53, 27);
            LabelFullNameC.TabIndex = 36;
            LabelFullNameC.Text = "ФИО";
            // 
            // PhoneNumberFieldC
            // 
            PhoneNumberFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberFieldC.Location = new Point(484, 84);
            PhoneNumberFieldC.Name = "PhoneNumberFieldC";
            PhoneNumberFieldC.Size = new Size(232, 34);
            PhoneNumberFieldC.TabIndex = 35;
            // 
            // AddressFieldC
            // 
            AddressFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddressFieldC.Location = new Point(484, 43);
            AddressFieldC.Name = "AddressFieldC";
            AddressFieldC.Size = new Size(232, 34);
            AddressFieldC.TabIndex = 34;
            // 
            // FullNameFieldC
            // 
            FullNameFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameFieldC.Location = new Point(484, 3);
            FullNameFieldC.Name = "FullNameFieldC";
            FullNameFieldC.Size = new Size(232, 34);
            FullNameFieldC.TabIndex = 33;
            // 
            // buttonEditCustomers
            // 
            buttonEditCustomers.Location = new Point(3, 39);
            buttonEditCustomers.Name = "buttonEditCustomers";
            buttonEditCustomers.Size = new Size(215, 30);
            buttonEditCustomers.TabIndex = 5;
            buttonEditCustomers.Text = "Изменить клиента";
            buttonEditCustomers.UseVisualStyleBackColor = true;
            buttonEditCustomers.Click += buttonEditCustomers_Click;
            // 
            // buttonDelCustomers
            // 
            buttonDelCustomers.Location = new Point(3, 87);
            buttonDelCustomers.Name = "buttonDelCustomers";
            buttonDelCustomers.Size = new Size(215, 30);
            buttonDelCustomers.TabIndex = 4;
            buttonDelCustomers.Text = "Удалить клиента";
            buttonDelCustomers.UseVisualStyleBackColor = true;
            buttonDelCustomers.Click += buttonDelCustomers_Click;
            // 
            // buttonAddCustomers
            // 
            buttonAddCustomers.Location = new Point(3, 3);
            buttonAddCustomers.Name = "buttonAddCustomers";
            buttonAddCustomers.Size = new Size(215, 30);
            buttonAddCustomers.TabIndex = 2;
            buttonAddCustomers.Text = "Добавить клиента";
            buttonAddCustomers.UseVisualStyleBackColor = true;
            buttonAddCustomers.Click += buttonAddCustomers_Click;
            // 
            // Movies
            // 
            Movies.Controls.Add(tableLayoutPanel3);
            Movies.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Movies.Location = new Point(4, 24);
            Movies.Name = "Movies";
            Movies.Padding = new Padding(3);
            Movies.Size = new Size(1342, 636);
            Movies.TabIndex = 2;
            Movies.Text = "Фильмы";
            Movies.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.Controls.Add(listViewMovies, 0, 0);
            tableLayoutPanel3.Controls.Add(panelMovies, 0, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1336, 630);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // listViewMovies
            // 
            listViewMovies.Dock = DockStyle.Fill;
            listViewMovies.FullRowSelect = true;
            listViewMovies.GridLines = true;
            listViewMovies.Location = new Point(3, 3);
            listViewMovies.Name = "listViewMovies";
            listViewMovies.Size = new Size(1330, 498);
            listViewMovies.TabIndex = 0;
            listViewMovies.UseCompatibleStateImageBehavior = false;
            listViewMovies.View = View.Details;
            listViewMovies.SelectedIndexChanged += listViewMovies_SelectedIndexChanged;
            // 
            // panelMovies
            // 
            panelMovies.Controls.Add(buttonEditMovies);
            panelMovies.Controls.Add(buttonDelMovies);
            panelMovies.Controls.Add(buttonAddMovies);
            panelMovies.Dock = DockStyle.Fill;
            panelMovies.Location = new Point(3, 507);
            panelMovies.Name = "panelMovies";
            panelMovies.Size = new Size(1330, 120);
            panelMovies.TabIndex = 4;
            // 
            // buttonEditMovies
            // 
            buttonEditMovies.Location = new Point(3, 39);
            buttonEditMovies.Name = "buttonEditMovies";
            buttonEditMovies.Size = new Size(215, 30);
            buttonEditMovies.TabIndex = 7;
            buttonEditMovies.Text = "Изменить фильм";
            buttonEditMovies.UseVisualStyleBackColor = true;
            // 
            // buttonDelMovies
            // 
            buttonDelMovies.Location = new Point(3, 87);
            buttonDelMovies.Name = "buttonDelMovies";
            buttonDelMovies.Size = new Size(215, 30);
            buttonDelMovies.TabIndex = 6;
            buttonDelMovies.Text = "Удалить фильм";
            buttonDelMovies.UseVisualStyleBackColor = true;
            // 
            // buttonAddMovies
            // 
            buttonAddMovies.Location = new Point(3, 3);
            buttonAddMovies.Name = "buttonAddMovies";
            buttonAddMovies.Size = new Size(215, 30);
            buttonAddMovies.TabIndex = 3;
            buttonAddMovies.Text = "Добавить фильм";
            buttonAddMovies.UseVisualStyleBackColor = true;
            buttonAddMovies.Click += buttonAddMovies_Click;
            // 
            // Rentals
            // 
            Rentals.Controls.Add(tableLayoutPanel4);
            Rentals.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Rentals.Location = new Point(4, 24);
            Rentals.Name = "Rentals";
            Rentals.Padding = new Padding(3);
            Rentals.Size = new Size(1342, 636);
            Rentals.TabIndex = 3;
            Rentals.Text = "Аренда";
            Rentals.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel4.Controls.Add(listViewRentals, 0, 0);
            tableLayoutPanel4.Controls.Add(panelRentals, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(1336, 630);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // listViewRentals
            // 
            listViewRentals.Dock = DockStyle.Fill;
            listViewRentals.FullRowSelect = true;
            listViewRentals.GridLines = true;
            listViewRentals.Location = new Point(3, 3);
            listViewRentals.Name = "listViewRentals";
            listViewRentals.Size = new Size(1330, 498);
            listViewRentals.TabIndex = 0;
            listViewRentals.UseCompatibleStateImageBehavior = false;
            listViewRentals.View = View.Details;
            listViewRentals.SelectedIndexChanged += listViewRentals_SelectedIndexChanged;
            // 
            // panelRentals
            // 
            panelRentals.Controls.Add(buttonEditRentals);
            panelRentals.Controls.Add(buttonDelRentals);
            panelRentals.Controls.Add(buttonAddRentals);
            panelRentals.Dock = DockStyle.Fill;
            panelRentals.Location = new Point(3, 507);
            panelRentals.Name = "panelRentals";
            panelRentals.Size = new Size(1330, 120);
            panelRentals.TabIndex = 4;
            // 
            // buttonEditRentals
            // 
            buttonEditRentals.Location = new Point(3, 39);
            buttonEditRentals.Name = "buttonEditRentals";
            buttonEditRentals.Size = new Size(215, 30);
            buttonEditRentals.TabIndex = 7;
            buttonEditRentals.Text = "Изменить аренду";
            buttonEditRentals.UseVisualStyleBackColor = true;
            // 
            // buttonDelRentals
            // 
            buttonDelRentals.Location = new Point(3, 87);
            buttonDelRentals.Name = "buttonDelRentals";
            buttonDelRentals.Size = new Size(215, 30);
            buttonDelRentals.TabIndex = 6;
            buttonDelRentals.Text = "Удалить аренду";
            buttonDelRentals.UseVisualStyleBackColor = true;
            // 
            // buttonAddRentals
            // 
            buttonAddRentals.Location = new Point(3, 3);
            buttonAddRentals.Name = "buttonAddRentals";
            buttonAddRentals.Size = new Size(215, 30);
            buttonAddRentals.TabIndex = 3;
            buttonAddRentals.Text = "Добавить аренду";
            buttonAddRentals.UseVisualStyleBackColor = true;
            buttonAddRentals.Click += buttonAddRentals_Click;
            // 
            // Ratings
            // 
            Ratings.Controls.Add(tableLayoutPanel5);
            Ratings.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            Ratings.Location = new Point(4, 24);
            Ratings.Name = "Ratings";
            Ratings.Padding = new Padding(3);
            Ratings.Size = new Size(1342, 636);
            Ratings.TabIndex = 4;
            Ratings.Text = "Оценки";
            Ratings.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 1;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel5.Controls.Add(listViewRatings, 0, 0);
            tableLayoutPanel5.Controls.Add(panelRatings, 0, 1);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(1336, 630);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // listViewRatings
            // 
            listViewRatings.Dock = DockStyle.Fill;
            listViewRatings.FullRowSelect = true;
            listViewRatings.GridLines = true;
            listViewRatings.Location = new Point(3, 3);
            listViewRatings.Name = "listViewRatings";
            listViewRatings.Size = new Size(1330, 498);
            listViewRatings.TabIndex = 0;
            listViewRatings.UseCompatibleStateImageBehavior = false;
            listViewRatings.View = View.Details;
            listViewRatings.SelectedIndexChanged += listViewRatings_SelectedIndexChanged;
            // 
            // panelRatings
            // 
            panelRatings.Controls.Add(buttonEditRatings);
            panelRatings.Controls.Add(buttonDelRatings);
            panelRatings.Controls.Add(buttonAddRatings);
            panelRatings.Dock = DockStyle.Fill;
            panelRatings.Location = new Point(3, 507);
            panelRatings.Name = "panelRatings";
            panelRatings.Size = new Size(1330, 120);
            panelRatings.TabIndex = 4;
            // 
            // buttonEditRatings
            // 
            buttonEditRatings.Location = new Point(3, 39);
            buttonEditRatings.Name = "buttonEditRatings";
            buttonEditRatings.Size = new Size(215, 30);
            buttonEditRatings.TabIndex = 7;
            buttonEditRatings.Text = "Изменить оценку";
            buttonEditRatings.UseVisualStyleBackColor = true;
            // 
            // buttonDelRatings
            // 
            buttonDelRatings.Location = new Point(3, 87);
            buttonDelRatings.Name = "buttonDelRatings";
            buttonDelRatings.Size = new Size(215, 30);
            buttonDelRatings.TabIndex = 6;
            buttonDelRatings.Text = "Удалить оценку";
            buttonDelRatings.UseVisualStyleBackColor = true;
            // 
            // buttonAddRatings
            // 
            buttonAddRatings.Location = new Point(3, 3);
            buttonAddRatings.Name = "buttonAddRatings";
            buttonAddRatings.Size = new Size(215, 30);
            buttonAddRatings.TabIndex = 3;
            buttonAddRatings.Text = "Добавить оценку";
            buttonAddRatings.UseVisualStyleBackColor = true;
            buttonAddRatings.Click += buttonAddRatings_Click;
            // 
            // TopPanel
            // 
            TopPanel.BackColor = Color.LemonChiffon;
            TopPanel.Controls.Add(CloseButton);
            TopPanel.Controls.Add(TitleLabel);
            TopPanel.Dock = DockStyle.Top;
            TopPanel.Location = new Point(0, 0);
            TopPanel.Name = "TopPanel";
            TopPanel.Size = new Size(1350, 65);
            TopPanel.TabIndex = 0;
            // 
            // CloseButton
            // 
            CloseButton.AutoSize = true;
            CloseButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            CloseButton.ForeColor = Color.Gray;
            CloseButton.Location = new Point(1320, 0);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(30, 32);
            CloseButton.TabIndex = 2;
            CloseButton.Text = "X";
            CloseButton.Click += CloseButton_Click;
            // 
            // TimerCreateTable
            // 
            TimerCreateTable.Interval = 10000;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(MainPanel);
            FormBorderStyle = FormBorderStyle.None;
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "MainForm";
            MainPanel.ResumeLayout(false);
            TabControl.ResumeLayout(false);
            Employees.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panelEmployees.ResumeLayout(false);
            panelEmployees.PerformLayout();
            Customers.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panelCustomers.ResumeLayout(false);
            panelCustomers.PerformLayout();
            Movies.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panelMovies.ResumeLayout(false);
            Rentals.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panelRentals.ResumeLayout(false);
            Ratings.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panelRatings.ResumeLayout(false);
            TopPanel.ResumeLayout(false);
            TopPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label TitleLabel;
        private Panel MainPanel;
        private Panel TopPanel;
        private System.Windows.Forms.Timer TimerCreateTable;
        private Label CloseButton;
        private TabControl TabControl;
        private TabPage Employees;
        private TabPage Customers;
        private TabPage Movies;
        private TabPage Rentals;
        private TabPage Ratings;
        private TableLayoutPanel tableLayoutPanel2;
        private ListView listViewCustomers;
        private TableLayoutPanel tableLayoutPanel3;
        private ListView listViewMovies;
        private TableLayoutPanel tableLayoutPanel4;
        private ListView listViewRentals;
        private TableLayoutPanel tableLayoutPanel5;
        private ListView listViewRatings;
        private Button buttonAddCustomers;
        private Button buttonAddMovies;
        private Button buttonAddRentals;
        private Button buttonAddRatings;
        private TableLayoutPanel tableLayoutPanel1;
        private ListView listViewEmployees;
        private Button buttonAddEmployees;
        private Button buttonDelEmployees;
        private Panel panelEmployees;
        private Button buttonEditEmployees;
        private Panel panelCustomers;
        private Panel panelMovies;
        private Panel panelRentals;
        private Button buttonEditCustomers;
        private Button buttonDelCustomers;
        private Button buttonEditMovies;
        private Button buttonDelMovies;
        private Button buttonEditRentals;
        private Button buttonDelRentals;
        private Panel panelRatings;
        private Button buttonEditRatings;
        private Button buttonDelRatings;
        private DateTimePicker TerminationDateField;
        private DateTimePicker HireDateField;
        private DateTimePicker BirthDateField;
        private Label LabelTerminationDate;
        private Label LabelHireDate;
        private Label LabelBirthDate;
        private Label LabelPhoneNumber;
        private Label LabelAddress;
        private Label LabelFullName;
        private TextBox PhoneNumberField;
        private TextBox AddressField;
        private TextBox FullNameField;
        private Button buttonClear;
        private DateTimePicker RegistrationDateFieldC;
        private DateTimePicker BirthDateFieldC;
        private Label LabelRegistrationDateC;
        private Label LabelBirthDateC;
        private Label LabelPhoneNumberC;
        private Label LabelAddressC;
        private Label LabelFullNameC;
        private TextBox PhoneNumberFieldC;
        private TextBox AddressFieldC;
        private TextBox FullNameFieldC;
    }
}