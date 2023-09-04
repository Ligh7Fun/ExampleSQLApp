using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using OfficeOpenXml;
using System.IO.Packaging;

namespace ExampleSQLApp
{
    public partial class MainForm : Form
    {
        private int columnWidth = 180; // Ширина столбцов
        public MainForm()
        {
            InitializeComponent();

            LoadEmployeesData();

            ButtonsDisable("Employees");
            ButtonsDisable("Customers");
            ButtonsDisable("Movies");
            ButtonsDisable("Rentals");
            ButtonsDisable("Ratings");

            TerminationDateField.CustomFormat = " ";
            TerminationDateField.Format = DateTimePickerFormat.Custom;

            BirthDateField.CustomFormat = " ";
            BirthDateField.Format = DateTimePickerFormat.Custom;

            HireDateField.CustomFormat = " ";
            HireDateField.Format = DateTimePickerFormat.Custom;

            BirthDateFieldC.CustomFormat = " ";
            BirthDateFieldC.Format = DateTimePickerFormat.Custom;

            RegistrationDateFieldC.CustomFormat = " ";
            RegistrationDateFieldC.Format = DateTimePickerFormat.Custom;

            RentalStartDateR.CustomFormat = " ";
            RentalStartDateR.Format = DateTimePickerFormat.Custom;

            RentalReturnDateR.CustomFormat = " ";
            RentalReturnDateR.Format = DateTimePickerFormat.Custom;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        System.Drawing.Point LastPoint;
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new System.Drawing.Point(e.X, e.Y);
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void TabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Получаем выбранную вкладку
            TabControl tabControl = (TabControl)sender;
            TabPage selectedTab = tabControl.SelectedTab;

            // Определяем, какая вкладка выбрана и вызываем соответствующий метод загрузки данных в таблицу
            if (selectedTab == Employees)
            {
                LoadEmployeesData();
                ButtonsDisable("Employees");
            }
            else if (selectedTab == Customers)
            {
                LoadCustomersData();
                ButtonsDisable("Customers");
            }
            else if (selectedTab == Movies)
            {
                LoadMoviesData();
                ButtonsDisable("Movies");
            }
            else if (selectedTab == Rentals)
            {
                LoadRentalsData();
                ButtonsDisable("Rentals");
            }
            else if (selectedTab == Ratings)
            {
                LoadRatingsData();
                ButtonsDisable("Ratings");
            }
        }

        public void ButtonsDisable(string buttonName) // Отключаем кнопки
        {
            if (buttonName == "Employees")
            {
                buttonEditEmployees.Enabled = false;
                buttonDelEmployees.Enabled = false;
            }

            if (buttonName == "Customers")
            {
                buttonEditCustomers.Enabled = false;
                buttonDelCustomers.Enabled = false;
            }

            if (buttonName == "Movies")
            {
                buttonEditMovies.Enabled = false;
                buttonDelMovies.Enabled = false;
            }

            if (buttonName == "Rentals")
            {
                buttonEditRentals.Enabled = false;
                buttonDelRentals.Enabled = false;
            }

            if (buttonName == "Ratings")
            {
                buttonEditRatings.Enabled = false;
                buttonDelRatings.Enabled = false;
            }
        }

        public void ButtonsEnable(string buttonName) // Включаем кнопки
        {
            if (buttonName == "Employees")
            {
                buttonEditEmployees.Enabled = true;
                buttonDelEmployees.Enabled = true;
            }

            if (buttonName == "Customers")
            {
                buttonEditCustomers.Enabled = true;
                buttonDelCustomers.Enabled = true;
            }

            if (buttonName == "Movies")
            {
                buttonEditMovies.Enabled = true;
                buttonDelMovies.Enabled = true;
            }

            if (buttonName == "Rentals")
            {
                buttonEditRentals.Enabled = true;
                buttonDelRentals.Enabled = true;
            }

            if (buttonName == "Ratings")
            {
                buttonEditRatings.Enabled = true;
                buttonDelRatings.Enabled = true;
            }
        }

