namespace Police
{
	partial class Police
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Police));
			this.tabControl = new System.Windows.Forms.TabControl();
			this.tabPageViolations = new System.Windows.Forms.TabPage();
			this.btnAlterViolation = new System.Windows.Forms.Button();
			this.btnAddViolation = new System.Windows.Forms.Button();
			this.labelViolationType = new System.Windows.Forms.Label();
			this.comboBoxViolationType = new System.Windows.Forms.ComboBox();
			this.dataGridView = new System.Windows.Forms.DataGridView();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tabControl.SuspendLayout();
			this.tabPageViolations.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
			this.SuspendLayout();
			// 
			// tabControl
			// 
			this.tabControl.Controls.Add(this.tabPageViolations);
			this.tabControl.Controls.Add(this.tabPage2);
			this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl.Location = new System.Drawing.Point(0, 0);
			this.tabControl.Name = "tabControl";
			this.tabControl.SelectedIndex = 0;
			this.tabControl.Size = new System.Drawing.Size(800, 450);
			this.tabControl.TabIndex = 0;
			// 
			// tabPageViolations
			// 
			this.tabPageViolations.Controls.Add(this.btnAlterViolation);
			this.tabPageViolations.Controls.Add(this.btnAddViolation);
			this.tabPageViolations.Controls.Add(this.labelViolationType);
			this.tabPageViolations.Controls.Add(this.comboBoxViolationType);
			this.tabPageViolations.Controls.Add(this.dataGridView);
			this.tabPageViolations.Location = new System.Drawing.Point(4, 22);
			this.tabPageViolations.Name = "tabPageViolations";
			this.tabPageViolations.Padding = new System.Windows.Forms.Padding(3);
			this.tabPageViolations.Size = new System.Drawing.Size(792, 424);
			this.tabPageViolations.TabIndex = 0;
			this.tabPageViolations.Text = "Violations";
			this.tabPageViolations.UseVisualStyleBackColor = true;
			// 
			// btnAlterViolation
			// 
			this.btnAlterViolation.Location = new System.Drawing.Point(628, 6);
			this.btnAlterViolation.Name = "btnAlterViolation";
			this.btnAlterViolation.Size = new System.Drawing.Size(75, 23);
			this.btnAlterViolation.TabIndex = 4;
			this.btnAlterViolation.Text = "Изменить";
			this.btnAlterViolation.UseVisualStyleBackColor = true;
			// 
			// btnAddViolation
			// 
			this.btnAddViolation.Location = new System.Drawing.Point(709, 6);
			this.btnAddViolation.Name = "btnAddViolation";
			this.btnAddViolation.Size = new System.Drawing.Size(75, 23);
			this.btnAddViolation.TabIndex = 3;
			this.btnAddViolation.Text = "Добавить";
			this.btnAddViolation.UseVisualStyleBackColor = true;
			this.btnAddViolation.Click += new System.EventHandler(this.btnAddViolation_Click);
			// 
			// labelViolationType
			// 
			this.labelViolationType.AutoSize = true;
			this.labelViolationType.Location = new System.Drawing.Point(8, 11);
			this.labelViolationType.Name = "labelViolationType";
			this.labelViolationType.Size = new System.Drawing.Size(86, 13);
			this.labelViolationType.TabIndex = 2;
			this.labelViolationType.Text = "Тип Нарушения";
			// 
			// comboBoxViolationType
			// 
			this.comboBoxViolationType.FormattingEnabled = true;
			this.comboBoxViolationType.Location = new System.Drawing.Point(100, 8);
			this.comboBoxViolationType.Name = "comboBoxViolationType";
			this.comboBoxViolationType.Size = new System.Drawing.Size(522, 21);
			this.comboBoxViolationType.TabIndex = 1;
			this.comboBoxViolationType.SelectedIndexChanged += new System.EventHandler(this.comboBoxViolationType_SelectedIndexChanged);
			// 
			// dataGridView
			// 
			this.dataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView.Location = new System.Drawing.Point(8, 35);
			this.dataGridView.Name = "dataGridView";
			this.dataGridView.Size = new System.Drawing.Size(776, 381);
			this.dataGridView.TabIndex = 0;
			// 
			// tabPage2
			// 
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(792, 424);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "tabPage2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// Police
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.tabControl);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "Police";
			this.Text = "Police Base";
			this.tabControl.ResumeLayout(false);
			this.tabPageViolations.ResumeLayout(false);
			this.tabPageViolations.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TabControl tabControl;
		private System.Windows.Forms.TabPage tabPageViolations;
		private System.Windows.Forms.TabPage tabPage2;
		private System.Windows.Forms.DataGridView dataGridView;
		private System.Windows.Forms.ComboBox comboBoxViolationType;
		private System.Windows.Forms.Label labelViolationType;
		private System.Windows.Forms.Button btnAlterViolation;
		private System.Windows.Forms.Button btnAddViolation;
	}
}

