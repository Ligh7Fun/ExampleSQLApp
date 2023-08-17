using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleSQLApp
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            // Set the size of the password field
            this.PassField.AutoSize = false;
            this.PassField.Size = new Size(300, 64);

            // Set the size of the username field
            this.LoginField.AutoSize = false;
            this.LoginField.Size = new Size(300, 64);
            TimerCreateTable.Start();
            LoadTablesIfNeeded();

        }

        private void LoadTablesIfNeeded()
        {
            // Создаем таблицы
            try
            {
                using (NpgsqlConnection connection = DB.GetConnection())
                {
                    connection.Open();


                    // Создание таблицы Фильмов, если она не существует
                    string createMoviesTable = @"
                        CREATE TABLE IF NOT EXISTS Movies (
                            MovieID SERIAL PRIMARY KEY,
                            Title VARCHAR(255) NOT NULL,
                            ReleaseYear INTEGER,
                            Director VARCHAR(255),
                            Country VARCHAR(100),
                            Duration INTEGER,
                            DailyRentalCost DECIMAL(10, 2)
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createMoviesTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Movies создана или уже существует.";
                    }

                    // Создание таблицы Сотрудников, если она не существует
                    string createEmployeesTable = @"
                        CREATE TABLE IF NOT EXISTS Employees (
                            EmployeeID SERIAL PRIMARY KEY,
                            FullName VARCHAR(255) NOT NULL,
                            BirthDate DATE,
                            Address VARCHAR(255),
                            PhoneNumber VARCHAR(20),
                            HireDate DATE,
                            TerminationDate DATE
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createEmployeesTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Employees создана или уже существует.";
                    }

                    // Создание таблицы Администраторов, если она не существует
                    string createAdminsTable = @"
                        CREATE TABLE IF NOT EXISTS Admins (
                            AdminID SERIAL PRIMARY KEY,
                            Username VARCHAR(255) NOT NULL,
                            Password VARCHAR(255) NOT NULL
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createAdminsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Admins создана или уже существует.";
                    }

                    // Проверка, существует ли учетная запись администратора
                    string checkAdmin = "SELECT COUNT(*) FROM Admins WHERE Username = @username";
                    using (NpgsqlCommand command = new NpgsqlCommand(checkAdmin, connection))
                    {
                        command.Parameters.AddWithValue("@username", "admin");
                        int count = Convert.ToInt32(command.ExecuteScalar());

                        if (count == 0)
                        {
                            // Добавление учетной записи администратора
                            string insertAdmin = @"
                                INSERT INTO Admins (Username, Password)
                                VALUES (@username, @password);";

                            using (NpgsqlCommand insertCommand = new NpgsqlCommand(insertAdmin, connection))
                            {
                                insertCommand.Parameters.AddWithValue("@username", "admin");
                                insertCommand.Parameters.AddWithValue("@password", "admin");
                                try
                                {
                                    insertCommand.ExecuteNonQuery();
                                    LabelMessage.Text = "Учетная запись администратора добавлена.";
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("Ошибка при добавлении учетной записи администратора: " + ex.Message,
                                        "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                        }
                    }

                    // Создание таблицы Клиентов, если она не существует
                    string createCustomersTable = @"
                        CREATE TABLE IF NOT EXISTS Customers (
                            CustomerID SERIAL PRIMARY KEY,
                            FullName VARCHAR(255) NOT NULL,
                            BirthDate DATE,
                            Address VARCHAR(255),
                            PhoneNumber VARCHAR(20),
                            RegistrationDate DATE
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createCustomersTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Customers создана или уже существует.";
                    }

                    // Создание таблицы Аренды, если она не существует
                    string createRentalsTable = @"
                        CREATE TABLE IF NOT EXISTS Rentals (
                            RentalID SERIAL PRIMARY KEY,
                            CustomerID INTEGER REFERENCES Customers(CustomerID),
                            EmployeeID INTEGER REFERENCES Employees(EmployeeID),
                            MovieID INTEGER REFERENCES Movies(MovieID),
                            RentalDate DATE,
                            ReturnDate DATE
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createRentalsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Rentals создана или уже существует.";
                    }

                    // Создание таблицы Оценок фильмов, если она не существует
                    string createRatingsTable = @"
                        CREATE TABLE IF NOT EXISTS Ratings (
                            RatingID SERIAL PRIMARY KEY,
                            CustomerID INTEGER REFERENCES Customers(CustomerID),
                            MovieID INTEGER REFERENCES Movies(MovieID),
                            Rating INTEGER,
                            Comment TEXT
                        );";

                    using (NpgsqlCommand command = new NpgsqlCommand(createRatingsTable, connection))
                    {
                        command.ExecuteNonQuery();
                        LabelMessage.Text = "Таблица Ratings создана или уже существует.";
                    }

                    connection.Close();
                    LabelMessage.Text = "Соединение с базой успешно установлено!";
                }
            }
            catch (Exception ex)
            {
                LabelMessage.Text = "Ошибка: " + ex.Message;
                MessageBox.Show("Ошибка: " + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void CloseButton_MouseEnter(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Green;
        }

        private void CloseButton_MouseLeave(object sender, EventArgs e)
        {
            CloseButton.ForeColor = Color.Gray;
        }

        Point LastPoint;
        private void TitleLabel_MouseDown(object sender, MouseEventArgs e)
        {
            LastPoint = new Point(e.X, e.Y);
        }

        private void TitleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - LastPoint.X;
                this.Top += e.Y - LastPoint.Y;
            }
        }

        private void TimerCreateTable_Tick(object sender, EventArgs e)
        {
            LabelMessage.Hide();
            TimerCreateTable.Stop();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

            string username = LoginField.Text;
            string password = PassField.Text;

            if (CheckCredentials(username, password))
            {
                //MessageBox.Show("Авторизация выполнена", "Авторизация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                // Показываем MainForm и закрываем текущую форму
                MainForm mainForm = new MainForm();
                mainForm.Show();
                this.Hide();
            }
            else
            {
                PassField.Text = string.Empty;
                MessageBox.Show("Неверный логин или пароль.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static bool CheckCredentials(string username, string password)
        {
            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                string sql = "SELECT COUNT(*) FROM Admins WHERE Username = @username AND Password = @password";
                using (NpgsqlCommand command = new NpgsqlCommand(sql, connection))
                {
                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);

                    int count = Convert.ToInt32(command.ExecuteScalar());
                    return count > 0;
                }
            }
        }

    }
}
