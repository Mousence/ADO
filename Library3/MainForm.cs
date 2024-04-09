﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Library3
{
	public partial class MainForm : Form
	{
		string connectionString;
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public MainForm()
		{
			InitializeComponent();

			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			MessageBox.Show(this, connection.ConnectionString, "ConnectrionString", MessageBoxButtons.OK, MessageBoxIcon.Information);
			richTextBox1.SelectAll();
			richTextBox1.SelectionAlignment = HorizontalAlignment.Center;

			string command = $@"SELECT TABLE_NAME FROM INFORMATION_SCHEMA.TABLES";
			SqlCommand cmd = new SqlCommand(command, connection);
			connection.Open();
			SqlDataReader reader = cmd.ExecuteReader();
			while(reader.Read()) {
				comboBoxTables.Items.Add(reader[0]);
			}
			connection.Close();
		}

		private void btnExecute_Click(object sender, EventArgs e)
		{
			string cmdLine = richTextBox1.Text;
			LoadDataToGrid(cmdLine);
			//SqlCommand cmd = new SqlCommand(cmdLine, connection);
			//connection.Open();
			//reader = cmd.ExecuteReader();
			//table = new DataTable();
			//for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			//while (reader.Read()) { 
			//	DataRow row = table.NewRow();
			//	for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
			//	table.Rows.Add(row);
			//}
			//dataGridView.DataSource = table;
			//connection.Close();
		}

		private void comboBoxTables_SelectedIndexChanged(object sender, EventArgs e)
		{
			string command = $@"SELECT * FROM {comboBoxTables.SelectedItem.ToString()}";
			LoadDataToGrid(command);
			//SqlCommand cmd = new SqlCommand(command, connection);
			//connection.Open();
			//SqlDataReader reader = cmd.ExecuteReader();
			//table = new DataTable();
			//for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			//while (reader.Read()) { 
			//	DataRow row = table.NewRow();
			//	for (int i = 0; i < reader.FieldCount; i++) {
			//		row[i] = reader[i];
			//	}
			//	table.Rows.Add(row);
			//}
			//dataGridView.DataSource = table;
			//connection.Close();
		}
		void LoadDataToGrid(string command) {
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
