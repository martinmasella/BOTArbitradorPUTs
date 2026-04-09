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
			txtLimite = new TextBox();
			label4 = new Label();
			txtLiquidez = new TextBox();
			label8 = new Label();
			chkAuto = new CheckBox();
			cmbUmbral = new ComboBox();
			lblUmbral = new Label();
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
			grdDatos = new DataGridView();
			grbLogin.SuspendLayout();
			grbLog.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)grdDatos).BeginInit();
			SuspendLayout();
			// 
			// grbLogin
			// 
			grbLogin.BackColor = Color.FromArgb(45, 45, 65);
			grbLogin.Controls.Add(txtLimite);
			grbLogin.Controls.Add(label4);
			grbLogin.Controls.Add(txtLiquidez);
			grbLogin.Controls.Add(label8);
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
			grbLogin.Location = new Point(12, 279);
			grbLogin.Name = "grbLogin";
			grbLogin.Size = new Size(666, 113);
			grbLogin.TabIndex = 0;
			grbLogin.TabStop = false;
			grbLogin.Text = "Logins";
			// 
			// txtLimite
			// 
			txtLimite.BackColor = Color.FromArgb(55, 55, 75);
			txtLimite.BorderStyle = BorderStyle.FixedSingle;
			txtLimite.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtLimite.ForeColor = Color.FromArgb(226, 232, 240);
			txtLimite.Location = new Point(294, 76);
			txtLimite.Name = "txtLimite";
			txtLimite.Size = new Size(111, 31);
			txtLimite.TabIndex = 16;
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label4.ForeColor = Color.FromArgb(148, 163, 184);
			label4.Location = new Point(234, 78);
			label4.Name = "label4";
			label4.Size = new Size(59, 25);
			label4.TabIndex = 15;
			label4.Text = "Limite";
			// 
			// txtLiquidez
			// 
			txtLiquidez.BackColor = Color.FromArgb(55, 55, 75);
			txtLiquidez.BorderStyle = BorderStyle.FixedSingle;
			txtLiquidez.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtLiquidez.ForeColor = Color.FromArgb(226, 232, 240);
			txtLiquidez.Location = new Point(131, 75);
			txtLiquidez.Name = "txtLiquidez";
			txtLiquidez.Size = new Size(104, 31);
			txtLiquidez.TabIndex = 14;
			// 
			// label8
			// 
			label8.AutoSize = true;
			label8.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label8.ForeColor = Color.FromArgb(148, 163, 184);
			label8.Location = new Point(53, 78);
			label8.Name = "label8";
			label8.Size = new Size(77, 25);
			label8.TabIndex = 13;
			label8.Text = "Liquidez";
			// 
			// chkAuto
			// 
			chkAuto.AutoSize = true;
			chkAuto.CheckAlign = ContentAlignment.MiddleRight;
			chkAuto.Checked = true;
			chkAuto.CheckState = CheckState.Checked;
			chkAuto.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			chkAuto.ForeColor = Color.FromArgb(226, 232, 240);
			chkAuto.Location = new Point(526, 55);
			chkAuto.Name = "chkAuto";
			chkAuto.Size = new Size(77, 29);
			chkAuto.TabIndex = 2;
			chkAuto.Text = "Auto";
			chkAuto.TextAlign = ContentAlignment.MiddleRight;
			chkAuto.UseVisualStyleBackColor = true;
			// 
			// cmbUmbral
			// 
			cmbUmbral.BackColor = Color.FromArgb(55, 55, 75);
			cmbUmbral.DropDownStyle = ComboBoxStyle.DropDownList;
			cmbUmbral.FlatStyle = FlatStyle.Flat;
			cmbUmbral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			cmbUmbral.ForeColor = Color.FromArgb(226, 232, 240);
			cmbUmbral.Items.AddRange(new object[] { "0,1", "0,2", "0,3", "0,4", "0,5", "0,6", "0,7", "0,8" });
			cmbUmbral.Location = new Point(582, 22);
			cmbUmbral.Name = "cmbUmbral";
			cmbUmbral.Size = new Size(70, 33);
			cmbUmbral.TabIndex = 1;
			// 
			// lblUmbral
			// 
			lblUmbral.AutoSize = true;
			lblUmbral.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			lblUmbral.ForeColor = Color.FromArgb(148, 163, 184);
			lblUmbral.Location = new Point(502, 22);
			lblUmbral.Name = "lblUmbral";
			lblUmbral.Size = new Size(74, 25);
			lblUmbral.TabIndex = 0;
			lblUmbral.Text = "Umbral:";
			// 
			// txtClaveVETA
			// 
			txtClaveVETA.BackColor = Color.FromArgb(55, 55, 75);
			txtClaveVETA.BorderStyle = BorderStyle.FixedSingle;
			txtClaveVETA.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			txtClaveVETA.ForeColor = Color.FromArgb(226, 232, 240);
			txtClaveVETA.Location = new Point(294, 49);
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
			label5.Location = new Point(234, 51);
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
			txtUsuarioVETA.Location = new Point(131, 48);
			txtUsuarioVETA.Name = "txtUsuarioVETA";
			txtUsuarioVETA.Size = new Size(104, 31);
			txtUsuarioVETA.TabIndex = 10;
			// 
			// label6
			// 
			label6.AutoSize = true;
			label6.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label6.ForeColor = Color.FromArgb(148, 163, 184);
			label6.Location = new Point(53, 51);
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
			label7.Location = new Point(7, 51);
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
			btnLogin.Location = new Point(411, 20);
			btnLogin.Name = "btnLogin";
			btnLogin.Size = new Size(85, 86);
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
			txtClaveIOL.Location = new Point(294, 20);
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
			label3.Location = new Point(234, 22);
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
			txtUsuarioIOL.Location = new Point(131, 19);
			txtUsuarioIOL.Name = "txtUsuarioIOL";
			txtUsuarioIOL.Size = new Size(104, 31);
			txtUsuarioIOL.TabIndex = 2;
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
			label2.ForeColor = Color.FromArgb(148, 163, 184);
			label2.Location = new Point(53, 22);
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
			label1.Location = new Point(7, 24);
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
			grbLog.Location = new Point(686, 280);
			grbLog.Name = "grbLog";
			grbLog.Size = new Size(424, 113);
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
			lbLog.Size = new Size(402, 77);
			lbLog.TabIndex = 0;
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
			grdDatos.Size = new Size(1115, 277);
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
		private TextBox txtLimite;
		private Label label4;
		private TextBox txtLiquidez;
		private Label label8;
	}
}