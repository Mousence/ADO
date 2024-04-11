using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;

namespace Police
{
	public partial class Police : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public Police()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			MessageBox.Show(this, connection.ConnectionString, "ConnectrionString", MessageBoxButtons.OK, MessageBoxIcon.Information);
			richTextBox.SelectAll();
			richTextBox.SelectionAlignment = HorizontalAlignment.Center;

			string command = $@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
			SqlCommand cmd = new SqlCommand(command, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while (reader.Read())
			{
				comboBoxTables.Items.Add(reader[0]);
			}
			connection.Close();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			string cmdLine = richTextBox.Text;
			LoadDataToGrid(cmdLine);
		}

		private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			string command = $@"SELECT * FROM {comboBoxTables.SelectedItem.ToString()}";
			LoadDataToGrid(command);
		}
		void LoadDataToGrid(string command)
		{
			SqlCommand cmd = new SqlCommand(command, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++)
				{
					row[i] = reader[i];
				}
				table.Rows.Add(row);
			}
			dataGridView.DataSource = table;
			connection.Close();
		}
	}
}

