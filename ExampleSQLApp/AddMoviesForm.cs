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
    public partial class AddMoviesForm : Form
    {
        private MainForm mainForm;
        public AddMoviesForm(MainForm mainForm)
        {
            InitializeComponent();
            this.mainForm = mainForm;
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EnterButton_Click(object sender, EventArgs e)
        {
            string title = TitleField.Text;
            string director = DirectorField.Text;
            string country = CountryField.Text;


            int duration = 0; // Продолжительность фильма в минутах

            if (!string.IsNullOrWhiteSpace(DurationField.Text))
            {
                duration = int.Parse(DurationField.Text);
            }

            int releaseYear = 0;

            if (!string.IsNullOrWhiteSpace(ReleaseYearField.Text))
            {
                releaseYear = int.Parse(ReleaseYearField.Text);
            }

            decimal dailyRentalCost = 0;

            if (!string.IsNullOrWhiteSpace(DailyRentalCostField.Text))
            {
                dailyRentalCost = decimal.Parse(DailyRentalCostField.Text);
            }


            if (title == string.Empty || director == string.Empty || country == string.Empty)
            {
                MessageBox.Show("Все поля обязательны к заполнению.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Подключение к базе данных
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();

                // SQL-запрос для вставки данных
                string insertQuery = @"
                    INSERT INTO Movies (Title, ReleaseYear, Director, Country, Duration, DailyRentalCost)
                    VALUES (@title, @releaseYear, @director, @country, @duration, @dailyRentalCost)";

                using (NpgsqlCommand command = new NpgsqlCommand(insertQuery, connection))
                {
                    // Добавляем параметры
                    command.Parameters.AddWithValue("@title", title);
                    command.Parameters.AddWithValue("@releaseYear", releaseYear);
                    command.Parameters.AddWithValue("@director", director);
                    command.Parameters.AddWithValue("@country", country);
                    command.Parameters.AddWithValue("@duration", duration);
                    command.Parameters.AddWithValue("@dailyRentalCost", dailyRentalCost);

                    // Выполняем запрос
                    command.ExecuteNonQuery();
                }
            }
            this.Close();
            mainForm.LoadMoviesData();
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

        private void DailyRentalCostField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && e.KeyChar != ',')
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void ReleaseYearField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }

        private void DurationField_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Игнорировать символы, не являющиеся цифрами
            }
        }
    }
}
