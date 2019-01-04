﻿using System;
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
    public partial class Cars : Form
    {
        public Cars()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddCar form = new AddCar();
            form.FormClosed += (s, args) => BindData();
            form.Show();
        }

        private void dataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                dataGridView1.ClearSelection();
                dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Selected = true;
                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                contextMenuStrip1.Show(MousePosition);
            }
        }

        private void EditToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddCar form = new AddCar(dataGridView1.CurrentRow.Cells[0].Value.ToString(), dataGridView1.CurrentRow.Cells[1].Value.ToString(),
                dataGridView1.CurrentRow.Cells[2].Value.ToString(), dataGridView1.CurrentRow.Cells[3].Value.ToString(), dataGridView1.CurrentRow.Cells[4].Value.ToString(),
                dataGridView1.CurrentRow.Cells[5].Value.ToString(), dataGridView1.CurrentRow.Cells[6].Value.ToString(), dataGridView1.CurrentRow.Cells[7].Value.ToString(),
                dataGridView1.CurrentRow.Cells[8].Value.ToString(), dataGridView1.CurrentRow.Cells[9].Value.ToString(), dataGridView1.CurrentRow.Cells[10].Value.ToString());
            form.FormClosed += (s, args) => BindData();
            form.Show();
        }

        private void BindData()
        {
            dataGridView1.ClearSelection();
            using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
            {
                string searchString = searchTextBox.Text;
                cn.Open();
                string parameters = string.Empty;
                if (searchString != string.Empty)
                {
                    parameters = " WHERE \"model_id\" LIKE '%" + searchString + "%' OR \"reg_num\" LIKE '%" + searchString + "%' OR \"bodu_num\" LIKE '%" + searchString + "%' OR \"engine_num\" LIKE '%" + searchString + "%' \"OR prod_year\" LIKE '%" + searchString + "%' OR mileage LIKE '%" + searchString + "%' OR \"car_price\" LIKE '%" + searchString + "%' OR \"day_price\" LIKE '%" + searchString + "%' OR maintenance LIKE '%" + searchString + "%' OR \"employee_id\" LIKE '%" + searchString + "%' OR specials LIKE '%" + searchString + "%' OR returned LIKE '%" + searchString + "%'";
                }
                NpgsqlCommand cmd = new NpgsqlCommand("select \"car_id\" as ID, model as Название, \"reg_num\" as Номер, \"body_num\" as \"Номер кузова\", \"engine_num\" as \"Номер мотора\", \"prod_year\" as \"Дата произодства\", mileage as Пробег, \"car_price\" as Стоимость, \"day_price\" as \"Цена проката\", maintenance as \"Последнее техобслуживание\", specials as Особенности, (case when returned IS false then 'Нет' else 'Да' end) as \"На стоянке\" from client_table" + parameters, cn);
                NpgsqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dataGridView1.DataSource = dt;
                dataGridView1.Columns[0].Visible = false;
                dataGridView1.Columns[1].Visible = false;
                dataGridView1.Columns[2].Visible = false;
                cn.Close();
            }
        }

        private void Employees_Search(object sender, EventArgs e)
        {
            BindData();
        }

        private void Employees_Load(object sender, EventArgs e)
        {
            BindData();
        }
    }
}