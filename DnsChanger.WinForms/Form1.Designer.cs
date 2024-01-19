namespace DnsChanger.WinForms
{
	partial class MainForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			btnSet = new Button();
			btnUnSet = new Button();
			dgvDnsList = new DataGridView();
			Id = new DataGridViewTextBoxColumn();
			Preferred = new DataGridViewTextBoxColumn();
			Alternate = new DataGridViewTextBoxColumn();
			Description = new DataGridViewTextBoxColumn();
			txtDescription = new TextBox();
			txtPre1 = new TextBox();
			label1 = new Label();
			label2 = new Label();
			label3 = new Label();
			label4 = new Label();
			label5 = new Label();
			label6 = new Label();
			txtPre2 = new TextBox();
			txtPre3 = new TextBox();
			txtPre4 = new TextBox();
			txtAlter4 = new TextBox();
			txtAlter3 = new TextBox();
			txtAlter2 = new TextBox();
			label7 = new Label();
			label8 = new Label();
			label9 = new Label();
			txtAlter1 = new TextBox();
			btnSave = new Button();
			((System.ComponentModel.ISupportInitialize)dgvDnsList).BeginInit();
			SuspendLayout();
			// 
			// btnSet
			// 
			btnSet.Location = new Point(12, 321);
			btnSet.Name = "btnSet";
			btnSet.Size = new Size(339, 23);
			btnSet.TabIndex = 0;
			btnSet.Text = "Save and Set";
			btnSet.UseVisualStyleBackColor = true;
			btnSet.Click += btnSet_Click;
			// 
			// btnUnSet
			// 
			btnUnSet.Location = new Point(12, 350);
			btnUnSet.Name = "btnUnSet";
			btnUnSet.Size = new Size(339, 23);
			btnUnSet.TabIndex = 1;
			btnUnSet.Text = "Unset";
			btnUnSet.UseVisualStyleBackColor = true;
			btnUnSet.Click += btnUnSet_Click;
			// 
			// dgvDnsList
			// 
			dgvDnsList.AllowUserToAddRows = false;
			dgvDnsList.AllowUserToDeleteRows = false;
			dgvDnsList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dgvDnsList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dgvDnsList.Columns.AddRange(new DataGridViewColumn[] { Id, Preferred, Alternate, Description });
			dgvDnsList.Location = new Point(12, 12);
			dgvDnsList.Name = "dgvDnsList";
			dgvDnsList.ReadOnly = true;
			dgvDnsList.Size = new Size(339, 177);
			dgvDnsList.TabIndex = 2;
			dgvDnsList.KeyDown += dgvDnsList_KeyDown;
			// 
			// Id
			// 
			Id.DataPropertyName = "Id";
			Id.HeaderText = "Id";
			Id.Name = "Id";
			Id.ReadOnly = true;
			Id.Visible = false;
			// 
			// Preferred
			// 
			Preferred.DataPropertyName = "Preferred";
			Preferred.HeaderText = "Preferred";
			Preferred.Name = "Preferred";
			Preferred.ReadOnly = true;
			// 
			// Alternate
			// 
			Alternate.DataPropertyName = "Alternate";
			Alternate.HeaderText = "Alternate";
			Alternate.Name = "Alternate";
			Alternate.ReadOnly = true;
			// 
			// Description
			// 
			Description.DataPropertyName = "Description";
			Description.HeaderText = "Description";
			Description.Name = "Description";
			Description.ReadOnly = true;
			// 
			// txtDescription
			// 
			txtDescription.Location = new Point(85, 205);
			txtDescription.Name = "txtDescription";
			txtDescription.Size = new Size(266, 23);
			txtDescription.TabIndex = 3;
			txtDescription.TextAlign = HorizontalAlignment.Center;
			// 
			// txtPre1
			// 
			txtPre1.Location = new Point(85, 234);
			txtPre1.Name = "txtPre1";
			txtPre1.Size = new Size(266, 23);
			txtPre1.TabIndex = 4;
			txtPre1.TextAlign = HorizontalAlignment.Center;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(12, 208);
			label1.Name = "label1";
			label1.Size = new Size(67, 15);
			label1.TabIndex = 6;
			label1.Text = "Description";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(12, 237);
			label2.Name = "label2";
			label2.Size = new Size(55, 15);
			label2.TabIndex = 7;
			label2.Text = "Preferred";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(12, 266);
			label3.Name = "label3";
			label3.Size = new Size(55, 15);
			label3.TabIndex = 8;
			label3.Text = "Alternate";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(141, 237);
			label4.Name = "label4";
			label4.Size = new Size(10, 15);
			label4.TabIndex = 10;
			label4.Text = ".";
			label4.Visible = false;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(213, 237);
			label5.Name = "label5";
			label5.Size = new Size(10, 15);
			label5.TabIndex = 11;
			label5.Text = ".";
			label5.Visible = false;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Location = new Point(285, 237);
			label6.Name = "label6";
			label6.Size = new Size(10, 15);
			label6.TabIndex = 13;
			label6.Text = ".";
			label6.Visible = false;
			// 
			// txtPre2
			// 
			txtPre2.Location = new Point(157, 234);
			txtPre2.Name = "txtPre2";
			txtPre2.Size = new Size(50, 23);
			txtPre2.TabIndex = 5;
			txtPre2.Visible = false;
			// 
			// txtPre3
			// 
			txtPre3.Location = new Point(229, 234);
			txtPre3.Name = "txtPre3";
			txtPre3.Size = new Size(50, 23);
			txtPre3.TabIndex = 6;
			txtPre3.Visible = false;
			// 
			// txtPre4
			// 
			txtPre4.Location = new Point(301, 234);
			txtPre4.Name = "txtPre4";
			txtPre4.Size = new Size(50, 23);
			txtPre4.TabIndex = 7;
			txtPre4.Visible = false;
			// 
			// txtAlter4
			// 
			txtAlter4.Location = new Point(301, 263);
			txtAlter4.Name = "txtAlter4";
			txtAlter4.Size = new Size(50, 23);
			txtAlter4.TabIndex = 11;
			txtAlter4.Visible = false;
			// 
			// txtAlter3
			// 
			txtAlter3.Location = new Point(229, 263);
			txtAlter3.Name = "txtAlter3";
			txtAlter3.Size = new Size(50, 23);
			txtAlter3.TabIndex = 10;
			txtAlter3.Visible = false;
			// 
			// txtAlter2
			// 
			txtAlter2.Location = new Point(157, 263);
			txtAlter2.Name = "txtAlter2";
			txtAlter2.Size = new Size(50, 23);
			txtAlter2.TabIndex = 9;
			txtAlter2.Visible = false;
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Location = new Point(285, 266);
			label7.Name = "label7";
			label7.Size = new Size(10, 15);
			label7.TabIndex = 20;
			label7.Text = ".";
			label7.Visible = false;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Location = new Point(213, 266);
			label8.Name = "label8";
			label8.Size = new Size(10, 15);
			label8.TabIndex = 19;
			label8.Text = ".";
			label8.Visible = false;
			// 
			// label9
			// 
			label9.AutoSize = true;
			label9.Location = new Point(141, 266);
			label9.Name = "label9";
			label9.Size = new Size(10, 15);
			label9.TabIndex = 18;
			label9.Text = ".";
			label9.Visible = false;
			// 
			// txtAlter1
			// 
			txtAlter1.Location = new Point(85, 263);
			txtAlter1.Name = "txtAlter1";
			txtAlter1.Size = new Size(266, 23);
			txtAlter1.TabIndex = 8;
			txtAlter1.TextAlign = HorizontalAlignment.Center;
			// 
			// btnSave
			// 
			btnSave.Location = new Point(12, 292);
			btnSave.Name = "btnSave";
			btnSave.Size = new Size(339, 23);
			btnSave.TabIndex = 12;
			btnSave.Text = "Save";
			btnSave.UseVisualStyleBackColor = true;
			btnSave.Click += btnSave_Click;
			// 
			// MainForm
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			AutoSize = true;
			ClientSize = new Size(364, 383);
			Controls.Add(btnSave);
			Controls.Add(txtAlter4);
			Controls.Add(txtAlter3);
			Controls.Add(txtAlter2);
			Controls.Add(label7);
			Controls.Add(label8);
			Controls.Add(label9);
			Controls.Add(txtAlter1);
			Controls.Add(txtPre4);
			Controls.Add(txtPre3);
			Controls.Add(txtPre2);
			Controls.Add(label6);
			Controls.Add(label5);
			Controls.Add(label4);
			Controls.Add(label3);
			Controls.Add(label2);
			Controls.Add(label1);
			Controls.Add(txtPre1);
			Controls.Add(txtDescription);
			Controls.Add(dgvDnsList);
			Controls.Add(btnUnSet);
			Controls.Add(btnSet);
			FormBorderStyle = FormBorderStyle.FixedSingle;
			Icon = (Icon)resources.GetObject("$this.Icon");
			Name = "MainForm";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Dns Changer";
			Load += MainForm_Load;
			((System.ComponentModel.ISupportInitialize)dgvDnsList).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Button btnSet;
		private Button btnUnSet;
		private DataGridView dgvDnsList;
		private TextBox txtDescription;
		private TextBox txtPre1;
		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private TextBox txtPre2;
		private TextBox txtPre3;
		private TextBox txtPre4;
		private TextBox txtAlter4;
		private TextBox txtAlter3;
		private TextBox txtAlter2;
		private Label label7;
		private Label label8;
		private Label label9;
		private TextBox txtAlter1;
		private DataGridViewTextBoxColumn Id;
		private DataGridViewTextBoxColumn Preferred;
		private DataGridViewTextBoxColumn Alternate;
		private DataGridViewTextBoxColumn Description;
		private Button btnSave;
	}
}
