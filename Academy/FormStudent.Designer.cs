namespace Academy
{
	partial class Student
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Student));
			this.labelLast_name = new System.Windows.Forms.Label();
			this.labelFirst_name = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.richTextBoxLastName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxFirstName = new System.Windows.Forms.RichTextBox();
			this.richTextBoxMiddleName = new System.Windows.Forms.RichTextBox();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.labelEmail = new System.Windows.Forms.Label();
			this.labelPhone = new System.Windows.Forms.Label();
			this.richTextBoxPhone = new System.Windows.Forms.RichTextBox();
			this.richTextBoxEmail = new System.Windows.Forms.RichTextBox();
			this.labelGroup = new System.Windows.Forms.Label();
			this.labelDirection = new System.Windows.Forms.Label();
			this.comboBoxDirections = new System.Windows.Forms.ComboBox();
			this.comboBoxGroups = new System.Windows.Forms.ComboBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.btnBrowse = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// labelLast_name
			// 
			this.labelLast_name.AutoSize = true;
			this.labelLast_name.Location = new System.Drawing.Point(76, 15);
			this.labelLast_name.Name = "labelLast_name";
			this.labelLast_name.Size = new System.Drawing.Size(62, 13);
			this.labelLast_name.TabIndex = 0;
			this.labelLast_name.Text = "Фамилия: ";
			// 
			// labelFirst_name
			// 
			this.labelFirst_name.AutoSize = true;
			this.labelFirst_name.Location = new System.Drawing.Point(103, 45);
			this.labelFirst_name.Name = "labelFirst_name";
			this.labelFirst_name.Size = new System.Drawing.Size(35, 13);
			this.labelFirst_name.TabIndex = 1;
			this.labelFirst_name.Text = "Имя: ";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Location = new System.Drawing.Point(76, 75);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(57, 13);
			this.labelMiddleName.TabIndex = 4;
			this.labelMiddleName.Text = "Отчество:";
			// 
			// richTextBoxLastName
			// 
			this.richTextBoxLastName.Location = new System.Drawing.Point(144, 12);
			this.richTextBoxLastName.MaxLength = 128;
			this.richTextBoxLastName.Multiline = false;
			this.richTextBoxLastName.Name = "richTextBoxLastName";
			this.richTextBoxLastName.Size = new System.Drawing.Size(224, 24);
			this.richTextBoxLastName.TabIndex = 4;
			this.richTextBoxLastName.Text = "";
			// 
			// richTextBoxFirstName
			// 
			this.richTextBoxFirstName.Location = new System.Drawing.Point(144, 42);
			this.richTextBoxFirstName.MaxLength = 128;
			this.richTextBoxFirstName.Multiline = false;
			this.richTextBoxFirstName.Name = "richTextBoxFirstName";
			this.richTextBoxFirstName.Size = new System.Drawing.Size(224, 24);
			this.richTextBoxFirstName.TabIndex = 5;
			this.richTextBoxFirstName.Text = "";
			// 
			// richTextBoxMiddleName
			// 
			this.richTextBoxMiddleName.Location = new System.Drawing.Point(144, 72);
			this.richTextBoxMiddleName.MaxLength = 128;
			this.richTextBoxMiddleName.Multiline = false;
			this.richTextBoxMiddleName.Name = "richTextBoxMiddleName";
			this.richTextBoxMiddleName.Size = new System.Drawing.Size(224, 24);
			this.richTextBoxMiddleName.TabIndex = 6;
			this.richTextBoxMiddleName.Text = "";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Location = new System.Drawing.Point(49, 108);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(89, 13);
			this.labelBirthDate.TabIndex = 8;
			this.labelBirthDate.Text = "Дата рождения:";
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.Location = new System.Drawing.Point(144, 102);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(224, 20);
			this.dateTimePicker1.TabIndex = 9;
			// 
			// labelEmail
			// 
			this.labelEmail.AutoSize = true;
			this.labelEmail.Location = new System.Drawing.Point(95, 154);
			this.labelEmail.Name = "labelEmail";
			this.labelEmail.Size = new System.Drawing.Size(38, 13);
			this.labelEmail.TabIndex = 14;
			this.labelEmail.Text = "E-mail:";
			// 
			// labelPhone
			// 
			this.labelPhone.AutoSize = true;
			this.labelPhone.Location = new System.Drawing.Point(78, 184);
			this.labelPhone.Name = "labelPhone";
			this.labelPhone.Size = new System.Drawing.Size(55, 13);
			this.labelPhone.TabIndex = 15;
			this.labelPhone.Text = "Телефон:";
			// 
			// richTextBoxPhone
			// 
			this.richTextBoxPhone.Location = new System.Drawing.Point(144, 181);
			this.richTextBoxPhone.MaxLength = 17;
			this.richTextBoxPhone.Multiline = false;
			this.richTextBoxPhone.Name = "richTextBoxPhone";
			this.richTextBoxPhone.Size = new System.Drawing.Size(224, 24);
			this.richTextBoxPhone.TabIndex = 16;
			this.richTextBoxPhone.Text = "";
			// 
			// richTextBoxEmail
			// 
			this.richTextBoxEmail.Location = new System.Drawing.Point(144, 151);
			this.richTextBoxEmail.MaxLength = 128;
			this.richTextBoxEmail.Multiline = false;
			this.richTextBoxEmail.Name = "richTextBoxEmail";
			this.richTextBoxEmail.Size = new System.Drawing.Size(224, 24);
			this.richTextBoxEmail.TabIndex = 17;
			this.richTextBoxEmail.Text = "";
			// 
			// labelGroup
			// 
			this.labelGroup.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelGroup.AutoSize = true;
			this.labelGroup.Location = new System.Drawing.Point(88, 268);
			this.labelGroup.Name = "labelGroup";
			this.labelGroup.Size = new System.Drawing.Size(45, 13);
			this.labelGroup.TabIndex = 18;
			this.labelGroup.Text = "Группа:";
			// 
			// labelDirection
			// 
			this.labelDirection.Anchor = System.Windows.Forms.AnchorStyles.Left;
			this.labelDirection.AutoSize = true;
			this.labelDirection.Location = new System.Drawing.Point(11, 238);
			this.labelDirection.Name = "labelDirection";
			this.labelDirection.Size = new System.Drawing.Size(127, 13);
			this.labelDirection.TabIndex = 19;
			this.labelDirection.Text = "Направление обучения:";
			// 
			// comboBoxDirections
			// 
			this.comboBoxDirections.FormattingEnabled = true;
			this.comboBoxDirections.Location = new System.Drawing.Point(144, 235);
			this.comboBoxDirections.Name = "comboBoxDirections";
			this.comboBoxDirections.Size = new System.Drawing.Size(224, 21);
			this.comboBoxDirections.TabIndex = 20;
			// 
			// comboBoxGroups
			// 
			this.comboBoxGroups.FormattingEnabled = true;
			this.comboBoxGroups.Location = new System.Drawing.Point(144, 265);
			this.comboBoxGroups.Name = "comboBoxGroups";
			this.comboBoxGroups.Size = new System.Drawing.Size(224, 21);
			this.comboBoxGroups.TabIndex = 21;
			// 
			// btnSave
			// 
			this.btnSave.DialogResult = System.Windows.Forms.DialogResult.OK;
			this.btnSave.Location = new System.Drawing.Point(404, 263);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(75, 23);
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Сохранить";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			this.btnCancel.Location = new System.Drawing.Point(485, 263);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(75, 23);
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "Отмена";
			this.btnCancel.UseVisualStyleBackColor = true;
			// 
			// btnBrowse
			// 
			this.btnBrowse.Location = new System.Drawing.Point(485, 205);
			this.btnBrowse.Name = "btnBrowse";
			this.btnBrowse.Size = new System.Drawing.Size(75, 23);
			this.btnBrowse.TabIndex = 24;
			this.btnBrowse.Text = "Обзор";
			this.btnBrowse.UseVisualStyleBackColor = true;
			this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(385, 10);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(175, 193);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 26;
			this.pictureBox1.TabStop = false;
			// 
			// Student
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(567, 305);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.btnBrowse);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.comboBoxGroups);
			this.Controls.Add(this.comboBoxDirections);
			this.Controls.Add(this.labelGroup);
			this.Controls.Add(this.labelDirection);
			this.Controls.Add(this.richTextBoxEmail);
			this.Controls.Add(this.richTextBoxPhone);
			this.Controls.Add(this.labelPhone);
			this.Controls.Add(this.labelEmail);
			this.Controls.Add(this.dateTimePicker1);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.richTextBoxMiddleName);
			this.Controls.Add(this.richTextBoxFirstName);
			this.Controls.Add(this.richTextBoxLastName);
			this.Controls.Add(this.labelFirst_name);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelLast_name);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Student";
			this.Text = "Студент";
			this.TopMost = true;
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label labelLast_name;
		private System.Windows.Forms.Label labelFirst_name;
		private System.Windows.Forms.RichTextBox richTextBoxMiddleName;
		private System.Windows.Forms.RichTextBox richTextBoxFirstName;
		private System.Windows.Forms.RichTextBox richTextBoxLastName;
		private System.Windows.Forms.Label labelMiddleName;
		private System.Windows.Forms.Label labelBirthDate;
		private System.Windows.Forms.DateTimePicker dateTimePicker1;
		private System.Windows.Forms.Label labelEmail;
		private System.Windows.Forms.Label labelPhone;
		private System.Windows.Forms.RichTextBox richTextBoxPhone;
		private System.Windows.Forms.RichTextBox richTextBoxEmail;
		private System.Windows.Forms.Label labelGroup;
		private System.Windows.Forms.Label labelDirection;
		private System.Windows.Forms.ComboBox comboBoxDirections;
		private System.Windows.Forms.ComboBox comboBoxGroups;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.Button btnBrowse;
		private System.Windows.Forms.PictureBox pictureBox1;
	}
}