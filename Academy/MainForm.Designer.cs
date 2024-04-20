namespace Academy
{
	partial class MainForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPageStudents = new System.Windows.Forms.TabPage();
			this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
			this.btnAdd = new System.Windows.Forms.Button();
			this.comboBoxDirections = new System.Windows.Forms.ComboBox();
			this.comboBoxStudentsGroups = new System.Windows.Forms.ComboBox();
			this.labelDirection = new System.Windows.Forms.Label();
			this.labelGroup = new System.Windows.Forms.Label();
			this.tabPageGroups = new System.Windows.Forms.TabPage();
			this.tabPageSchedule = new System.Windows.Forms.TabPage();
			this.tabPageTeachers = new System.Windows.Forms.TabPage();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabelStudents = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabelGroups = new System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1.SuspendLayout();
			this.tabPageStudents.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPageStudents);
			this.tabControl1.Controls.Add(this.tabPageGroups);
			this.tabControl1.Controls.Add(this.tabPageSchedule);
			this.tabControl1.Controls.Add(this.tabPageTeachers);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(800, 450);
			this.tabControl1.TabIndex = 0;
			// 
			// tabPageStudents
			// 
			this.tabPageStudents.Controls.Add(this.statusStrip1);
			this.tabPageStudents.Controls.Add(this.dataGridViewStudents);
			this.tabPageStudents.Controls.Add(this.btnAdd);
			this.tabPageStudents.Controls.Add(this.comboBoxDirections);
			this.tabPageStudents.Controls.Add(this.comboBoxStudentsGroups);
			this.tabPageStudents.Controls.Add(this.labelDirection);
			this.tabPageStudents.Controls.Add(this.labelGroup);
			this.tabPageStudents.Location = new System.Drawing.Point(4, 22);
			this.tabPageStudents.Name = "tabPageStudents";
			this.tabPageStudents.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageStudents.Size = new System.Drawing.Size(792, 424);
			this.tabPageStudents.TabIndex = 0;
			this.tabPageStudents.Text = "Студенты";
			this.tabPageStudents.UseVisualStyleBackColor = true;
			// 
			// dataGridViewStudents
			// 
			this.dataGridViewStudents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridViewStudents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewStudents.Location = new System.Drawing.Point(8, 38);
			this.dataGridViewStudents.Name = "dataGridViewStudents";
			this.dataGridViewStudents.Size = new System.Drawing.Size(776, 378);
			this.dataGridViewStudents.TabIndex = 9;
			// 
			// btnAdd
			// 
			this.btnAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.btnAdd.Location = new System.Drawing.Point(709, 4);
			this.btnAdd.Name = "btnAdd";
			this.btnAdd.Size = new System.Drawing.Size(75, 23);
			this.btnAdd.TabIndex = 8;
			this.btnAdd.Text = "Добавить";
			this.btnAdd.UseVisualStyleBackColor = true;
			// 
			// comboBoxDirections
			// 
			this.comboBoxDirections.FormattingEnabled = true;
			this.comboBoxDirections.Location = new System.Drawing.Point(433, 6);
			this.comboBoxDirections.Name = "comboBoxDirections";
			this.comboBoxDirections.Size = new System.Drawing.Size(218, 21);
			this.comboBoxDirections.TabIndex = 7;
			this.comboBoxDirections.SelectedIndexChanged += new System.EventHandler(this.comboBoxDirections_SelectedIndexChanged);
			// 
			// comboBoxStudentsGroups
			// 
			this.comboBoxStudentsGroups.FormattingEnabled = true;
			this.comboBoxStudentsGroups.Location = new System.Drawing.Point(57, 6);
			this.comboBoxStudentsGroups.Name = "comboBoxStudentsGroups";
			this.comboBoxStudentsGroups.Size = new System.Drawing.Size(218, 21);
			this.comboBoxStudentsGroups.TabIndex = 6;
			this.comboBoxStudentsGroups.SelectedIndexChanged += new System.EventHandler(this.comboBoxStudentsGroups_SelectedIndexChanged);
			// 
			// labelDirection
			// 
			this.labelDirection.AutoSize = true;
			this.labelDirection.Location = new System.Drawing.Point(303, 9);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(124, 13);
			this.labelDirection.TabIndex = 5;
			this.labelDirection.Text = "Направление обучения";
			// 
			// labelGroup
			// 
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(9, 9);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(42, 13);
			this.labelGroup.TabIndex = 4;
			this.labelGroup.Text = "Группа";
			// 
			// tabPageGroups
			// 
			this.tabPageGroups.Location = new System.Drawing.Point(4, 22);
			this.tabPageGroups.Name = "tabPageGroups";
			this.tabPageGroups.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageGroups.Size = new System.Drawing.Size(792, 424);
			this.tabPageGroups.TabIndex = 1;
			this.tabPageGroups.Text = "Группа";
			this.tabPageGroups.UseVisualStyleBackColor = true;
			// 
			// tabPageSchedule
			// 
			this.tabPageSchedule.Location = new System.Drawing.Point(4, 22);
			this.tabPageSchedule.Name = "tabPageSchedule";
			this.tabPageSchedule.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageSchedule.Size = new System.Drawing.Size(792, 424);
			this.tabPageSchedule.TabIndex = 2;
			this.tabPageSchedule.Text = "Расписание";
			this.tabPageSchedule.UseVisualStyleBackColor = true;
			// 
			// tabPageTeachers
			// 
			this.tabPageTeachers.Location = new System.Drawing.Point(4, 22);
			this.tabPageTeachers.Name = "tabPageTeachers";
			this.tabPageTeachers.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageTeachers.Size = new System.Drawing.Size(792, 424);
			this.tabPageTeachers.TabIndex = 3;
			this.tabPageTeachers.Text = "Учителя";
			this.tabPageTeachers.UseVisualStyleBackColor = true;
			// 
			// statusStrip1
			// 
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabelStudents,
            this.toolStripStatusLabelGroups});
			this.statusStrip1.Location = new System.Drawing.Point(3, 399);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(786, 22);
			this.statusStrip1.TabIndex = 10;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// toolStripStatusLabelStudents
			// 
			this.toolStripStatusLabelStudents.Name = "toolStripStatusLabelStudents";
			this.toolStripStatusLabelStudents.Size = new System.Drawing.Size(135, 17);
			this.toolStripStatusLabelStudents.Text = "Количество студентов: ";
			// 
			// toolStripStatusLabelGroups
			// 
			this.toolStripStatusLabelGroups.Name = "toolStripStatusLabelGroups";
			this.toolStripStatusLabelGroups.Size = new System.Drawing.Size(76, 17);
			this.toolStripStatusLabelGroups.Text = "Всего групп:";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl1);
			this.Name = "MainForm";
			this.Text = "Academy";
			this.tabControl1.ResumeLayout(false);
			this.tabPageStudents.ResumeLayout(false);
			this.tabPageStudents.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage tabPageStudents;
		private System.Windows.Forms.TabPage tabPageGroups;
		private System.Windows.Forms.TabPage tabPageSchedule;
		private System.Windows.Forms.TabPage tabPageTeachers;
		private System.Windows.Forms.ComboBox comboBoxDirections;
		private System.Windows.Forms.ComboBox comboBoxStudentsGroups;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Button btnAdd;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelStudents;
		private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelGroups;
	}
}