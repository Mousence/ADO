using System;
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
		SqlConnection connection;
		SqlDataReader reader;
		DataTable table;
		public MainForm()
		{
			InitializeComponent();
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			if (AllocConsole())
				Console.WriteLine(connectionString);
			connection = new SqlConnection(connectionString);
			LoadDataToGrid();
			LoadDataToComboBox("Groups", "group_name", comboBoxStudentsGroups);
			LoadDataToComboBox("Directions", "direction_name", comboBoxDirections);
		}

		void LoadDataToGrid(string condition=null)
		{
			connection.Open();
			string cmd = $@"SELECT	[Ф.И.О.] = FORMATMESSAGE('%s %s %s', last_name, first_name, middle_name),
									[Дата Рождения] = birth_date,
									[Группа]		   = group_name
									FROM Students
									JOIN Groups		ON	[group]=group_id
									JOIN Directions	ON	(direction=direction_id)";
			if (condition != null) {
				cmd += $"WHERE {condition}";
			}
			Console.WriteLine(cmd);
			SqlCommand command = new SqlCommand(cmd, connection);
			reader = command.ExecuteReader();
			table = new DataTable();
			for (int i = 0; i < reader.FieldCount; i++)
			{
				table.Columns.Add(reader.GetName(i));
			}
			while (reader.Read())
			{
				DataRow row = table.NewRow();
				for (int i = 0; i < reader.FieldCount; i++) row[i] = reader[i];
				table.Rows.Add(row);
			}
			dataGridViewStudents.DataSource = table;
			connection.Close();
		}
		void LoadDataToComboBox(string tables, string column, ComboBox list, string condition=null)
		{
			connection.Open();
			list.Items.Clear();
			list.Items.Add("Все");
			list.SelectedIndex = 0;
			string cmd = $"SELECT {column} FROM {tables}";
			if (condition!=null) {
				cmd += $" WHERE {condition}";
			}
			SqlCommand command = new SqlCommand(cmd, connection);
			reader = command.ExecuteReader();
			while (reader.Read()) {
				list.Items.Add(reader[0]);
			}
			connection.Close();

		}
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool AllocConsole();
		[DllImport("kernel32.dll", SetLastError = true)]
		[return: MarshalAs(UnmanagedType.Bool)]
		static extern bool FreeConsole();

		private void comboBoxStudentsGroups_SelectedIndexChanged(object sender, EventArgs e)
		{
			LoadDataToGrid($"group_name = '{comboBoxStudentsGroups.SelectedItem.ToString()}'");
			SetStatus();
		}
		private void SetStatus() {

			toolStripStatusLabelStudents.Text = $"Количество студентов: {dataGridViewStudents.RowCount - 1}";
			if (comboBoxDirections.SelectedItem?.ToString() == "Все")
				toolStripStatusLabelGroups.Text = $"Всего групп: {comboBoxStudentsGroups.Items.Count-1}";
			else
				toolStripStatusLabelGroups.Text = $"Групп по выбранному направлению: {comboBoxStudentsGroups.Items.Count-1}";
		}
		private void comboBoxDirections_SelectedIndexChanged(object sender, EventArgs e)
		{
			//comboBoxStudentsGroups.Items.Clear();
			if (comboBoxDirections.SelectedIndex > 0)
			{
				string condition = $"direction = direction_id AND direction_name='{comboBoxDirections.SelectedItem.ToString()}'";
				LoadDataToComboBox("Groups, Directions", "group_name", comboBoxStudentsGroups, condition);
			}
			else {
				LoadDataToComboBox("Groups, Directions", "group_name", comboBoxStudentsGroups);
			}
			LoadDataToGrid($"direction_name = '{comboBoxDirections.SelectedItem.ToString()}'");
			SetStatus();
		}
	}
}
