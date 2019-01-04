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
using System.Text.RegularExpressions;

namespace carsharing_project
{
    public partial class AddCar : Form
    {
        public bool EditMode = false;
        public string id;

        public AddCar()
        {
            InitializeComponent();
            carpriceTB.Text = "0";
            mileageTB.Text = "0";
        }

        public AddCar(string idd, string name, string reg, string body, string engine, string prod, string mileage, string cPrice, string dPrice, string maint, string spec)
        {
            InitializeComponent();
            id = idd;
            nameTB.Text = name;
            regTB.Text = reg;
            kuzTB.Text = body;
            engTB.Text = engine;
            prodDTP.Text = prod;
            mileageTB.Text = mileage;
            carpriceTB.Text = cPrice;
            daypriceTB.Text = dPrice;
            maintenanceDTP.Text = maint;
            specTB.Text = spec;
            EditMode = true;
        }

        private void OKb_Click(object sender, EventArgs e)
        {
            try
            {
                if (nameTB.Text.Length > 45)
                    throw new Exception("Название автомобиля: не более 45 символов.");
                if (nameTB.Text == string.Empty)
                    throw new Exception("Не задано название автомобиля.");
                if (regTB.Text.Length > 45)
                    throw new Exception("Регистрационный номер: не более  символов.");
                if (regTB.Text == string.Empty)
                    throw new Exception("Не задан регистрационный номер.");
                if (kuzTB.Text.Length > 45)
                    throw new Exception("Номер кузова: не более  символов.");
                if (kuzTB.Text == string.Empty)
                    throw new Exception("Не задан номер кузова.");
                if (engTB.Text.Length > 45)
                    throw new Exception("Номер двигателя: не более  знаков.");
                if (engTB.Text == string.Empty)
                    throw new Exception("Не задан номер двигателя.");
                if (mileageTB.Text.Length > 45)
                    throw new Exception("Пробег: не более 45 символов.");
                if (mileageTB.Text == string.Empty)
                    throw new Exception("Не задан пробег.");
                if (carpriceTB.Text.Length > 45)
                    throw new Exception("Цена автомобиля: не более 45 символов.");
                if (carpriceTB.Text == string.Empty)
                    throw new Exception("Не задана цена автомобиля.");
                if (daypriceTB.Text.Length > 45)
                    throw new Exception("Стоимость проката: не более 45 символов.");
                if (daypriceTB.Text == string.Empty)
                    throw new Exception("Не указана цена проката.");
                if (specTB.Text.Length > 300)
                    throw new Exception("Особенности: не более 300 символов.");

                using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
                    cn.Open();
                    string parameters = " WHERE \"reg_num\" LIKE '" + regTB.Text + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand("select * from \"car_table\"" + parameters, cn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0 && !EditMode)
                    {
                        cn.Close();
                        throw new Exception("Такой автомобиль уже добавлен.");
                    }
                    else
                    {
                        if (EditMode)
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"UPDATE \"car_table\" SET model = '" +
                             nameTB.Text + "', \"reg_num\" = '" + regTB.Text + "', \"body_num\" = '" + kuzTB.Text + "', \"engine_num\" = '" + engTB.Text + "', \"prod_year\" = '" + prodDTP.Text + "', mileage = '" + mileageTB.Text + "', \"car_price\" = '" + carpriceTB.Text + "', \"day_price\" = '" + daypriceTB.Text + "', maintenance = '" + maintenanceDTP.Text + "', specials = '" + specTB.Text + "', returned = '1' WHERE (\"car_id\" = '" + id + "')", cn))
                            {
                                command.ExecuteNonQuery();
                                cn.Close();
                                Close();
                            }
                        }
                        else
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO \"car_table\" (model, \"reg_num\", \"body_num\", \"engine_num\", \"prod_year\", mileage, \"car_price\", \"day_price\", maintenance, specials, returned) " +
                            //"VALUES ('" + fioTextBox.Text + "', '" + sexBox.Text + "', '" + birthPicker.Text + "', '" + addressTextBox.Text + "', '" + phoneTextBox.Text + "', '" + passTextBox.Text + "')"
                            "VALUES ('" + nameTB.Text + "', '" + regTB.Text + "', '" + kuzTB.Text + "', '" + engTB.Text + "', '" + prodDTP.Text + "', '" + mileageTB.Text + "', '" + carpriceTB.Text + "', '" + daypriceTB.Text + "', '" + maintenanceDTP.Text + "', '" + specTB.Text + "', '1')", cn))
                            {
                                command.ExecuteNonQuery();
                                cn.Close();
                                Close();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                if (!EditMode)
                {
                    mileageTB.Text = "0";
                    carpriceTB.Text = "0";
                }
                MessageBox.Show(ex.Message);
            }
        }

        private void KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            if (Char.IsControl(e.KeyChar)) return;
            e.Handled = true;
        }
    }
}