        public void LoadMoviesData()
        {
            listViewMovies.Items.Clear();
            listViewMovies.View = View.Details;

            // Добавление заголовков столбцов
            listViewMovies.Columns.Clear();
            listViewMovies.Columns.Add("ID");
            listViewMovies.Columns.Add("Наименование");
            listViewMovies.Columns.Add("Год выпуска");
            listViewMovies.Columns.Add("Режиссёр");
            listViewMovies.Columns.Add("Страна");
            listViewMovies.Columns.Add("Продолжительность");
            listViewMovies.Columns.Add("Стоимость в день");

            foreach (ColumnHeader column in listViewMovies.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Movies  ORDER BY MovieID";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewMovies данными
                        while (reader.Read())
                        {
                            int movieID = reader.GetInt32(0);
                            string title = reader.GetString(1);
                            int releaseYear = reader.IsDBNull(2) ? 0 : reader.GetInt32(2);
                            string director = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string country = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            int duration = reader.IsDBNull(5) ? 0 : reader.GetInt32(5);
                            decimal dailyRentalCost = reader.IsDBNull(6) ? 0 : reader.GetDecimal(6);

                            ListViewItem item = new ListViewItem(movieID.ToString());
                            item.SubItems.Add(title);
                            item.SubItems.Add(releaseYear.ToString());
                            item.SubItems.Add(director);
                            item.SubItems.Add(country);
                            item.SubItems.Add(duration.ToString());
                            item.SubItems.Add(dailyRentalCost.ToString("0.00"));

                            listViewMovies.Items.Add(item);
                        }
                    }
                }
            }
        }

        public void LoadEmployeesData()
        {
            listViewEmployees.Items.Clear();
            listViewEmployees.View = View.Details;

            // Добавление заголовков столбцов
            listViewEmployees.Columns.Clear();
            listViewEmployees.Columns.Add("ID");
            listViewEmployees.Columns.Add("ФИО");
            listViewEmployees.Columns.Add("День рождения");
            listViewEmployees.Columns.Add("Адрес");
            listViewEmployees.Columns.Add("Телефон");
            listViewEmployees.Columns.Add("Дата устройства");
            listViewEmployees.Columns.Add("Дата увольнения");

            foreach (ColumnHeader column in listViewEmployees.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Employees ORDER BY EmployeeID";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewEmployees данными
                        while (reader.Read())
                        {
                            int employeeID = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            DateTime birthDate = reader.GetDateTime(2);
                            string address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string phoneNumber = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            DateTime hireDate = reader.GetDateTime(5);
                            DateTime terminationDate = reader.IsDBNull(6) ? DateTime.MinValue : reader.GetDateTime(6);
                            // Если дата увольнения не указана, то отображаем пустую строку
                            string terminationDateStr = terminationDate == DateTime.MinValue ? "" : terminationDate.ToShortDateString();

                            ListViewItem item = new ListViewItem(employeeID.ToString());
                            item.SubItems.Add(fullName);
                            item.SubItems.Add(birthDate.ToShortDateString());
                            item.SubItems.Add(address);
                            item.SubItems.Add(phoneNumber);
                            item.SubItems.Add(hireDate.ToShortDateString());
                            item.SubItems.Add(terminationDateStr);

                            listViewEmployees.Items.Add(item);
                        }
                    }
                }
            }
        }

        public void LoadCustomersData()
        {
            listViewCustomers.Items.Clear();
            listViewCustomers.View = View.Details;

            // Добавление заголовков столбцов
            listViewCustomers.Columns.Clear();
            listViewCustomers.Columns.Add("ID");
            listViewCustomers.Columns.Add("ФИО");
            listViewCustomers.Columns.Add("Дата рождения");
            listViewCustomers.Columns.Add("Адрес");
            listViewCustomers.Columns.Add("Телефон");
            listViewCustomers.Columns.Add("Дата регистрации");

            foreach (ColumnHeader column in listViewCustomers.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT * FROM Customers ORDER BY CustomerID";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewCustomers данными
                        while (reader.Read())
                        {
                            int customerID = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            DateTime birthDate = reader.GetDateTime(2);
                            string address = reader.IsDBNull(3) ? string.Empty : reader.GetString(3);
                            string phoneNumber = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);
                            DateTime registrationDate = reader.GetDateTime(5);

                            ListViewItem item = new ListViewItem(customerID.ToString());
                            item.SubItems.Add(fullName);
                            item.SubItems.Add(birthDate.ToShortDateString());
                            item.SubItems.Add(address);
                            item.SubItems.Add(phoneNumber);
                            item.SubItems.Add(registrationDate.ToShortDateString());

                            listViewCustomers.Items.Add(item);
                        }
                    }
                }
            }
        }


        public void LoadRentalsData()
        {
            listViewRentals.Items.Clear();
            listViewRentals.View = View.Details;

            // Добавление заголовков столбцов
            listViewRentals.Columns.Clear();
            listViewRentals.Columns.Add("ID");
            listViewRentals.Columns.Add("Клиент");
            listViewRentals.Columns.Add("Сотрудник");
            listViewRentals.Columns.Add("Фильм");
            listViewRentals.Columns.Add("Дата получения");
            listViewRentals.Columns.Add("Дата возврата");

            foreach (ColumnHeader column in listViewRentals.Columns)
            {
                column.Width = columnWidth;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT RentalID, Customers.FullName, Employees.FullName, Movies.Title, RentalDate, ReturnDate " +
                                     "FROM Rentals " +
                                     "INNER JOIN Customers ON Rentals.CustomerID = Customers.CustomerID " +
                                     "INNER JOIN Employees ON Rentals.EmployeeID = Employees.EmployeeID " +
                                     "INNER JOIN Movies ON Rentals.MovieID = Movies.MovieID " +
                                     "ORDER BY RentalID";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewRentals данными
                        while (reader.Read())
                        {
                            int rentalID = reader.GetInt32(0);
                            string customerName = reader.GetString(1);
                            string employeeName = reader.GetString(2);
                            string movieTitle = reader.GetString(3);
                            DateTime rentalDate = reader.GetDateTime(4);
                            DateTime returnDate = reader.GetDateTime(5);

                            ListViewItem item = new ListViewItem(rentalID.ToString());
                            item.SubItems.Add(customerName);
                            item.SubItems.Add(employeeName);
                            item.SubItems.Add(movieTitle);
                            item.SubItems.Add(rentalDate.ToShortDateString());
                            item.SubItems.Add(returnDate.ToShortDateString());

                            listViewRentals.Items.Add(item);
                        }
                    }
                }
            }
        }



        public void LoadRatingsData()
        {
            listViewRatings.Items.Clear();
            listViewRatings.View = View.Details;

            // Добавление заголовков столбцов
            listViewRatings.Columns.Clear();
            listViewRatings.Columns.Add("ID");
            listViewRatings.Columns.Add("Клиент");
            listViewRatings.Columns.Add("Фильм");
            listViewRatings.Columns.Add("Оценка");


            foreach (ColumnHeader column in listViewRatings.Columns)
            {
                column.Width = columnWidth;
            }
            listViewRatings.Columns.Add("Комментарий", 550);

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Выполнение SELECT запроса
                string selectQuery = "SELECT RatingID, Customers.FullName, Movies.Title, Rating, Comment " +
                                     "FROM Ratings " +
                                     "INNER JOIN Customers ON Ratings.CustomerID = Customers.CustomerID " +
                                     "INNER JOIN Movies ON Ratings.MovieID = Movies.MovieID " +
                                     "ORDER BY RatingID";

                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        // Заполнение listViewRatings данными
                        while (reader.Read())
                        {
                            int ratingID = reader.GetInt32(0);
                            string customerName = reader.GetString(1);
                            string movieTitle = reader.GetString(2);
                            int rating = reader.GetInt32(3);
                            string comment = reader.IsDBNull(4) ? string.Empty : reader.GetString(4);

                            ListViewItem item = new ListViewItem(ratingID.ToString());
                            item.SubItems.Add(customerName);
                            item.SubItems.Add(movieTitle);
                            item.SubItems.Add(rating.ToString());
                            item.SubItems.Add(comment);

                            listViewRatings.Items.Add(item);
                        }
                    }
                }
            }
        }

        private void buttonAddEmployees_Click(object sender, EventArgs e)
        {
            AddEmployeesForm addEmployeesForm = new AddEmployeesForm(this);
            addEmployeesForm.ShowDialog();
        }

        private void buttonAddRentals_Click(object sender, EventArgs e)
        {
            AddRentalsForm addRentalsForm = new AddRentalsForm(this);
            addRentalsForm.ShowDialog();
        }

        private void buttonAddMovies_Click(object sender, EventArgs e)
        {
            AddMoviesForm addMoviesForm = new AddMoviesForm(this);
            addMoviesForm.ShowDialog();
        }

        private void listViewRatings_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRatings.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRatings.SelectedItems[0];
                ButtonsEnable("Ratings");
                // Получаем данные из выбранной строки
                string customer = selectedItem.SubItems[1].Text;
                string movie = selectedItem.SubItems[2].Text;
                string rating = selectedItem.SubItems[3].Text;
                string comment = selectedItem.SubItems[4].Text;

                ComboBoxCustomersRating.Items.Clear();
                ComboBoxMovieRatings.Items.Clear();

                // Добавляем все элементы из базы в ComboBox
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // Запросы для получения всех значений из соответствующих таблиц
                    string customersQuery = "SELECT FullName FROM Customers";
                    string moviesQuery = "SELECT Title FROM Movies";

                    using (NpgsqlCommand command = new NpgsqlCommand(customersQuery, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboBoxCustomersRating.Items.Add(reader.GetString(0));
                            }
                        }
                    }

                    using (NpgsqlCommand command = new NpgsqlCommand(moviesQuery, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboBoxMovieRatings.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }

                // Устанавливаем выбранные значения
                ComboBoxCustomersRating.SelectedItem = customer;
                ComboBoxMovieRatings.SelectedItem = movie;
                RatingField.Text = rating;
                CommentField.Text = comment;
            }
            else
            {
                ButtonsDisable("Ratings");
                ComboBoxCustomersRating.Items.Clear();
                ComboBoxMovieRatings.Items.Clear();
                ComboBoxCustomersRating.Text = string.Empty;
                ComboBoxMovieRatings.Text = string.Empty;
                RatingField.Text = string.Empty;
                CommentField.Text = string.Empty;
            }
        }

        private void listViewEmployees_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewEmployees.SelectedItems[0];
                ButtonsEnable("Employees");
                // Получаем данные из выбранной строки
                string fullName = selectedItem.SubItems[1].Text;
                string birthDate = selectedItem.SubItems[2].Text;
                string address = selectedItem.SubItems[3].Text;
                string phoneNumber = selectedItem.SubItems[4].Text;
                string hireDate = selectedItem.SubItems[5].Text;
                string terminationDate = selectedItem.SubItems[6].Text;

                FullNameField.Text = fullName;
                AddressField.Text = address;
                PhoneNumberField.Text = phoneNumber;
                if (birthDate != string.Empty)
                {
                    BirthDateField.CustomFormat = "";
                    BirthDateField.Value = Convert.ToDateTime(birthDate);
                }
                else
                {
                    BirthDateField.CustomFormat = " ";
                }

                if (hireDate != string.Empty)
                {
                    HireDateField.CustomFormat = "";
                    HireDateField.Value = Convert.ToDateTime(hireDate);
                }
                else
                {
                    HireDateField.CustomFormat = " ";
                }


                if (terminationDate != string.Empty)
                {
                    TerminationDateField.CustomFormat = "";
                    TerminationDateField.Value = Convert.ToDateTime(terminationDate);
                }
                else
                {
                    TerminationDateField.CustomFormat = " ";
                }

            }
            else
            {
                ButtonsDisable("Employees");
                FullNameField.Text = string.Empty;
                AddressField.Text = string.Empty;
                PhoneNumberField.Text = string.Empty;
                BirthDateField.CustomFormat = " ";
                HireDateField.CustomFormat = " ";
                TerminationDateField.CustomFormat = " ";
                TerminationDateField.Value = TerminationDateField.MinDate;
                HireDateField.Value = HireDateField.MinDate;
                TerminationDateField.Value = TerminationDateField.MinDate;
            }
        }

        private void listViewCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewCustomers.SelectedItems[0];
                ButtonsEnable("Customers");
                // Получаем данные из выбранной строки
                string fullName = selectedItem.SubItems[1].Text;
                string birthDate = selectedItem.SubItems[2].Text;
                string address = selectedItem.SubItems[3].Text;
                string phoneNumber = selectedItem.SubItems[4].Text;
                string registrationDate = selectedItem.SubItems[5].Text;

                FullNameFieldC.Text = fullName;
                AddressFieldC.Text = address;
                PhoneNumberFieldC.Text = phoneNumber;
                BirthDateFieldC.CustomFormat = "";
                RegistrationDateFieldC.CustomFormat = "";
                BirthDateFieldC.Value = Convert.ToDateTime(birthDate);
                RegistrationDateFieldC.Value = Convert.ToDateTime(registrationDate);
            }
            else
            {
                ButtonsDisable("Customers");
                FullNameFieldC.Text = string.Empty;
                AddressFieldC.Text = string.Empty;
                PhoneNumberFieldC.Text = string.Empty;
                BirthDateFieldC.CustomFormat = " ";
                RegistrationDateFieldC.CustomFormat = " ";
                BirthDateFieldC.Value = BirthDateFieldC.MinDate;
                RegistrationDateFieldC.Value = RegistrationDateFieldC.MinDate;
            }
        }

        private void listViewRentals_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewRentals.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewRentals.SelectedItems[0];
                ButtonsEnable("Rentals");

                // Получаем данные из выбранной строки
                string customer = selectedItem.SubItems[1].Text;
                string employee = selectedItem.SubItems[2].Text;
                string movie = selectedItem.SubItems[3].Text;
                string rentalDate = selectedItem.SubItems[4].Text;
                string returnDate = selectedItem.SubItems[5].Text;

                ComboBoxCustomerR.Items.Clear();
                ComboBoxEmployeeR.Items.Clear();
                ComboBoxMovieR.Items.Clear();

                // Добавляем все элементы из базы в ComboBox
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // Запросы для получения всех значений из соответствующих таблиц
                    string customersQuery = "SELECT FullName FROM Customers";
                    string employeesQuery = "SELECT FullName FROM Employees";
                    string moviesQuery = "SELECT Title FROM Movies";

                    using (NpgsqlCommand command = new NpgsqlCommand(customersQuery, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboBoxCustomerR.Items.Add(reader.GetString(0));
                            }
                        }
                    }

                    using (NpgsqlCommand command = new NpgsqlCommand(employeesQuery, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboBoxEmployeeR.Items.Add(reader.GetString(0));
                            }
                        }
                    }

                    using (NpgsqlCommand command = new NpgsqlCommand(moviesQuery, connection))
                    {
                        using (NpgsqlDataReader reader = command.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                ComboBoxMovieR.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }

                // Устанавливаем выбранные значения
                ComboBoxCustomerR.SelectedItem = customer;
                ComboBoxEmployeeR.SelectedItem = employee;
                ComboBoxMovieR.SelectedItem = movie;
                RentalStartDateR.CustomFormat = "";
                RentalReturnDateR.CustomFormat = "";
                RentalStartDateR.Value = Convert.ToDateTime(rentalDate);
                RentalReturnDateR.Value = Convert.ToDateTime(returnDate);
            }
            else
            {
                ButtonsDisable("Rentals");
                ComboBoxCustomerR.Items.Clear();
                ComboBoxEmployeeR.Items.Clear();
                ComboBoxMovieR.Items.Clear();
                ComboBoxCustomerR.Text = string.Empty;
                ComboBoxEmployeeR.Text = string.Empty;
                ComboBoxMovieR.Text = string.Empty;
                RentalStartDateR.CustomFormat = " ";
                RentalReturnDateR.CustomFormat = " ";
            }
        }

        private void listViewMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewMovies.SelectedItems[0];
                ButtonsEnable("Movies");
                // Получаем данные из выбранной строки
                string title = selectedItem.SubItems[1].Text;
                string releaseYear = selectedItem.SubItems[2].Text;
                string director = selectedItem.SubItems[3].Text;
                string country = selectedItem.SubItems[4].Text;
                string duration = selectedItem.SubItems[5].Text;
                string dailyRentalCost = selectedItem.SubItems[6].Text;

                TitleFieldM.Text = title;
                ReleaseYearFieldM.Text = releaseYear;
                DirectorFieldM.Text = director;
                CountryFieldM.Text = country;
                DurationFieldM.Text = duration;
                DailyRentalCostFieldM.Text = dailyRentalCost;
            }
            else
            {
                ButtonsDisable("Movies");
                TitleFieldM.Text = string.Empty;
                ReleaseYearFieldM.Text = string.Empty;
                DirectorFieldM.Text = string.Empty;
                CountryFieldM.Text = string.Empty;
                DurationFieldM.Text = string.Empty;
                DailyRentalCostFieldM.Text = string.Empty;
            }
        }

        private void buttonAddCustomers_Click(object sender, EventArgs e)
        {
            AddCustomersForm addCustomersForm = new AddCustomersForm(this);
            addCustomersForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                try
                {
                    // Получите идентификатор выбранной записи
                    int employeeID = Convert.ToInt32(listViewEmployees.SelectedItems[0].SubItems[0].Text);
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту запись c ID " + employeeID + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Выполните SQL-запрос для удаления записи из базы данных
                        using (NpgsqlConnection connection = DB.GetConnection())
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM Employees WHERE EmployeeID = @employeeID";
                            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@employeeID", employeeID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.SqlState == "23503") // Код ошибки для нарушения внешнего ключа
                    {
                        MessageBox.Show("Невозможно удалить запись, так как на нее есть ссылки в других таблицах.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    // Обновить данные в таблице
                    LoadEmployeesData();
                    ButtonsDisable("Employees");
                    FullNameField.Text = string.Empty;
                    AddressField.Text = string.Empty;
                    PhoneNumberField.Text = string.Empty;
                    BirthDateField.CustomFormat = " ";
                    HireDateField.CustomFormat = " ";
                    TerminationDateField.CustomFormat = " ";
                    TerminationDateField.Value = TerminationDateField.MinDate;
                    HireDateField.Value = HireDateField.MinDate;
                    TerminationDateField.Value = TerminationDateField.MinDate;
                }

            }
        }

        private void buttonAddRatings_Click(object sender, EventArgs e)
        {
            AddRatingsForm addMRatingForm = new AddRatingsForm(this);
            addMRatingForm.ShowDialog();
        }

        private void buttonEditEmployees_Click(object sender, EventArgs e)
        {
            if (listViewEmployees.SelectedItems.Count > 0)
            {
                // Получение выбранной строки и идентификатора сотрудника
                ListViewItem selectedItem = listViewEmployees.SelectedItems[0];
                int employeeID = Int32.Parse(selectedItem.SubItems[0].Text);

                // Получение значений из компонентов ввода
                string fullName = FullNameField.Text;
                string address = AddressField.Text;
                string phoneNumber = PhoneNumberField.Text;
                DateTime birthDate = BirthDateField.Value;
                DateTime hireDate = HireDateField.Value;
                DateTime? terminationDate = TerminationDateField.Value != TerminationDateField.MinDate ? (DateTime?)TerminationDateField.Value : null;

                // Подключение к базе данных
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // SQL-запрос для обновления данных
                    string updateQuery = @"
                        UPDATE Employees
                        SET FullName = @fullName, Address = @address, PhoneNumber = @phoneNumber,
                            BirthDate = @birthDate, HireDate = @hireDate, TerminationDate = @terminationDate
                        WHERE EmployeeID = @employeeID";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@employeeID", employeeID);
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@birthDate", birthDate);
                        command.Parameters.AddWithValue("@hireDate", hireDate);
                        command.Parameters.AddWithValue("@terminationDate", terminationDate.HasValue ? (object)terminationDate.Value : DBNull.Value);

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        FullNameField.Text = string.Empty;
                        AddressField.Text = string.Empty;
                        PhoneNumberField.Text = string.Empty;
                        BirthDateField.CustomFormat = " ";
                        HireDateField.CustomFormat = " ";
                        TerminationDateField.CustomFormat = " ";
                        TerminationDateField.Value = TerminationDateField.MinDate;
                        HireDateField.Value = HireDateField.MinDate;
                        TerminationDateField.Value = TerminationDateField.MinDate;

                        // Обновление данных в listView
                        LoadEmployeesData();
                        ButtonsDisable("Employees");
                    }
                }
            }
        }

        private void TerminationDateField_ValueChanged(object sender, EventArgs e)
        {
            TerminationDateField.CustomFormat = "";
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TerminationDateField.Value = TerminationDateField.MinDate;
            TerminationDateField.CustomFormat = " ";
        }

        private void buttonDelCustomers_Click(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                try
                {
                    // Получите идентификатор выбранной записи
                    int customerID = Convert.ToInt32(listViewCustomers.SelectedItems[0].SubItems[0].Text);
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту запись c ID " + customerID + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        // Выполните SQL-запрос для удаления записи из базы данных
                        using (NpgsqlConnection connection = DB.GetConnection())
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM Customers WHERE CustomerID = @customerID";
                            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@customerID", customerID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.SqlState == "23503") // Код ошибки для нарушения внешнего ключа
                    {
                        MessageBox.Show("Невозможно удалить запись, так как на нее есть ссылки в других таблицах.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    // Обновить данные в таблице
                    LoadCustomersData();
                    ButtonsDisable("Customers");
                    FullNameField.Text = string.Empty;
                    AddressField.Text = string.Empty;
                    PhoneNumberField.Text = string.Empty;
                    BirthDateField.CustomFormat = " ";
                    HireDateField.CustomFormat = " ";
                    TerminationDateField.CustomFormat = " ";
                    TerminationDateField.Value = TerminationDateField.MinDate;
                    HireDateField.Value = HireDateField.MinDate;
                    TerminationDateField.Value = TerminationDateField.MinDate;
                }

            }
        }

        private void buttonEditCustomers_Click(object sender, EventArgs e)
        {
            if (listViewCustomers.SelectedItems.Count > 0)
            {
                // Получение выбранной строки и идентификатора сотрудника
                ListViewItem selectedItem = listViewCustomers.SelectedItems[0];
                int customerID = Int32.Parse(selectedItem.SubItems[0].Text);

                // Получение значений из компонентов ввода
                string fullName = FullNameFieldC.Text;
                string address = AddressFieldC.Text;
                string phoneNumber = PhoneNumberFieldC.Text;
                DateTime birthDate = BirthDateFieldC.Value;
                DateTime registrationDate = RegistrationDateFieldC.Value;


                // Подключение к базе данных
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // SQL-запрос для обновления данных
                    string updateQuery = @"
                        UPDATE Customers
                        SET FullName = @fullName, Address = @address, PhoneNumber = @phoneNumber,
                            BirthDate = @birthDate, RegistrationDate = @registrationDate
                        WHERE CustomerID = @customerID";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.Parameters.AddWithValue("@fullName", fullName);
                        command.Parameters.AddWithValue("@address", address);
                        command.Parameters.AddWithValue("@phoneNumber", phoneNumber);
                        command.Parameters.AddWithValue("@birthDate", birthDate);
                        command.Parameters.AddWithValue("@registrationDate", registrationDate);


                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        FullNameFieldC.Text = string.Empty;
                        AddressFieldC.Text = string.Empty;
                        PhoneNumberFieldC.Text = string.Empty;
                        BirthDateFieldC.CustomFormat = " ";
                        RegistrationDateFieldC.CustomFormat = " ";
                        BirthDateFieldC.Value = BirthDateFieldC.MinDate;
                        RegistrationDateFieldC.Value = RegistrationDateFieldC.MinDate;

                        // Обновление данных в listView
                        LoadCustomersData();
                        ButtonsDisable("Customers");
                    }
                }
            }

        }

        private void buttonDelMovies_Click(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count > 0)
            {
                try
                {
                    int movieID = Convert.ToInt32(listViewMovies.SelectedItems[0].SubItems[0].Text);
                    if (MessageBox.Show("Вы уверены, что хотите удалить эту запись c ID " + movieID + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (NpgsqlConnection connection = DB.GetConnection())
                        {
                            connection.Open();
                            string deleteQuery = "DELETE FROM Movies WHERE MovieID = @movieID";
                            using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                            {
                                command.Parameters.AddWithValue("@movieID", movieID);
                                command.ExecuteNonQuery();
                            }
                        }
                    }
                }
                catch (NpgsqlException ex)
                {
                    if (ex.SqlState == "23503") // Код ошибки для нарушения внешнего ключа
                    {
                        MessageBox.Show("Невозможно удалить запись, так как на нее есть ссылки в других таблицах.", "Ошибка удаления", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Произошла ошибка при удалении записи: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                finally
                {
                    ButtonsDisable("Movies");
                    // Обновить данные в таблице
                    LoadMoviesData();
                    ButtonsDisable("Movies");
                    TitleFieldM.Text = string.Empty;
                    ReleaseYearFieldM.Text = string.Empty;
                    DirectorFieldM.Text = string.Empty;
                    CountryFieldM.Text = string.Empty;
                    DurationFieldM.Text = string.Empty;
                    DailyRentalCostFieldM.Text = string.Empty;
                }
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void buttonEditMovies_Click(object sender, EventArgs e)
        {
            if (listViewMovies.SelectedItems.Count > 0)
            {
                // Получение выбранной строки и идентификатора сотрудника
                ListViewItem selectedItem = listViewMovies.SelectedItems[0];
                int movieID = Int32.Parse(selectedItem.SubItems[0].Text);

                // Получение значений из компонентов ввода
                string title = TitleFieldM.Text;
                int releaseYear = Int32.Parse(ReleaseYearFieldM.Text);
                string director = DirectorFieldM.Text;
                string country = CountryFieldM.Text;
                int duration = Int32.Parse(DurationFieldM.Text);
                decimal dailyRentalCost = Decimal.Parse(DailyRentalCostFieldM.Text);


                // Подключение к базе данных
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // SQL-запрос для обновления данных
                    string updateQuery = @"
                        UPDATE Movies
                        SET Title = @title, ReleaseYear = @releaseYear, Director = @director,
                            Country = @country, Duration = @duration, DailyRentalCost = @dailyRentalCost
                        WHERE MovieID = @movieID";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@movieID", movieID);
                        command.Parameters.AddWithValue("@title", title);
                        command.Parameters.AddWithValue("@releaseYear", releaseYear);
                        command.Parameters.AddWithValue("@director", director);
                        command.Parameters.AddWithValue("@country", country);
                        command.Parameters.AddWithValue("@duration", duration);
                        command.Parameters.AddWithValue("@dailyRentalCost", dailyRentalCost);

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        TitleFieldM.Text = string.Empty;
                        ReleaseYearFieldM.Text = string.Empty;
                        DirectorFieldM.Text = string.Empty;
                        CountryFieldM.Text = string.Empty;
                        DurationFieldM.Text = string.Empty;
                        DailyRentalCostFieldM.Text = string.Empty;

                        // Обновление данных в listView
                        LoadMoviesData();
                        ButtonsDisable("Movies");
                    }
                }
            }
        }

        private void buttonDelRentals_Click(object sender, EventArgs e)
        {
            if (listViewRentals.SelectedItems.Count > 0)
            {

                // Получите идентификатор выбранной записи
                int rentalID = Convert.ToInt32(listViewRentals.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись c ID " + rentalID + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Выполните SQL-запрос для удаления записи из базы данных
                    using (NpgsqlConnection connection = DB.GetConnection())
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Rentals WHERE RentalID = @rentalID";
                        using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@rentalID", rentalID);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                // Обновить данные в таблице
                LoadRentalsData();
                ButtonsDisable("Rentals");
                ComboBoxCustomerR.Items.Clear();
                ComboBoxEmployeeR.Items.Clear();
                ComboBoxMovieR.Items.Clear();
                ComboBoxCustomerR.Text = string.Empty;
                ComboBoxEmployeeR.Text = string.Empty;
                ComboBoxMovieR.Text = string.Empty;
                RentalStartDateR.CustomFormat = " ";
                RentalReturnDateR.CustomFormat = " ";
                RentalStartDateR.Value = RentalStartDateR.MinDate;
                RentalReturnDateR.Value = RentalReturnDateR.MinDate;
            }
        }
        // Метод для получения идентификатора по значению из определенной таблицы и столбца
        private int GetIDForValue(string tableName, string columnName, string value, NpgsqlConnection connection)
        {
            int id = -1;
            string idColumnName = tableName.Substring(0, tableName.Length - 1) + "ID";
            string selectQuery = $"SELECT {idColumnName} FROM {tableName} WHERE {columnName} = @value";


            using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
            {
                command.Parameters.AddWithValue("@value", value);
                object? result = command.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }

            return id;
        }

        private void buttonEditRentals_Click(object sender, EventArgs e)
        {
            if (listViewRentals.SelectedItems.Count > 0)
            {
                // Получение выбранной строки и идентификатора аренды
                ListViewItem selectedItem = listViewRentals.SelectedItems[0];
                int rentalID = Int32.Parse(selectedItem.SubItems[0].Text);

                // Получение значений из компонентов ввода
                string customer = ComboBoxCustomerR.SelectedItem.ToString() ?? string.Empty;
                string employee = ComboBoxEmployeeR.SelectedItem.ToString() ?? string.Empty;
                string movie = ComboBoxMovieR.SelectedItem.ToString() ?? string.Empty;
                DateTime rentalDate = RentalStartDateR.Value;
                DateTime returnDate = RentalReturnDateR.Value;


                // Подключение к базе данных
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // Получение идентификаторов клиента, сотрудника и фильма из базы данных
                    int customerID = GetIDForValue("Customers", "FullName", customer, connection);
                    int employeeID = GetIDForValue("Employees", "FullName", employee, connection);
                    int movieID = GetIDForValue("Movies", "Title", movie, connection);

                    // SQL-запрос для обновления данных
                    string updateQuery = @"
                        UPDATE Rentals
                        SET CustomerID = @customerID, EmployeeID = @employeeID, MovieID = @movieID,
                            RentalDate = @rentalDate, ReturnDate = @returnDate
                        WHERE RentalID = @rentalID";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@rentalID", rentalID);
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.Parameters.AddWithValue("@employeeID", employeeID);
                        command.Parameters.AddWithValue("@movieID", movieID);
                        command.Parameters.AddWithValue("@rentalDate", rentalDate);
                        command.Parameters.AddWithValue("@returnDate", returnDate);

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        // Очистка и обновление данных в ComboBox и других компонентах
                        ComboBoxCustomerR.Items.Clear();
                        ComboBoxEmployeeR.Items.Clear();
                        ComboBoxMovieR.Items.Clear();
                        ComboBoxCustomerR.Text = string.Empty;
                        ComboBoxEmployeeR.Text = string.Empty;
                        ComboBoxMovieR.Text = string.Empty;
                        RentalStartDateR.CustomFormat = " ";
                        RentalReturnDateR.CustomFormat = " ";
                        RentalStartDateR.Value = RentalStartDateR.MinDate;
                        RentalReturnDateR.Value = RentalReturnDateR.MinDate;

                        // Обновление данных в listView
                        LoadRentalsData();
                        ButtonsDisable("Rentals");
                    }
                }
            }
        }

        private void buttonDelRatings_Click(object sender, EventArgs e)
        {
            if (listViewRatings.SelectedItems.Count > 0)
            {

                // Получите идентификатор выбранной записи
                int ratingID = Convert.ToInt32(listViewRatings.SelectedItems[0].SubItems[0].Text);
                if (MessageBox.Show("Вы уверены, что хотите удалить эту запись c ID " + ratingID + "?", "Подтверждение удаления", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Выполните SQL-запрос для удаления записи из базы данных
                    using (NpgsqlConnection connection = DB.GetConnection())
                    {
                        connection.Open();
                        string deleteQuery = "DELETE FROM Ratings WHERE RatingID = @ratingID";
                        using (NpgsqlCommand command = new NpgsqlCommand(deleteQuery, connection))
                        {
                            command.Parameters.AddWithValue("@ratingID", ratingID);
                            command.ExecuteNonQuery();
                        }
                    }
                }
                // Обновить данные в таблице
                LoadRatingsData();
                ButtonsDisable("Ratings");
            }
        }

        private void RatingField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void buttonEditRatings_Click(object sender, EventArgs e)
        {
            if (listViewRatings.SelectedItems.Count > 0)
            {
                // Получение выбранной строки и идентификатора оценки
                ListViewItem selectedItem = listViewRatings.SelectedItems[0];
                int ratingID = Int32.Parse(selectedItem.SubItems[0].Text);

                // Получение значений из компонентов ввода
                string customer = ComboBoxCustomersRating.SelectedItem.ToString() ?? string.Empty;
                if (customer == null)
                {
                    customer = string.Empty;
                }
                string movie = ComboBoxMovieRatings.SelectedItem.ToString() ?? string.Empty;
                if (movie == null)
                {
                    movie = string.Empty;
                }
                int rating = Convert.ToInt32(RatingField.Text);
                string comment = CommentField.Text;

                // Подключение к базе данных
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();

                    // Получение идентификаторов клиента и фильма из базы данных
                    int customerID = GetIDForValue("Customers", "FullName", customer, connection);
                    int movieID = GetIDForValue("Movies", "Title", movie, connection);

                    // SQL-запрос для обновления данных
                    string updateQuery = @"
                        UPDATE Ratings
                        SET CustomerID = @customerID, MovieID = @movieID, Rating = @rating, Comment = @comment
                        WHERE RatingID = @ratingID";

                    using (NpgsqlCommand command = new NpgsqlCommand(updateQuery, connection))
                    {
                        // Добавление параметров
                        command.Parameters.AddWithValue("@ratingID", ratingID);
                        command.Parameters.AddWithValue("@customerID", customerID);
                        command.Parameters.AddWithValue("@movieID", movieID);
                        command.Parameters.AddWithValue("@rating", rating);
                        command.Parameters.AddWithValue("@comment", comment);

                        // Выполнение запроса
                        command.ExecuteNonQuery();

                        // Очистка и обновление данных в ComboBox и других компонентах
                        ComboBoxCustomersRating.Items.Clear();
                        ComboBoxMovieRatings.Items.Clear();
                        ComboBoxCustomersRating.Text = string.Empty;
                        ComboBoxMovieRatings.Text = string.Empty;
                        RatingField.Text = string.Empty;
                        CommentField.Text = string.Empty;

                        // Обновление данных в listView
                        LoadRatingsData();
                        ButtonsDisable("Ratings");
                    }
                }
            }
        }

        // Класс для хранения данных о рейтинге фильмов
        public class RatingRecord
        {
            public string? MovieTitle { get; set; }
            public double AverageRating { get; set; }
        }

        // Получение записей о рейтинге из базы данных
        private List<RatingRecord> GetRatingRecordsFromDatabase()
        {
            List<RatingRecord> ratingRecords = new List<RatingRecord>();
            string queryString = @"
                SELECT m.Title AS MovieTitle, AVG(r.Rating) AS AverageRating
                FROM Movies m
                LEFT JOIN Ratings r ON m.MovieID = r.MovieID
                GROUP BY m.Title";

            // Установление соединения с базой данных и извлечение данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(queryString, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            RatingRecord record = new RatingRecord
                            {
                                MovieTitle = reader.GetString(0),
                                AverageRating = reader.IsDBNull(1) ? 0 : reader.GetDouble(1)
                            };
                            ratingRecords.Add(record);
                        }
                    }
                }
            }
            return ratingRecords;
        }

        private void GenerateAndSaveRatingsReport(List<RatingRecord> ratingRecords)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Отчет по рейтингу");
                worksheet.Column(1).Width = 60;
                worksheet.Column(2).Width = 25;
                worksheet.Cells["A1"].Value = "Отчет по рейтингу";
                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["A1:B1"].Style.Font.Size = 14;
                worksheet.Cells["A1:B1"].Style.Font.Bold = true;

                worksheet.Cells["A2"].Value = "Фильм";
                worksheet.Cells["B2"].Value = "Средний рейтинг";

                int row = 3;
                foreach (var record in ratingRecords)
                {
                    worksheet.Cells["A" + row].Value = record.MovieTitle;
                    worksheet.Cells["B" + row].Value = record.AverageRating;
                    row++;
                }

                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.DefaultExt = "xlsx";
                    saveFileDialog.FileName = "RatingReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        package.SaveAs(new FileInfo(filePath));
                    }
                }
            }
        }

        private void RatingsReport_Click(object sender, EventArgs e)
        {
            List<RatingRecord> ratingRecords = GetRatingRecordsFromDatabase();
            GenerateAndSaveRatingsReport(ratingRecords);
        }

        // Класс для хранения записей о заработной плате
        public class SalaryRecord
        {
            public string? EmployeeName { get; set; }
            public decimal SalaryAmount { get; set; }
        }

        private List<SalaryRecord> GetSalaryRecordsFromDatabase(DateTime startDate, DateTime endDate)
        {
            List<SalaryRecord> salaryRecords = new List<SalaryRecord>();

            string query = @"
                SELECT 
                    e.fullname AS employee,
                    SUM(
                        CASE 
                            WHEN r.rentaldate >= @StartDate AND r.returndate <= @EndDate
                                THEN m.dailyrentalcost * (DATE_PART('day', AGE(r.returndate, r.rentaldate)) + 1)
                            WHEN r.rentaldate < @StartDate AND r.returndate > @EndDate
                                THEN m.dailyrentalcost * (DATE_PART('day', AGE(@EndDate, @StartDate)) + 1)
                            WHEN r.rentaldate < @StartDate AND r.returndate >= @StartDate
                                THEN m.dailyrentalcost * (DATE_PART('day', AGE(r.returndate, @StartDate)) + 1)
                            WHEN r.rentaldate <= @EndDate AND r.returndate > @EndDate
                                THEN m.dailyrentalcost * (DATE_PART('day', AGE(@EndDate, r.rentaldate)) + 1)
                        END
                    ) AS salary
                FROM rentals r
                JOIN movies m ON r.movieid = m.movieid
                JOIN employees e ON r.employeeid = e.employeeid
                WHERE (r.rentaldate >= @StartDate AND r.rentaldate <= @EndDate) OR (r.returndate >= @StartDate AND r.returndate <= @EndDate)
                GROUP BY e.fullname
                ORDER BY e.fullname";

            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                using NpgsqlCommand command = new NpgsqlCommand(query, connection);
                command.Parameters.AddWithValue("StartDate", startDate);
                command.Parameters.AddWithValue("EndDate", endDate);

                using NpgsqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    SalaryRecord record = new SalaryRecord();
                    record.EmployeeName = reader["employee"].ToString();
                    record.SalaryAmount = Convert.ToDecimal(reader["salary"]);
                    salaryRecords.Add(record);
                }
            }

            return salaryRecords;
        }

        private void GenerateAndSaveSalaryReport(List<SalaryRecord> salaryRecords, DateTime startDate, DateTime endDate)
        {
            using (var package = new ExcelPackage())
            {
                var worksheet = package.Workbook.Worksheets.Add("Отчет по зарплате");
                worksheet.Column(1).Width = 60;
                worksheet.Column(2).Width = 25;
                worksheet.Column(2).Style.Numberformat.Format = "0.00 ₽";
                worksheet.Cells["A1"].Value = "Отчет по зарплате " + startDate.ToString("dd.MM.yyyy") + " - " + endDate.ToString("dd.MM.yyyy");
                worksheet.Cells["A1:B1"].Merge = true;
                worksheet.Cells["A1:B1"].Style.Font.Size = 14;
                worksheet.Cells["A1:B1"].Style.Font.Bold = true;

                worksheet.Cells[2, 1].Value = "Сотрудник";
                worksheet.Cells[2, 2].Value = "Зарплата";

                int row = 3;
                foreach (var record in salaryRecords)
                {
                    worksheet.Cells[row, 1].Value = record.EmployeeName;
                    worksheet.Cells[row, 2].Value = record.SalaryAmount;
                    row++;
                }

                // Интегрированный код сохранения файла с отчетом
                using (var saveFileDialog = new SaveFileDialog())
                {
                    saveFileDialog.Filter = "Excel Files|*.xlsx";
                    saveFileDialog.DefaultExt = "xlsx";
                    saveFileDialog.FileName = "SalaryReport.xlsx";

                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        string filePath = saveFileDialog.FileName;
                        package.SaveAs(new FileInfo(filePath));
                    }
                }
            }
        }

        private void SalaryReport_Click(object sender, EventArgs e)
        {
            DateTime startDate = DateTimeStartSalary.Value;
            DateTime endDate = DateTimeEndSalary.Value;

            List<SalaryRecord> salaryRecords = GetSalaryRecordsFromDatabase(startDate, endDate);
            GenerateAndSaveSalaryReport(salaryRecords, startDate, endDate);
        }

    }
}
