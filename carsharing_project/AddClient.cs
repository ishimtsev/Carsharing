using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace carsharing_project
{
    public partial class AddClient : Form
    {
        public bool EditMode = false;
        public string id; //id клиента

        public AddClient()
        {
            InitializeComponent();
        }

        private void OKb_Click(object sender, EventArgs e)
        {
            try
            {
                if (fioTextBox.Text.Length > 45)
                    throw new Exception("Имя клиента: не более 45 символов.");
                if (fioTextBox.Text == string.Empty)
                    throw new Exception("Не задано имя клиента.");
                //if (birthPicker. > )
                //    throw new Exception("Клиенту ещё нет весемьнадцати.");
                if (addressTextBox.Text.Length > 45)
                    throw new Exception("Адрес: не более 45 символов.");
                if (addressTextBox.Text == string.Empty)
                    throw new Exception("Не задан адрес.");
                if (phoneTextBox.Text.Length > 45)
                    throw new Exception("Телефон: не более 45 символов.");
                if (phoneTextBox.Text == string.Empty)
                    throw new Exception("Не задан телефон.");
                if (passTextBox.Text.Length > 45)
                    throw new Exception("Паспортные данные: не более 45 символов.");
                if (passTextBox.Text == string.Empty)
                    throw new Exception("Не заданы паспортные данные.");

                using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
                    cn.Open();
                    string parameters = " WHERE passport LIKE '" + passTextBox.Text + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand("select * from client_table" + parameters, cn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0 && !EditMode)
                    {
                        cn.Close();
                        throw new Exception("Такой клиент уже добавлен.");
                    }
                    else
                    {
                        int sex;
                        if (sexBox.Text == "Мужской") sex = 0;
                        else sex = 1;
                        string newbirth = birthPicker.Value.Year + "-" + birthPicker.Value.Month + "-" + birthPicker.Value.Day;
                        if (EditMode)
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"UPDATE client_table SET fio = '" +
                             fioTextBox.Text + "', sex = '" + sex + "', birth = '" + newbirth + "', \"address\" = '" + addressTextBox.Text + "', phone = '" + phoneTextBox.Text + "', passport = '" + passTextBox.Text + "' WHERE (cli_id = '" + id + "')", cn))
                            {
                                command.ExecuteNonQuery(); 
                            }
                        }
                        else
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO client_table (fio, sex, birth, address, phone, passport) " +
                            "VALUES ('" + fioTextBox.Text + "', '" + sex + "', '" + newbirth + "', '" + addressTextBox.Text + "', '" + phoneTextBox.Text + "', '" + passTextBox.Text + "')", cn))
                            {
                                command.ExecuteNonQuery();
                            }
                        }
						cn.Close();
						Close();
					}
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
