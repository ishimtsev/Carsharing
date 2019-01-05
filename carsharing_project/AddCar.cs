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
        }

        public AddCar(string idd, string name, string reg, string engine, string prod, string mileage, string cPrice, string dPrice, string maint, string spec)
        {
            InitializeComponent();
            id = idd;
            nameTB.Text = name;
            regTB.Text = reg;
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
                        string newprod = prodDTP.Text + "-01-01";
                        string newmain = maintenanceDTP.Value.Year + "-" + maintenanceDTP.Value.Month + "-" + maintenanceDTP.Value.Day;
                        if (EditMode)
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"UPDATE \"car_table\" SET \"name\" = '" +
                             nameTB.Text + "', \"reg_num\" = '" + regTB.Text +"', \"engine_num\" = '" + engTB.Text + "', \"prod_year\" = '" + newprod + "', mileage = '" + mileageTB.Text + "', \"car_price\" = '" + carpriceTB.Text + "', \"day_price\" = '" + daypriceTB.Text + "', maintenance = '" + newmain + "', specials = '" + specTB.Text + "', returned = '1' WHERE (\"car_id\" = '" + id + "')", cn))
                            {
                                command.ExecuteNonQuery();
                                cn.Close();
                                Close();
                            }
                        }
                        else
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO \"car_table\" (\"name\", \"reg_num\", \"engine_num\", \"prod_year\", mileage, \"car_price\", \"day_price\", maintenance, specials, returned) " +
                            //"VALUES ('" + fioTextBox.Text + "', '" + sexBox.Text + "', '" + birthPicker.Text + "', '" + addressTextBox.Text + "', '" + phoneTextBox.Text + "', '" + passTextBox.Text + "')"
                            "VALUES ('" + nameTB.Text + "', '" + regTB.Text + "', '" + engTB.Text + "', '" + newprod + "', '" + mileageTB.Text + "', '" + carpriceTB.Text + "', '" + daypriceTB.Text + "', '" + newmain + "', '" + specTB.Text + "', '1')", cn))
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