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
	public partial class AddPosition : Form
	{
        public bool EditMode = false;
        public string id;

        public AddPosition()
		{
			InitializeComponent();
		}

        private void OKb_Click(object sender, EventArgs e)
        {
            try
            {
                if (NameTB.Text == string.Empty)
                    throw new Exception("Не задано название должности.");
                if (obyazTB.Text == string.Empty)
                    throw new Exception("Не заданы обязанности.");
                if (zpTB.Text == string.Empty)
                    throw new Exception("Не задан оклад.");
                if (reqTB.Text == string.Empty)
                    throw new Exception("Не заданы требования.");
				if (!int.TryParse(zpTB.Text, out int oklad) || (oklad < 0))
					throw new Exception("Введён некорректный оклад.");


				using (NpgsqlConnection cn = new NpgsqlConnection(Connection.str))
                {
                    cn.Open();
                    string parameters = " WHERE \"name\" LIKE '" + NameTB.Text + "'";
                    NpgsqlCommand cmd = new NpgsqlCommand("select * from \"position_table\"" + parameters, cn);
                    NpgsqlDataReader reader = cmd.ExecuteReader();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    if (dt.Rows.Count > 0 && !EditMode)
                    {
                        cn.Close();
                        throw new Exception("Такая должность уже добавлена.");
                    }
                    else
                    {
                        if (EditMode)
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"UPDATE \"position_table\" SET name = '" +
                             NameTB.Text + "', oklad = '" + zpTB.Text + "', \"duty\" = '" + obyazTB.Text + "', \"requirements\" = '" + reqTB.Text + "' WHERE (pos_id = '" + id + "')", cn))
                            {
                                command.ExecuteNonQuery();
                                cn.Close();
                                Close();
                            }
                        }
                        else
                        {
                            using (NpgsqlCommand command = new NpgsqlCommand($"INSERT INTO position_table (\"name\", oklad, duty, requirements) " +
                            "VALUES ('" + NameTB.Text + "', '" + zpTB.Text + "', '" + obyazTB.Text + "', '" + reqTB.Text + "')", cn))
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
                MessageBox.Show(ex.Message);
            }
        }
    }
}
