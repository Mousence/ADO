using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Academy
{
	public partial class Student : Form
	{
		public Student()
		{
			InitializeComponent();
			DataLoader.LoadDataToComboBox("Directions", "direction_name", comboBoxDirections, null, "Все");
			DataLoader.LoadDataToComboBox("Groups", "group_name", comboBoxGroups);
			//comboBoxGroup.Items.Remove("Все");
			//comboBoxGroup.SelectedIndex = -1;
			InitForm();
		}
		void InitForm()
		{
			richTextBoxLastName.Text = "Тупенко";
			richTextBoxFirstName.Text = "Лемур";
			richTextBoxMiddleName.Text = "Лемурович";
			dateTimePicker1.Value = new DateTime(2005, 04, 01);
		}
		public void InitForm
			(
			string last_name, string first_name, string middle_name, DateTime birth_date,
			string email, string phone, string group, string direction, Image photo
			)
		{
			richTextBoxLastName.Text = last_name;
			richTextBoxFirstName.Text = first_name;
			richTextBoxMiddleName.Text = middle_name;
			dateTimePicker1.Value = birth_date;
			richTextBoxEmail.Text = email;
			richTextBoxPhone.Text = phone;
			comboBoxDirections.SelectedValue = direction;
			comboBoxGroups.SelectedValue = group;
			pictureBox1.Image = photo;
			comboBoxGroups.Enabled = false;
			comboBoxDirections.Enabled = false;
		}


		private void btnSave_Click(object sender, EventArgs e)
		{
			Connector connector = new Connector();
			//Single responsibility principle
			connector.InsertDataToBase
				(
				"Students",
				"last_name,first_name,middle_name,birth_date,email,phone,photo,[group]",
				$"" +
$"'{richTextBoxLastName.Text}'," +
$"'{richTextBoxFirstName.Text}'," +
$"'{richTextBoxMiddleName.Text}'," +
$"'{dateTimePicker1.Value}'," +
$"'{richTextBoxEmail.Text}'," +
$"'{richTextBoxPhone.Text}'," +
$"'{pictureBox1.Image}'," +
$"{connector.GetIDbyValue("Groups", "group_id,group_name", comboBoxGroups.SelectedItem.ToString())}"
				);
		}

		private void btnBrowse_Click(object sender, EventArgs e)
		{
			OpenFileDialog open = new OpenFileDialog();
			open.ShowDialog();
			string filename = open.FileName;
			pictureBox1.Image = Image.FromFile(filename);
		}

		private void comboBoxDirection_SelectedIndexChanged(object sender, EventArgs e)
		{
			DataLoader.GroupFilter(comboBoxDirections, comboBoxGroups);
		}
	}
}
