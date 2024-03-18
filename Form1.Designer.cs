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
            grdDatos = new DataGridView();
            grbLogin.SuspendLayout();
            grbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)grdDatos).BeginInit();
            SuspendLayout();
            // 
            // grbLogin
            // 
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
            grbLogin.Location = new Point(12, 227);
            grbLogin.Name = "grbLogin";
            grbLogin.Size = new Size(366, 77);
            grbLogin.TabIndex = 0;
            grbLogin.TabStop = false;
            grbLogin.Text = "Logins";
            // 
            // txtClaveVETA
            // 
            txtClaveVETA.Location = new Point(217, 47);
            txtClaveVETA.Name = "txtClaveVETA";
            txtClaveVETA.Size = new Size(76, 23);
            txtClaveVETA.TabIndex = 12;
            txtClaveVETA.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(175, 50);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 11;
            label5.Text = "Clave";
            // 
            // txtUsuarioVETA
            // 
            txtUsuarioVETA.Location = new Point(97, 47);
            txtUsuarioVETA.Name = "txtUsuarioVETA";
            txtUsuarioVETA.Size = new Size(68, 23);
            txtUsuarioVETA.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(42, 50);
            label6.Name = "label6";
            label6.Size = new Size(47, 15);
            label6.TabIndex = 9;
            label6.Text = "Usuario";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(7, 50);
            label7.Name = "label7";
            label7.Size = new Size(33, 15);
            label7.TabIndex = 8;
            label7.Text = "VETA";
            // 
            // btnLogin
            // 
            btnLogin.Location = new Point(305, 18);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(51, 52);
            btnLogin.TabIndex = 5;
            btnLogin.Text = "Login";
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // txtClaveIOL
            // 
            txtClaveIOL.Location = new Point(217, 18);
            txtClaveIOL.Name = "txtClaveIOL";
            txtClaveIOL.Size = new Size(76, 23);
            txtClaveIOL.TabIndex = 4;
            txtClaveIOL.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 21);
            label3.Name = "label3";
            label3.Size = new Size(36, 15);
            label3.TabIndex = 3;
            label3.Text = "Clave";
            // 
            // txtUsuarioIOL
            // 
            txtUsuarioIOL.Location = new Point(97, 18);
            txtUsuarioIOL.Name = "txtUsuarioIOL";
            txtUsuarioIOL.Size = new Size(68, 23);
            txtUsuarioIOL.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(42, 21);
            label2.Name = "label2";
            label2.Size = new Size(47, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(7, 21);
            label1.Name = "label1";
            label1.Size = new Size(25, 15);
            label1.TabIndex = 0;
            label1.Text = "IOL";
            // 
            // grbLog
            // 
            grbLog.Controls.Add(lbLog);
            grbLog.Location = new Point(384, 227);
            grbLog.Name = "grbLog";
            grbLog.Size = new Size(246, 77);
            grbLog.TabIndex = 1;
            grbLog.TabStop = false;
            grbLog.Text = "Log";
            // 
            // lbLog
            // 
            lbLog.FormattingEnabled = true;
            lbLog.ItemHeight = 15;
            lbLog.Location = new Point(10, 19);
            lbLog.Name = "lbLog";
            lbLog.Size = new Size(230, 49);
            lbLog.TabIndex = 0;
            // 
            // grdDatos
            // 
            grdDatos.AllowUserToAddRows = false;
            grdDatos.AllowUserToDeleteRows = false;
            grdDatos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdDatos.Location = new Point(12, 12);
            grdDatos.Name = "grdDatos";
            grdDatos.ReadOnly = true;
            grdDatos.RowTemplate.DefaultCellStyle.Font = new Font("Arial Narrow", 8.25F, FontStyle.Regular, GraphicsUnit.Point);
            grdDatos.RowTemplate.Height = 20;
            grdDatos.Size = new Size(618, 209);
            grdDatos.TabIndex = 2;
            // 
            // frmMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(638, 310);
            Controls.Add(grdDatos);
            Controls.Add(grbLog);
            Controls.Add(grbLogin);
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
    }
}