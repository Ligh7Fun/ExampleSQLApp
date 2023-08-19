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
using System.Windows.Forms.VisualStyles;

namespace ExampleSQLApp
{
    public partial class AddRatingsForm : Form
    {
        private MainForm mainForm;
        public AddRatingsForm(MainForm mainForm)
        {
            InitializeComponent();
            LoadCustomersList();
            LoadMoviesList();
            this.mainForm = mainForm;
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
                object result = command.ExecuteScalar();
                if (result != null)
                {
                    id = Convert.ToInt32(result);
                }
            }

            return id;
        }

        private void LoadCustomersList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT FullName FROM Customers";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string fullName = reader.GetString(0);
                            ComboBoxCustomer.Items.Add(fullName);
                        }
                    }
                }
            }
        }

        private void LoadMoviesList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT Title FROM Movies";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            string title = reader.GetString(0);
                            ComboBoxMovie.Items.Add(title);
                        }
                    }
                }
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            // Получаем значения из ComboBox и DateTimePicker
            string selectedCustomer = ComboBoxCustomer.SelectedItem?.ToString() ?? string.Empty;
            string selectedMovie = ComboBoxMovie.SelectedItem?.ToString() ?? string.Empty;
            string comment = CommentField.Text;
            int rating = 0; // Значение по умолчанию

            if (!string.IsNullOrWhiteSpace(RatingField.Text))
            {
                rating = int.Parse(RatingField.Text);
            }

            if (selectedCustomer == string.Empty || selectedMovie == string.Empty || comment == string.Empty)
            {
                MessageBox.Show("Заполните все поля.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // Получаем идентификаторы выбранных клиента, сотрудника и фильма из базы данных
                int customerID = GetIDForValue("Customers", "FullName", selectedCustomer, connection);
                int movieID = GetIDForValue("Movies", "Title", selectedMovie, connection);

                // SQL-запрос для вставки данных
                string insertQuery = @"
                    INSERT INTO Ratings (CustomerID, MovieID, Rating, Comment)
                    VALUES (@customerID, @movieID, @rating, @comment)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@customerID", customerID);
                    command.Parameters.AddWithValue("@movieID", movieID);
                    command.Parameters.AddWithValue("@rating", rating);
                    command.Parameters.AddWithValue("@comment", comment);

                    // Выполняем запрос
                    command.ExecuteNonQuery();

                    //MessageBox.Show("Оценка успешно добавлена.");
                }
            }
            this.Close();
            mainForm.LoadRatingsData();
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

        private void RatingField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }
    }
}
