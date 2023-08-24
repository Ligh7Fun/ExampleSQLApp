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
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            DailyRentalCostFieldM = new TextBox();
            DurationFieldM = new TextBox();
            CountryFieldM = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            DirectorFieldM = new TextBox();
            ReleaseYearFieldM = new TextBox();
            TitleFieldM = new TextBox();
            buttonEditMovies = new Button();
            buttonDelMovies = new Button();
            buttonAddMovies = new Button();
            Rentals = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            listViewRentals = new ListView();
            panelRentals = new Panel();
            RentalReturnDateR = new DateTimePicker();
            label11 = new Label();
            RentalStartDateR = new DateTimePicker();
            label10 = new Label();
            ComboBoxMovieR = new ComboBox();
            label9 = new Label();
            ComboBoxEmployeeR = new ComboBox();
            label8 = new Label();
            ComboBoxCustomerR = new ComboBox();
            label7 = new Label();
            buttonEditRentals = new Button();
            buttonDelRentals = new Button();
            buttonAddRentals = new Button();
            Ratings = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            listViewRatings = new ListView();
            panelRatings = new Panel();
            label15 = new Label();
            CommentField = new TextBox();
            label14 = new Label();
            RatingField = new TextBox();
            ComboBoxMovieRatings = new ComboBox();
            label12 = new Label();
            ComboBoxCustomersRating = new ComboBox();
            label13 = new Label();
            buttonEditRatings = new Button();
            buttonDelRatings = new Button();
            buttonAddRatings = new Button();
            Reports = new TabPage();
            DateTimeEndSalary = new DateTimePicker();
            DateTimeStartSalary = new DateTimePicker();
            SalaryReport = new Button();
            RatingsReport = new Button();
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
            Reports.SuspendLayout();
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
            TabControl.Controls.Add(Reports);
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
            RegistrationDateFieldC.Location = new Point(1010, 43);
            RegistrationDateFieldC.Name = "RegistrationDateFieldC";
            RegistrationDateFieldC.Size = new Size(256, 34);
            RegistrationDateFieldC.TabIndex = 43;
            // 
            // BirthDateFieldC
            // 
            BirthDateFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            BirthDateFieldC.Location = new Point(1010, 3);
            BirthDateFieldC.Name = "BirthDateFieldC";
            BirthDateFieldC.Size = new Size(256, 34);
            BirthDateFieldC.TabIndex = 42;
            // 
            // LabelRegistrationDateC
            // 
            LabelRegistrationDateC.AutoSize = true;
            LabelRegistrationDateC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelRegistrationDateC.Location = new Point(820, 49);
            LabelRegistrationDateC.Name = "LabelRegistrationDateC";
            LabelRegistrationDateC.Size = new Size(184, 27);
            LabelRegistrationDateC.TabIndex = 40;
            LabelRegistrationDateC.Text = "Дата регистарции";
            // 
            // LabelBirthDateC
            // 
            LabelBirthDateC.AutoSize = true;
            LabelBirthDateC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelBirthDateC.Location = new Point(849, 10);
            LabelBirthDateC.Name = "LabelBirthDateC";
            LabelBirthDateC.Size = new Size(155, 27);
            LabelBirthDateC.TabIndex = 39;
            LabelBirthDateC.Text = "Дата рождения";
            // 
            // LabelPhoneNumberC
            // 
            LabelPhoneNumberC.AutoSize = true;
            LabelPhoneNumberC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelPhoneNumberC.Location = new Point(359, 84);
            LabelPhoneNumberC.Name = "LabelPhoneNumberC";
            LabelPhoneNumberC.Size = new Size(96, 27);
            LabelPhoneNumberC.TabIndex = 38;
            LabelPhoneNumberC.Text = "Телефон";
            // 
            // LabelAddressC
            // 
            LabelAddressC.AutoSize = true;
            LabelAddressC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelAddressC.Location = new Point(387, 46);
            LabelAddressC.Name = "LabelAddressC";
            LabelAddressC.Size = new Size(68, 27);
            LabelAddressC.TabIndex = 37;
            LabelAddressC.Text = "Адрес";
            // 
            // LabelFullNameC
            // 
            LabelFullNameC.AutoSize = true;
            LabelFullNameC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            LabelFullNameC.Location = new Point(402, 10);
            LabelFullNameC.Name = "LabelFullNameC";
            LabelFullNameC.Size = new Size(53, 27);
            LabelFullNameC.TabIndex = 36;
            LabelFullNameC.Text = "ФИО";
            // 
            // PhoneNumberFieldC
            // 
            PhoneNumberFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            PhoneNumberFieldC.Location = new Point(461, 84);
            PhoneNumberFieldC.Name = "PhoneNumberFieldC";
            PhoneNumberFieldC.Size = new Size(232, 34);
            PhoneNumberFieldC.TabIndex = 35;
            // 
            // AddressFieldC
            // 
            AddressFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            AddressFieldC.Location = new Point(461, 43);
            AddressFieldC.Name = "AddressFieldC";
            AddressFieldC.Size = new Size(232, 34);
            AddressFieldC.TabIndex = 34;
            // 
            // FullNameFieldC
            // 
            FullNameFieldC.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            FullNameFieldC.Location = new Point(461, 3);
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
            panelMovies.Controls.Add(label4);
            panelMovies.Controls.Add(label5);
            panelMovies.Controls.Add(label6);
            panelMovies.Controls.Add(DailyRentalCostFieldM);
            panelMovies.Controls.Add(DurationFieldM);
            panelMovies.Controls.Add(CountryFieldM);
            panelMovies.Controls.Add(label1);
            panelMovies.Controls.Add(label2);
            panelMovies.Controls.Add(label3);
            panelMovies.Controls.Add(DirectorFieldM);
            panelMovies.Controls.Add(ReleaseYearFieldM);
            panelMovies.Controls.Add(TitleFieldM);
            panelMovies.Controls.Add(buttonEditMovies);
            panelMovies.Controls.Add(buttonDelMovies);
            panelMovies.Controls.Add(buttonAddMovies);
            panelMovies.Dock = DockStyle.Fill;
            panelMovies.Location = new Point(3, 507);
            panelMovies.Name = "panelMovies";
            panelMovies.Size = new Size(1330, 120);
            panelMovies.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(827, 87);
            label4.Name = "label4";
            label4.Size = new Size(177, 27);
            label4.TabIndex = 50;
            label4.Text = "Стоимость в день";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(804, 50);
            label5.Name = "label5";
            label5.Size = new Size(200, 27);
            label5.TabIndex = 49;
            label5.Text = "Продолжительность";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(928, 10);
            label6.Name = "label6";
            label6.Size = new Size(76, 27);
            label6.TabIndex = 48;
            label6.Text = "Страна";
            // 
            // DailyRentalCostFieldM
            // 
            DailyRentalCostFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DailyRentalCostFieldM.Location = new Point(1010, 83);
            DailyRentalCostFieldM.Name = "DailyRentalCostFieldM";
            DailyRentalCostFieldM.Size = new Size(232, 34);
            DailyRentalCostFieldM.TabIndex = 47;
            DailyRentalCostFieldM.KeyPress += textBox4_KeyPress;
            // 
            // DurationFieldM
            // 
            DurationFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DurationFieldM.Location = new Point(1010, 43);
            DurationFieldM.Name = "DurationFieldM";
            DurationFieldM.Size = new Size(232, 34);
            DurationFieldM.TabIndex = 46;
            DurationFieldM.KeyPress += textBox5_KeyPress;
            // 
            // CountryFieldM
            // 
            CountryFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CountryFieldM.Location = new Point(1010, 3);
            CountryFieldM.Name = "CountryFieldM";
            CountryFieldM.Size = new Size(232, 34);
            CountryFieldM.TabIndex = 45;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(356, 84);
            label1.Name = "label1";
            label1.Size = new Size(99, 27);
            label1.TabIndex = 44;
            label1.Text = "Режиссёр";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(325, 46);
            label2.Name = "label2";
            label2.Size = new Size(130, 27);
            label2.TabIndex = 43;
            label2.Text = "Год выпуска";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(303, 10);
            label3.Name = "label3";
            label3.Size = new Size(152, 27);
            label3.TabIndex = 42;
            label3.Text = "Наименование";
            // 
            // DirectorFieldM
            // 
            DirectorFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            DirectorFieldM.Location = new Point(461, 83);
            DirectorFieldM.Name = "DirectorFieldM";
            DirectorFieldM.Size = new Size(232, 34);
            DirectorFieldM.TabIndex = 41;
            // 
            // ReleaseYearFieldM
            // 
            ReleaseYearFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ReleaseYearFieldM.Location = new Point(461, 43);
            ReleaseYearFieldM.Name = "ReleaseYearFieldM";
            ReleaseYearFieldM.Size = new Size(232, 34);
            ReleaseYearFieldM.TabIndex = 40;
            ReleaseYearFieldM.KeyPress += textBox2_KeyPress;
            // 
            // TitleFieldM
            // 
            TitleFieldM.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            TitleFieldM.Location = new Point(461, 3);
            TitleFieldM.Name = "TitleFieldM";
            TitleFieldM.Size = new Size(232, 34);
            TitleFieldM.TabIndex = 39;
            // 
            // buttonEditMovies
            // 
            buttonEditMovies.Location = new Point(3, 39);
            buttonEditMovies.Name = "buttonEditMovies";
            buttonEditMovies.Size = new Size(215, 30);
            buttonEditMovies.TabIndex = 7;
            buttonEditMovies.Text = "Изменить фильм";
            buttonEditMovies.UseVisualStyleBackColor = true;
            buttonEditMovies.Click += buttonEditMovies_Click;
            // 
            // buttonDelMovies
            // 
            buttonDelMovies.Location = new Point(3, 87);
            buttonDelMovies.Name = "buttonDelMovies";
            buttonDelMovies.Size = new Size(215, 30);
            buttonDelMovies.TabIndex = 6;
            buttonDelMovies.Text = "Удалить фильм";
            buttonDelMovies.UseVisualStyleBackColor = true;
            buttonDelMovies.Click += buttonDelMovies_Click;
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
            panelRentals.Controls.Add(RentalReturnDateR);
            panelRentals.Controls.Add(label11);
            panelRentals.Controls.Add(RentalStartDateR);
            panelRentals.Controls.Add(label10);
            panelRentals.Controls.Add(ComboBoxMovieR);
            panelRentals.Controls.Add(label9);
            panelRentals.Controls.Add(ComboBoxEmployeeR);
            panelRentals.Controls.Add(label8);
            panelRentals.Controls.Add(ComboBoxCustomerR);
            panelRentals.Controls.Add(label7);
            panelRentals.Controls.Add(buttonEditRentals);
            panelRentals.Controls.Add(buttonDelRentals);
            panelRentals.Controls.Add(buttonAddRentals);
            panelRentals.Dock = DockStyle.Fill;
            panelRentals.Location = new Point(3, 507);
            panelRentals.Name = "panelRentals";
            panelRentals.Size = new Size(1330, 120);
            panelRentals.TabIndex = 4;
            // 
            // RentalReturnDateR
            // 
            RentalReturnDateR.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RentalReturnDateR.Location = new Point(1010, 44);
            RentalReturnDateR.Name = "RentalReturnDateR";
            RentalReturnDateR.Size = new Size(256, 34);
            RentalReturnDateR.TabIndex = 29;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label11.Location = new Point(858, 47);
            label11.Name = "label11";
            label11.Size = new Size(146, 27);
            label11.TabIndex = 28;
            label11.Text = "Дата возврата";
            // 
            // RentalStartDateR
            // 
            RentalStartDateR.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RentalStartDateR.Location = new Point(1010, 3);
            RentalStartDateR.Name = "RentalStartDateR";
            RentalStartDateR.Size = new Size(256, 34);
            RentalStartDateR.TabIndex = 27;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(838, 9);
            label10.Name = "label10";
            label10.Size = new Size(166, 27);
            label10.TabIndex = 26;
            label10.Text = "Дата получения";
            // 
            // ComboBoxMovieR
            // 
            ComboBoxMovieR.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxMovieR.FormattingEnabled = true;
            ComboBoxMovieR.Location = new Point(461, 85);
            ComboBoxMovieR.Name = "ComboBoxMovieR";
            ComboBoxMovieR.Size = new Size(232, 35);
            ComboBoxMovieR.TabIndex = 25;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(384, 88);
            label9.Name = "label9";
            label9.Size = new Size(71, 27);
            label9.TabIndex = 24;
            label9.Text = "Фильм";
            // 
            // ComboBoxEmployeeR
            // 
            ComboBoxEmployeeR.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxEmployeeR.FormattingEnabled = true;
            ComboBoxEmployeeR.Location = new Point(461, 44);
            ComboBoxEmployeeR.Name = "ComboBoxEmployeeR";
            ComboBoxEmployeeR.Size = new Size(232, 35);
            ComboBoxEmployeeR.TabIndex = 23;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(347, 47);
            label8.Name = "label8";
            label8.Size = new Size(108, 27);
            label8.TabIndex = 22;
            label8.Text = "Сотрудник";
            // 
            // ComboBoxCustomerR
            // 
            ComboBoxCustomerR.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxCustomerR.FormattingEnabled = true;
            ComboBoxCustomerR.Location = new Point(461, 3);
            ComboBoxCustomerR.Name = "ComboBoxCustomerR";
            ComboBoxCustomerR.Size = new Size(232, 35);
            ComboBoxCustomerR.TabIndex = 21;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(376, 6);
            label7.Name = "label7";
            label7.Size = new Size(79, 27);
            label7.TabIndex = 20;
            label7.Text = "Клиент";
            // 
            // buttonEditRentals
            // 
            buttonEditRentals.Location = new Point(3, 39);
            buttonEditRentals.Name = "buttonEditRentals";
            buttonEditRentals.Size = new Size(215, 30);
            buttonEditRentals.TabIndex = 7;
            buttonEditRentals.Text = "Изменить аренду";
            buttonEditRentals.UseVisualStyleBackColor = true;
            buttonEditRentals.Click += buttonEditRentals_Click;
            // 
            // buttonDelRentals
            // 
            buttonDelRentals.Location = new Point(3, 87);
            buttonDelRentals.Name = "buttonDelRentals";
            buttonDelRentals.Size = new Size(215, 30);
            buttonDelRentals.TabIndex = 6;
            buttonDelRentals.Text = "Удалить аренду";
            buttonDelRentals.UseVisualStyleBackColor = true;
            buttonDelRentals.Click += buttonDelRentals_Click;
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
            panelRatings.Controls.Add(label15);
            panelRatings.Controls.Add(CommentField);
            panelRatings.Controls.Add(label14);
            panelRatings.Controls.Add(RatingField);
            panelRatings.Controls.Add(ComboBoxMovieRatings);
            panelRatings.Controls.Add(label12);
            panelRatings.Controls.Add(ComboBoxCustomersRating);
            panelRatings.Controls.Add(label13);
            panelRatings.Controls.Add(buttonEditRatings);
            panelRatings.Controls.Add(buttonDelRatings);
            panelRatings.Controls.Add(buttonAddRatings);
            panelRatings.Dock = DockStyle.Fill;
            panelRatings.Location = new Point(3, 507);
            panelRatings.Name = "panelRatings";
            panelRatings.Size = new Size(1330, 120);
            panelRatings.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label15.Location = new Point(865, 42);
            label15.Name = "label15";
            label15.Size = new Size(139, 27);
            label15.TabIndex = 47;
            label15.Text = "Комментарий";
            // 
            // CommentField
            // 
            CommentField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            CommentField.Location = new Point(1010, 3);
            CommentField.MaxLength = 100;
            CommentField.Multiline = true;
            CommentField.Name = "CommentField";
            CommentField.Size = new Size(300, 114);
            CommentField.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label14.Location = new Point(374, 87);
            label14.Name = "label14";
            label14.Size = new Size(81, 27);
            label14.TabIndex = 45;
            label14.Text = "Оценка";
            // 
            // RatingField
            // 
            RatingField.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            RatingField.Location = new Point(461, 84);
            RatingField.Name = "RatingField";
            RatingField.Size = new Size(232, 34);
            RatingField.TabIndex = 44;
            RatingField.KeyPress += RatingField_KeyPress;
            // 
            // ComboBoxMovieRatings
            // 
            ComboBoxMovieRatings.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxMovieRatings.FormattingEnabled = true;
            ComboBoxMovieRatings.Location = new Point(461, 44);
            ComboBoxMovieRatings.Name = "ComboBoxMovieRatings";
            ComboBoxMovieRatings.Size = new Size(232, 35);
            ComboBoxMovieRatings.TabIndex = 29;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(384, 47);
            label12.Name = "label12";
            label12.Size = new Size(71, 27);
            label12.TabIndex = 28;
            label12.Text = "Фильм";
            // 
            // ComboBoxCustomersRating
            // 
            ComboBoxCustomersRating.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            ComboBoxCustomersRating.FormattingEnabled = true;
            ComboBoxCustomersRating.Location = new Point(461, 3);
            ComboBoxCustomersRating.Name = "ComboBoxCustomersRating";
            ComboBoxCustomersRating.Size = new Size(232, 35);
            ComboBoxCustomersRating.TabIndex = 27;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label13.Location = new Point(376, 6);
            label13.Name = "label13";
            label13.Size = new Size(79, 27);
            label13.TabIndex = 26;
            label13.Text = "Клиент";
            // 
            // buttonEditRatings
            // 
            buttonEditRatings.Location = new Point(3, 39);
            buttonEditRatings.Name = "buttonEditRatings";
            buttonEditRatings.Size = new Size(215, 30);
            buttonEditRatings.TabIndex = 7;
            buttonEditRatings.Text = "Изменить оценку";
            buttonEditRatings.UseVisualStyleBackColor = true;
            buttonEditRatings.Click += buttonEditRatings_Click;
            // 
            // buttonDelRatings
            // 
            buttonDelRatings.Location = new Point(3, 87);
            buttonDelRatings.Name = "buttonDelRatings";
            buttonDelRatings.Size = new Size(215, 30);
            buttonDelRatings.TabIndex = 6;
            buttonDelRatings.Text = "Удалить оценку";
            buttonDelRatings.UseVisualStyleBackColor = true;
            buttonDelRatings.Click += buttonDelRatings_Click;
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
            // Reports
            // 
            Reports.Controls.Add(DateTimeEndSalary);
            Reports.Controls.Add(DateTimeStartSalary);
            Reports.Controls.Add(SalaryReport);
            Reports.Controls.Add(RatingsReport);
            Reports.Location = new Point(4, 24);
            Reports.Name = "Reports";
            Reports.Padding = new Padding(3);
            Reports.Size = new Size(1342, 636);
            Reports.TabIndex = 5;
            Reports.Text = "Отчеты";
            Reports.UseVisualStyleBackColor = true;
            // 
            // DateTimeEndSalary
            // 
            DateTimeEndSalary.Location = new Point(201, 152);
            DateTimeEndSalary.Name = "DateTimeEndSalary";
            DateTimeEndSalary.Size = new Size(156, 23);
            DateTimeEndSalary.TabIndex = 3;
            // 
            // DateTimeStartSalary
            // 
            DateTimeStartSalary.Location = new Point(8, 152);
            DateTimeStartSalary.Name = "DateTimeStartSalary";
            DateTimeStartSalary.Size = new Size(156, 23);
            DateTimeStartSalary.TabIndex = 2;
            // 
            // SalaryReport
            // 
            SalaryReport.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            SalaryReport.Location = new Point(8, 86);
            SalaryReport.Name = "SalaryReport";
            SalaryReport.Size = new Size(349, 60);
            SalaryReport.TabIndex = 1;
            SalaryReport.Text = "Отчет по зарплате";
            SalaryReport.UseVisualStyleBackColor = true;
            SalaryReport.Click += SalaryReport_Click;
            // 
            // RatingsReport
            // 
            RatingsReport.Font = new Font("Comic Sans MS", 14.25F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            RatingsReport.Location = new Point(8, 6);
            RatingsReport.Name = "RatingsReport";
            RatingsReport.Size = new Size(349, 60);
            RatingsReport.TabIndex = 0;
            RatingsReport.Text = "Отчет по рейтингам фильмов";
            RatingsReport.UseVisualStyleBackColor = true;
            RatingsReport.Click += RatingsReport_Click;
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
            panelMovies.PerformLayout();
            Rentals.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            panelRentals.ResumeLayout(false);
            panelRentals.PerformLayout();
            Ratings.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
            panelRatings.ResumeLayout(false);
            panelRatings.PerformLayout();
            Reports.ResumeLayout(false);
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
        private Label label4;
        private Label label5;
        private Label label6;
        private TextBox DailyRentalCostFieldM;
        private TextBox DurationFieldM;
        private TextBox CountryFieldM;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox DirectorFieldM;
        private TextBox ReleaseYearFieldM;
        private TextBox TitleFieldM;
        private ComboBox ComboBoxMovieR;
        private Label label9;
        private ComboBox ComboBoxEmployeeR;
        private Label label8;
        private ComboBox ComboBoxCustomerR;
        private Label label7;
        private DateTimePicker RentalStartDateR;
        private Label label10;
        private DateTimePicker RentalReturnDateR;
        private Label label11;
        private Label label14;
        private TextBox RatingField;
        private ComboBox ComboBoxMovieRatings;
        private Label label12;
        private ComboBox ComboBoxCustomersRating;
        private Label label13;
        private Label label15;
        private TextBox CommentField;
        private TabPage Reports;
        private Button SalaryReport;
        private Button RatingsReport;
        private DateTimePicker DateTimeEndSalary;
        private DateTimePicker DateTimeStartSalary;
    }
}