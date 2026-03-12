namespace BOTArbitradorPUTs
{
    partial class frmMain
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
			DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
			DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
			grbLogin = new GroupBox();
			txtClaveVETA = new TextBox();
			label5 = new Label();
			txtUsuarioVETA = new TextBox();
			label6 = new Label();
			label7 = new Label();
			btnLogin = new Button();
			txtClaveIOL = new TextBox();
			label3 = new Label();
			txtUsuarioIOL = new TextBox();
			label2 = new Label();
			label1 = new Label();
			grbLog = new GroupBox();
			lbLog = new ListBox();
			lblUmbral = new Label();
			cmbUmbral = new ComboBox();
			chkAuto = new CheckBox();
			grdDatos = new DataGridView();
			grbLogin.SuspendLayout();
			grbLog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grdDatos).BeginInit();
			SuspendLayout();
			// 
			// grbLogin
			// 
			grbLogin.BackColor = Color.FromArgb(45, 45, 65);
			grbLogin.Controls.Add(chkAuto);
			grbLogin.Controls.Add(cmbUmbral);
			grbLogin.Controls.Add(lblUmbral);
			grbLogin.Controls.Add(txtClaveVETA);
			grbLogin.Controls.Add(label5);
			grbLogin.Controls.Add(txtUsuarioVETA);
			grbLogin.Controls.Add(label6);
			grbLogin.Controls.Add(label7);
			grbLogin.Controls.Add(btnLogin);
			grbLogin.Controls.Add(txtClaveIOL);
			grbLogin.Controls.Add(label3);
			grbLogin.Controls.Add(txtUsuarioIOL);
			grbLogin.Controls.Add(label2);
			grbLogin.Controls.Add(label1);
			grbLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			grbLogin.ForeColor = Color.FromArgb(226, 232, 240);
			grbLogin.Location = new Point(12, 299);
			grbLogin.Name = "grbLogin";
			grbLogin.Size = new Size(666, 88);
			grbLogin.TabIndex = 0;
			grbLogin.TabStop = false;
			grbLogin.Text = "Logins";
			// 
			// txtClaveVETA
			// 
			txtClaveVETA.BackColor = Color.FromArgb(55, 55, 75);
			txtClaveVETA.BorderStyle = BorderStyle.FixedSingle;
			txtClaveVETA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtClaveVETA.ForeColor = Color.FromArgb(226, 232, 240);
			txtClaveVETA.Location = new Point(294, 48);
			txtClaveVETA.Name = "txtClaveVETA";
			txtClaveVETA.Size = new Size(111, 31);
			txtClaveVETA.TabIndex = 12;
			txtClaveVETA.UseSystemPasswordChar = true;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label5.ForeColor = Color.FromArgb(148, 163, 184);
			label5.Location = new Point(234, 50);
			label5.Name = "label5";
			label5.Size = new Size(54, 25);
			label5.TabIndex = 11;
			label5.Text = "Clave";
			// 
			// txtUsuarioVETA
			// 
			txtUsuarioVETA.BackColor = Color.FromArgb(55, 55, 75);
			txtUsuarioVETA.BorderStyle = BorderStyle.FixedSingle;
			txtUsuarioVETA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuarioVETA.ForeColor = Color.FromArgb(226, 232, 240);
			txtUsuarioVETA.Location = new Point(131, 47);
			txtUsuarioVETA.Name = "txtUsuarioVETA";
			txtUsuarioVETA.Size = new Size(104, 31);
			txtUsuarioVETA.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.FromArgb(148, 163, 184);
			label6.Location = new Point(53, 50);
			label6.Name = "label6";
			label6.Size = new Size(72, 25);
			label6.TabIndex = 9;
			label6.Text = "Usuario";
			// 
			// label7
			// 
			label7.AutoSize = true;
			label7.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label7.ForeColor = Color.FromArgb(99, 102, 241);
			label7.Location = new Point(7, 50);
			label7.Name = "label7";
			label7.Size = new Size(54, 25);
			label7.TabIndex = 8;
			label7.Text = "VETA";
			// 
			// btnLogin
			// 
			btnLogin.BackColor = Color.FromArgb(99, 102, 241);
			btnLogin.Cursor = Cursors.Hand;
			btnLogin.FlatAppearance.BorderSize = 0;
			btnLogin.FlatStyle = FlatStyle.Flat;
			btnLogin.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			btnLogin.ForeColor = Color.White;
			btnLogin.Location = new Point(411, 19);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(85, 58);
			btnLogin.TabIndex = 5;
			btnLogin.Text = "Login";
			btnLogin.UseVisualStyleBackColor = false;
			btnLogin.Click += btnLogin_Click;
			// 
			// txtClaveIOL
			// 
			txtClaveIOL.BackColor = Color.FromArgb(55, 55, 75);
			txtClaveIOL.BorderStyle = BorderStyle.FixedSingle;
			txtClaveIOL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtClaveIOL.ForeColor = Color.FromArgb(226, 232, 240);
			txtClaveIOL.Location = new Point(294, 19);
			txtClaveIOL.Name = "txtClaveIOL";
			txtClaveIOL.Size = new Size(111, 31);
			txtClaveIOL.TabIndex = 4;
			txtClaveIOL.UseSystemPasswordChar = true;
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label3.ForeColor = Color.FromArgb(148, 163, 184);
			label3.Location = new Point(234, 21);
			label3.Name = "label3";
			label3.Size = new Size(54, 25);
			label3.TabIndex = 3;
			label3.Text = "Clave";
			// 
			// txtUsuarioIOL
			// 
			txtUsuarioIOL.BackColor = Color.FromArgb(55, 55, 75);
			txtUsuarioIOL.BorderStyle = BorderStyle.FixedSingle;
			txtUsuarioIOL.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtUsuarioIOL.ForeColor = Color.FromArgb(226, 232, 240);
			txtUsuarioIOL.Location = new Point(131, 18);
			txtUsuarioIOL.Name = "txtUsuarioIOL";
			txtUsuarioIOL.Size = new Size(104, 31);
			txtUsuarioIOL.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(148, 163, 184);
			label2.Location = new Point(53, 21);
			label2.Name = "label2";
			label2.Size = new Size(72, 25);
			label2.TabIndex = 1;
			label2.Text = "Usuario";
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			label1.ForeColor = Color.FromArgb(99, 102, 241);
			label1.Location = new Point(7, 21);
			label1.Name = "label1";
			label1.Size = new Size(40, 25);
			label1.TabIndex = 0;
			label1.Text = "IOL";
			// 
			// grbLog
			// 
			grbLog.BackColor = Color.FromArgb(45, 45, 65);
			grbLog.Controls.Add(lbLog);
			grbLog.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			grbLog.ForeColor = Color.FromArgb(226, 232, 240);
			grbLog.Location = new Point(686, 300);
			grbLog.Name = "grbLog";
			grbLog.Size = new Size(424, 88);
			grbLog.TabIndex = 1;
			grbLog.TabStop = false;
			grbLog.Text = "Log";
			// 
			// lbLog
			// 
			lbLog.BackColor = Color.FromArgb(55, 55, 75);
			lbLog.BorderStyle = BorderStyle.FixedSingle;
			lbLog.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lbLog.ForeColor = Color.FromArgb(226, 232, 240);
			lbLog.FormattingEnabled = true;
			lbLog.ItemHeight = 25;
			lbLog.Location = new Point(10, 25);
			lbLog.Name = "lbLog";
			lbLog.Size = new Size(402, 52);
			lbLog.TabIndex = 0;
			// 
			// lblUmbral
			// 
			lblUmbral.AutoSize = true;
			lblUmbral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblUmbral.ForeColor = Color.FromArgb(148, 163, 184);
			lblUmbral.Location = new Point(502, 21);
			lblUmbral.Name = "lblUmbral";
			lblUmbral.Size = new Size(74, 25);
			lblUmbral.TabIndex = 0;
			lblUmbral.Text = "Umbral:";
			// 
			// cmbUmbral
			// 
			cmbUmbral.BackColor = Color.FromArgb(55, 55, 75);
			cmbUmbral.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbUmbral.FlatStyle = FlatStyle.Flat;
			cmbUmbral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			cmbUmbral.ForeColor = Color.FromArgb(226, 232, 240);
			cmbUmbral.Items.AddRange(new object[] { "0,1", "0,2", "0,3", "0,4", "0,5", "0,6", "0,7", "0,8" });
			cmbUmbral.Location = new Point(582, 21);
			cmbUmbral.Name = "cmbUmbral";
			cmbUmbral.Size = new Size(70, 33);
			cmbUmbral.TabIndex = 1;
			// 
			// chkAuto
			// 
			chkAuto.AutoSize = true;
			chkAuto.CheckAlign = ContentAlignment.MiddleRight;
			chkAuto.Checked = true;
			chkAuto.CheckState = CheckState.Checked;
			chkAuto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			chkAuto.ForeColor = Color.FromArgb(226, 232, 240);
			chkAuto.Location = new Point(526, 54);
			chkAuto.Name = "chkAuto";
			chkAuto.Size = new Size(77, 29);
			chkAuto.TabIndex = 2;
			chkAuto.Text = "Auto";
			chkAuto.TextAlign = ContentAlignment.MiddleRight;
			chkAuto.UseVisualStyleBackColor = true;
			// 
			// grdDatos
			// 
			grdDatos.AllowUserToAddRows = false;
			grdDatos.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = Color.FromArgb(40, 40, 58);
			grdDatos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			grdDatos.BackgroundColor = Color.FromArgb(30, 30, 46);
			grdDatos.BorderStyle = BorderStyle.None;
			dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle2.BackColor = Color.FromArgb(59, 130, 246);
			dataGridViewCellStyle2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
			dataGridViewCellStyle2.ForeColor = Color.White;
			dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
			grdDatos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			grdDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridViewCellStyle3.BackColor = Color.FromArgb(45, 45, 65);
			dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle3.ForeColor = Color.FromArgb(226, 232, 240);
			dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(99, 102, 241);
			dataGridViewCellStyle3.SelectionForeColor = Color.White;
			dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
			grdDatos.DefaultCellStyle = dataGridViewCellStyle3;
			grdDatos.EnableHeadersVisualStyles = false;
			grdDatos.GridColor = Color.FromArgb(60, 60, 80);
			grdDatos.Location = new Point(-5, 0);
			grdDatos.Name = "grdDatos";
			grdDatos.ReadOnly = true;
			dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = Color.FromArgb(45, 45, 65);
			dataGridViewCellStyle4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			dataGridViewCellStyle4.ForeColor = Color.FromArgb(226, 232, 240);
			dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
			grdDatos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
			grdDatos.RowHeadersWidth = 62;
			grdDatos.RowTemplate.DefaultCellStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			grdDatos.RowTemplate.Height = 24;
			grdDatos.Size = new Size(1115, 293);
			grdDatos.TabIndex = 2;
			// 
			// frmMain
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = Color.FromArgb(30, 30, 46);
			ClientSize = new Size(1122, 400);
			Controls.Add(grdDatos);
			Controls.Add(grbLog);
			Controls.Add(grbLogin);
			Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			ForeColor = Color.FromArgb(226, 232, 240);
			Name = "frmMain";
			Text = "Form1";
			Load += frmMain_Load;
			grbLogin.ResumeLayout(false);
			grbLogin.PerformLayout();
			grbLog.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)grdDatos).EndInit();
			ResumeLayout(false);
		}

		#endregion

		private GroupBox grbLogin;
        private TextBox txtUsuarioIOL;
        private Label label2;
        private Label label1;
        private TextBox txtClaveVETA;
        private Label label5;
        private TextBox txtUsuarioVETA;
        private Label label6;
        private Label label7;
        private Button btnLogin;
        private TextBox txtClaveIOL;
        private Label label3;
        private GroupBox grbLog;
        private ListBox lbLog;
        private DataGridView grdDatos;
		private Label lblUmbral;
		private ComboBox cmbUmbral;
		private CheckBox chkAuto;
	}
}