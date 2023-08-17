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
            buttonAddEmployees = new Button();
            Customers = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            buttonAddCustomers = new Button();
            listViewCustomers = new ListView();
            Movies = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            buttonAddMovies = new Button();
            listViewMovies = new ListView();
            Rentals = new TabPage();
            tableLayoutPanel4 = new TableLayoutPanel();
            buttonAddRentals = new Button();
            listViewRentals = new ListView();
            Ratings = new TabPage();
            tableLayoutPanel5 = new TableLayoutPanel();
            buttonAddRatings = new Button();
            listViewRatings = new ListView();
            TopPanel = new Panel();
            CloseButton = new Label();
            TimerCreateTable = new System.Windows.Forms.Timer(components);
            MainPanel.SuspendLayout();
            TabControl.SuspendLayout();
            Employees.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            Customers.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            Movies.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            Rentals.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            Ratings.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
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
            Employees.Cursor = Cursors.Hand;
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
            tableLayoutPanel1.Controls.Add(buttonAddEmployees, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(1336, 630);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // listViewEmployees
            // 
            listViewEmployees.Dock = DockStyle.Fill;
            listViewEmployees.GridLines = true;
            listViewEmployees.Location = new Point(3, 3);
            listViewEmployees.Name = "listViewEmployees";
            listViewEmployees.Size = new Size(1330, 498);
            listViewEmployees.TabIndex = 0;
            listViewEmployees.UseCompatibleStateImageBehavior = false;
            listViewEmployees.View = View.Details;
            // 
            // buttonAddEmployees
            // 
            buttonAddEmployees.Location = new Point(3, 507);
            buttonAddEmployees.Name = "buttonAddEmployees";
            buttonAddEmployees.Size = new Size(155, 30);
            buttonAddEmployees.TabIndex = 1;
            buttonAddEmployees.Text = "Добавить запись";
            buttonAddEmployees.UseVisualStyleBackColor = true;
            buttonAddEmployees.Click += buttonAddEmployees_Click;
            // 
            // Customers
            // 
            Customers.Controls.Add(tableLayoutPanel2);
            Customers.Cursor = Cursors.Hand;
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
            tableLayoutPanel2.Controls.Add(buttonAddCustomers, 0, 1);
            tableLayoutPanel2.Controls.Add(listViewCustomers, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel2.Size = new Size(1336, 630);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // buttonAddCustomers
            // 
            buttonAddCustomers.Location = new Point(3, 507);
            buttonAddCustomers.Name = "buttonAddCustomers";
            buttonAddCustomers.Size = new Size(155, 30);
            buttonAddCustomers.TabIndex = 2;
            buttonAddCustomers.Text = "Добавить запись";
            buttonAddCustomers.UseVisualStyleBackColor = true;
            // 
            // listViewCustomers
            // 
            listViewCustomers.Dock = DockStyle.Fill;
            listViewCustomers.Location = new Point(3, 3);
            listViewCustomers.Name = "listViewCustomers";
            listViewCustomers.Size = new Size(1330, 498);
            listViewCustomers.TabIndex = 0;
            listViewCustomers.UseCompatibleStateImageBehavior = false;
            // 
            // Movies
            // 
            Movies.Controls.Add(tableLayoutPanel3);
            Movies.Cursor = Cursors.Hand;
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
            tableLayoutPanel3.Controls.Add(buttonAddMovies, 0, 1);
            tableLayoutPanel3.Controls.Add(listViewMovies, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel3.Size = new Size(1336, 630);
            tableLayoutPanel3.TabIndex = 1;
            // 
            // buttonAddMovies
            // 
            buttonAddMovies.Location = new Point(3, 507);
            buttonAddMovies.Name = "buttonAddMovies";
            buttonAddMovies.Size = new Size(155, 30);
            buttonAddMovies.TabIndex = 3;
            buttonAddMovies.Text = "Добавить запись";
            buttonAddMovies.UseVisualStyleBackColor = true;
            // 
            // listViewMovies
            // 
            listViewMovies.Dock = DockStyle.Fill;
            listViewMovies.Location = new Point(3, 3);
            listViewMovies.Name = "listViewMovies";
            listViewMovies.Size = new Size(1330, 498);
            listViewMovies.TabIndex = 0;
            listViewMovies.UseCompatibleStateImageBehavior = false;
            // 
            // Rentals
            // 
            Rentals.Controls.Add(tableLayoutPanel4);
            Rentals.Cursor = Cursors.Hand;
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
            tableLayoutPanel4.Controls.Add(buttonAddRentals, 0, 1);
            tableLayoutPanel4.Controls.Add(listViewRentals, 0, 0);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 3);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel4.Size = new Size(1336, 630);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // buttonAddRentals
            // 
            buttonAddRentals.Location = new Point(3, 507);
            buttonAddRentals.Name = "buttonAddRentals";
            buttonAddRentals.Size = new Size(155, 30);
            buttonAddRentals.TabIndex = 3;
            buttonAddRentals.Text = "Добавить запись";
            buttonAddRentals.UseVisualStyleBackColor = true;
            // 
            // listViewRentals
            // 
            listViewRentals.Dock = DockStyle.Fill;
            listViewRentals.Location = new Point(3, 3);
            listViewRentals.Name = "listViewRentals";
            listViewRentals.Size = new Size(1330, 498);
            listViewRentals.TabIndex = 0;
            listViewRentals.UseCompatibleStateImageBehavior = false;
            // 
            // Ratings
            // 
            Ratings.Controls.Add(tableLayoutPanel5);
            Ratings.Cursor = Cursors.Hand;
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
            tableLayoutPanel5.Controls.Add(buttonAddRatings, 0, 1);
            tableLayoutPanel5.Controls.Add(listViewRatings, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Fill;
            tableLayoutPanel5.Location = new Point(3, 3);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 2;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 80F));
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel5.Size = new Size(1336, 630);
            tableLayoutPanel5.TabIndex = 1;
            // 
            // buttonAddRatings
            // 
            buttonAddRatings.Location = new Point(3, 507);
            buttonAddRatings.Name = "buttonAddRatings";
            buttonAddRatings.Size = new Size(155, 30);
            buttonAddRatings.TabIndex = 3;
            buttonAddRatings.Text = "Добавить запись";
            buttonAddRatings.UseVisualStyleBackColor = true;
            // 
            // listViewRatings
            // 
            listViewRatings.Dock = DockStyle.Fill;
            listViewRatings.Location = new Point(3, 3);
            listViewRatings.Name = "listViewRatings";
            listViewRatings.Size = new Size(1330, 498);
            listViewRatings.TabIndex = 0;
            listViewRatings.UseCompatibleStateImageBehavior = false;
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
            CloseButton.Cursor = Cursors.Hand;
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
            Customers.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            Movies.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            Rentals.ResumeLayout(false);
            tableLayoutPanel4.ResumeLayout(false);
            Ratings.ResumeLayout(false);
            tableLayoutPanel5.ResumeLayout(false);
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
    }
}