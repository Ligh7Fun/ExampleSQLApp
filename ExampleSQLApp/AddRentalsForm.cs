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
    public partial class AddRentalsForm : Form
    {
        public AddRentalsForm()
        {
            InitializeComponent();
            LoadCustomerList();
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void LoadCustomerList()
        {
            using (NpgsqlConnection connection = DB.GetConnection())
            {
                connection.Open();
                string selectQuery = "SELECT CustomerID, FullName FROM Customers";
                using (NpgsqlCommand command = new NpgsqlCommand(selectQuery, connection))
                {
                    using (NpgsqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            int customerID = reader.GetInt32(0);
                            string fullName = reader.GetString(1);
                            ComboBoxCustomer.Items.Add(new ComboboxItem(fullName, customerID));
                        }
                    }
                }
            }
        }

        // Класс для хранения значений и отображения в ComboBox
        public class ComboboxItem
        {
            public string Text { get; set; }
            public object Value { get; set; }

            public ComboboxItem(string text, object value)
            {
                Text = text;
                Value = value;
            }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}
