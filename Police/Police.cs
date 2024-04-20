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
		SqlDataAdapter adapter;
		SqlCommandBuilder builder;
		DataSet set;
		public Police()
		{
			InitializeComponent();

			
			connectionString = ConfigurationManager.ConnectionStrings["MyConnectionString"].ConnectionString;
			connection = new SqlConnection(connectionString);

			MessageBox.Show(this, connection.ConnectionString, "ConnectrionString", MessageBoxButtons.OK, MessageBoxIcon.Information);

			btnAlterViolation.Enabled = false;
			set = new DataSet();
			LoadViolations();
		}

		void LoadViolations() 
		{
			string query = "SELECT * FROM Violations";
			adapter = new SqlDataAdapter(query, connection);
			builder = new SqlCommandBuilder(adapter);
			adapter.Fill(set, "Violations");
			dataGridView.DataSource = set.Tables[0];
			query = "SELECT * FROM ResponsibilityTypes";
			builder.DataAdapter.SelectCommand.CommandText = query;
			adapter.Fill(set, "ResponsibilityTypes");
			comboBoxViolationType.Items.Add("Все типы");
			for (int i = 0; i < set.Tables[1].Rows.Count; i++) {
				comboBoxViolationType.Items.Add(set.Tables[1].Rows[i].ItemArray[1].ToString());
			}
			comboBoxViolationType.SelectedIndex = 0;

			builder.DataAdapter.SelectCommand.CommandText = "SELECT  * FROM ViolationsResponsibilitiesRelation";
			adapter.Fill(set, "ViolationsResponsibilitiesRelation");
		}

		private void btnAddViolation_Click(object sender, EventArgs e)
		{
			adapter.Update(set, "Violations");
		}

		private void comboBoxViolationType_SelectedIndexChanged(object sender, EventArgs e)
		{
//			if (comboBoxViolationType.SelectedIndex == 0)
//			{
//				dataGridView.DataSource = set.Tables[0];
//			}
//			else
//			{
//				//string filter = $@"
//				//ViolationsResponsibilitiesRelation.violation = Violations.violation_id
//				//AND ViolationsResponsibilitiesRelation.responsibility = ResponsibilityTypes.type_id
//				//AND ResponsibilityTypes.type_id = {comboBoxViolationType.SelectedIndex}";
//				//DataRow[] results = set.Tables[0].Select(filter);
//				//dataGridView.DataSource = results;

//				builder.DataAdapter.SelectCommand.CommandText = $@"
//SELECT * FROM Violations
//JOIN	ViolationsResponsibilityReltion ON (violation = violation_id)
//JOIN	ResponsibilityTypes ON (responsibility = type_id)
//WHERE	ResponsibilityTypes.type_id = {comboBoxViolationType.SelectedIndex}
//";
//				set.Tables["ViolationByType"]?.Clear();
//				adapter.Fill(set, "ViolationByType");
//				dataGridView.DataSource = set.Tables["ViolationByType"];
//			}

//			DataViewManager manager = new DataViewManager(set);
//			manager.DataViewSettings["Violations"].RowFilter = $"ViolationsResponsibilitiesRelation.type_id={comboBoxViolationType.SelectedIndex}";

//			DataView view = manager.CreateDataView(set.Tables["Violations"]);
//			dataGridView.DataSource = view;
		}
	}
}

