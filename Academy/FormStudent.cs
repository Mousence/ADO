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
		SqlConnection connection;
		public Student(string connectionString, List<string> groupNames)
		{
			InitializeComponent();
			connection = new SqlConnection(connectionString);
			comboBoxGroups.Items.AddRange(groupNames.ToArray());
			//MainForm.LoadDataToComboBox("Groups", "group_name", comboBoxGroups);
			//MainForm.LoadDataToComboBox("Directions", "direction_name", comboBoxDirections);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string cmd = @"
        INSERT INTO Students
                    (last_name, first_name, middle_name, birth_date, email, phone, photo, [group])
        VALUES      (@LastName, @FirstName, @MiddleName, @BirthDate, @Email, @Phone, @Photo, @Group)";

			using (SqlCommand command = new SqlCommand(cmd, connection))
			{
				command.Parameters.AddWithValue("@LastName", richTextBoxLastName.Text);
				command.Parameters.AddWithValue("@FirstName", richTextBoxFirstName.Text);
				command.Parameters.AddWithValue("@MiddleName", richTextBoxMiddleName.Text);
				command.Parameters.AddWithValue("@BirthDate", dateTimePicker1.Value.Date);
				command.Parameters.AddWithValue("@Email", richTextBoxEmail.Text);
				command.Parameters.AddWithValue("@Phone", richTextBoxPhone.Text);

				byte[] photoBytes = ImageToByteArray(pictureBox1.Image);
				command.Parameters.AddWithValue("@Photo", photoBytes);

				command.Parameters.AddWithValue("@Group", comboBoxGroups.SelectedItem.ToString());

				connection.Open();
				command.ExecuteNonQuery();
				connection.Close();
			}
		}

		private byte[] ImageToByteArray(Image image)
		{
			using (var ms = new MemoryStream())
			{
				image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
				return ms.ToArray();
			}
		}
	}
}
