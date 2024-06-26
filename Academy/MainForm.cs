﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class MainForm : Form
	{
		string connectionString;
		//SqlConnection connection;
		//SqlDataReader reader;
		//DataTable table;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			if (AllocConsole())
			{
				Console.WriteLine(connectionString);
				//FreeConsole();
			}
			//connection = new SqlConnection(connectionString);
			LoadStudents();
			DataLoader.LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroups, null, "Все");
			DataLoader.LoadDataToComboBox("Directions", "direction_name", comboBoxDirections, null, "Все");
		}

		void LoadStudents(string condition = null)
		{
			//			connection.Open();
			//			string cmd = $@"
			//SELECT 
			//		[Ф.И.О.]		= FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
			//		[Дата рожения]	= birth_date,
			//		[Группа]		= group_name,
			//		[Направление]	= direction_name
			//FROM Students
			//JOIN Groups		ON ([group]=group_id)
			//JOIN Directions ON (direction=direction_id)
			//";
			//			if (condition != null && !condition.Contains("Все"))
			//			{
			//				cmd += $"WHERE {condition}";
			//			}
			//			Console.WriteLine(cmd);
			//			SqlCommand command = new SqlCommand(cmd, connection);
			//			reader = command.ExecuteReader();
			//			table = new DataTable();
			//			for (int i = 0; i < reader.FieldCount; i++) table.Columns.Add(reader.GetName(i));
			//			while (reader.Read())
			//			{
			//				DataRow row = table.NewRow();
			//				for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
			//				table.Rows.Add(row);
			//			}
			//			dataGridViewStudents.DataSource = table;
			//			connection.Close();

			string columns = $@"
[ID]			= stud_id,
[Ф.И.О.]		= FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
[Дата рожения]	= birth_date,
[Группа]		= group_name,
[Направление]	= direction_name
";
			string tables = "students, groups, directions";
			string relations = "Students.[group]=group_id AND direction=direction_id";
			if (condition != null && !condition.Contains("Все")) condition = $"{relations} AND {condition}";
			else condition = relations;
			Connector connector = new Connector();
			dataGridViewStudents.DataSource = connector.LoadColumnFromTable(columns, tables, condition);
			dataGridViewStudents.Columns[0].Visible = false;
			setStatus();
		}
		//void LoadDataToComboBox(string tables, string column, ComboBox list, string condition = null)
		//{
		//	list.Items.Clear();
		//	list.Items.Add("Все");
		//	list.SelectedIndex = 0;
		//	//string cmd = $"SELECT {column} FROM {tables}";
		//	//if (condition != null)
		//	//{
		//	//	cmd += $" WHERE {condition}";
		//	//}
		//	//Console.WriteLine(cmd);
		//	//connection.Open();
		//	//SqlCommand command = new SqlCommand(cmd, connection);
		//	//reader = command.ExecuteReader();
		//	//while (reader.Read())
		//	//{
		//	//	list.Items.Add(reader[0]);
		//	//}
		//	//connection.Close();
		//	Connector connector = new Connector();
		//	connector.LoadColumnFromTable(column, tables, condition);
		//	string[] items = new string[connector.DataTable.Rows.Count];
		//	for (int i = 0; i < items.Length; i++)
		//		items[i] = connector.DataTable.Rows[i][0].ToString();
		//	list.Items.AddRange(items);
		//}
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();

		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool FreeConsole();

		private void comboBoxStudentsGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadStudents($"group_name = '{comboBoxStudentsGroups.SelectedItem.ToString()}'");
			setStatus();
		}
		private void setStatus()
		{
			toolStripStatusLabelStudents.Text = $"Количество студентов: {dataGridViewStudents.RowCount - 1}";
			if (comboBoxDirections.SelectedItem?.ToString() == "Все")
			{
				toolStripStatusLabelGroups.Text = $"Всего групп: {comboBoxStudentsGroups.Items.Count}";
			}
			else
			{
				toolStripStatusLabelGroups.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroups.Items.Count}";
			}
		}

		private void comboBoxDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			//comboBoxStudentsGroup.Items.Clear();
			///--------------------------------------
			//if (comboBoxStudentsDirection.SelectedIndex > 0)
			//{
			//	string condition = $"direction = direction_id AND direction_name='{comboBoxStudentsDirection.SelectedItem.ToString()}'";
			//	LoadDataToComboBox("Groups, Directions", "group_name", comboBoxStudentsGroup, condition);
			//}
			//else
			//{
			//	LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroup);
			//}
			DataLoader.GroupFilter(comboBoxDirections, comboBoxStudentsGroups);
			LoadStudents($"direction_name = '{comboBoxDirections.SelectedItem.ToString()}'");
			setStatus();
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			Student formStudent = new Student();
			DialogResult result = formStudent.ShowDialog();
			if (result == DialogResult.OK) LoadStudents();
		}

		private void dataGridViewStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
		{
			Student form = new Student();
			int id = (int)dataGridViewStudents.SelectedCells[0].Value;
		}
	}
}
