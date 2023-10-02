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
            this.grbLogin = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtClaveVETA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtUsuarioVETA = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBearer = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.txtClaveIOL = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUsuarioIOL = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grbLog = new System.Windows.Forms.GroupBox();
            this.lbLog = new System.Windows.Forms.ListBox();
            this.grdDatos = new System.Windows.Forms.DataGridView();
            this.grbLogin.SuspendLayout();
            this.grbLog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).BeginInit();
            this.SuspendLayout();
            // 
            // grbLogin
            // 
            this.grbLogin.Controls.Add(this.textBox1);
            this.grbLogin.Controls.Add(this.label8);
            this.grbLogin.Controls.Add(this.txtClaveVETA);
            this.grbLogin.Controls.Add(this.label5);
            this.grbLogin.Controls.Add(this.txtUsuarioVETA);
            this.grbLogin.Controls.Add(this.label6);
            this.grbLogin.Controls.Add(this.label7);
            this.grbLogin.Controls.Add(this.txtBearer);
            this.grbLogin.Controls.Add(this.label4);
            this.grbLogin.Controls.Add(this.btnLogin);
            this.grbLogin.Controls.Add(this.txtClaveIOL);
            this.grbLogin.Controls.Add(this.label3);
            this.grbLogin.Controls.Add(this.txtUsuarioIOL);
            this.grbLogin.Controls.Add(this.label2);
            this.grbLogin.Controls.Add(this.label1);
            this.grbLogin.Location = new System.Drawing.Point(12, 227);
            this.grbLogin.Name = "grbLogin";
            this.grbLogin.Size = new System.Drawing.Size(488, 77);
            this.grbLogin.TabIndex = 0;
            this.grbLogin.TabStop = false;
            this.grbLogin.Text = "Logins";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(429, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(48, 23);
            this.textBox1.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(360, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Vence en";
            // 
            // txtClaveVETA
            // 
            this.txtClaveVETA.Location = new System.Drawing.Point(217, 47);
            this.txtClaveVETA.Name = "txtClaveVETA";
            this.txtClaveVETA.Size = new System.Drawing.Size(76, 23);
            this.txtClaveVETA.TabIndex = 12;
            this.txtClaveVETA.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(175, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Clave";
            // 
            // txtUsuarioVETA
            // 
            this.txtUsuarioVETA.Location = new System.Drawing.Point(97, 47);
            this.txtUsuarioVETA.Name = "txtUsuarioVETA";
            this.txtUsuarioVETA.Size = new System.Drawing.Size(68, 23);
            this.txtUsuarioVETA.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(42, 50);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Usuario";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(33, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "VETA";
            // 
            // txtBearer
            // 
            this.txtBearer.Location = new System.Drawing.Point(429, 18);
            this.txtBearer.Name = "txtBearer";
            this.txtBearer.ReadOnly = true;
            this.txtBearer.Size = new System.Drawing.Size(48, 23);
            this.txtBearer.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "Bearer";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(305, 18);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(51, 52);
            this.btnLogin.TabIndex = 5;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // txtClaveIOL
            // 
            this.txtClaveIOL.Location = new System.Drawing.Point(217, 18);
            this.txtClaveIOL.Name = "txtClaveIOL";
            this.txtClaveIOL.Size = new System.Drawing.Size(76, 23);
            this.txtClaveIOL.TabIndex = 4;
            this.txtClaveIOL.UseSystemPasswordChar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Clave";
            // 
            // txtUsuarioIOL
            // 
            this.txtUsuarioIOL.Location = new System.Drawing.Point(97, 18);
            this.txtUsuarioIOL.Name = "txtUsuarioIOL";
            this.txtUsuarioIOL.Size = new System.Drawing.Size(68, 23);
            this.txtUsuarioIOL.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "IOL";
            // 
            // grbLog
            // 
            this.grbLog.Controls.Add(this.lbLog);
            this.grbLog.Location = new System.Drawing.Point(506, 227);
            this.grbLog.Name = "grbLog";
            this.grbLog.Size = new System.Drawing.Size(246, 77);
            this.grbLog.TabIndex = 1;
            this.grbLog.TabStop = false;
            this.grbLog.Text = "Log";
            // 
            // lbLog
            // 
            this.lbLog.FormattingEnabled = true;
            this.lbLog.ItemHeight = 15;
            this.lbLog.Location = new System.Drawing.Point(10, 19);
            this.lbLog.Name = "lbLog";
            this.lbLog.Size = new System.Drawing.Size(230, 49);
            this.lbLog.TabIndex = 0;
            // 
            // grdDatos
            // 
            this.grdDatos.AllowUserToAddRows = false;
            this.grdDatos.AllowUserToDeleteRows = false;
            this.grdDatos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatos.Location = new System.Drawing.Point(12, 12);
            this.grdDatos.Name = "grdDatos";
            this.grdDatos.ReadOnly = true;
            this.grdDatos.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.grdDatos.RowTemplate.Height = 20;
            this.grdDatos.Size = new System.Drawing.Size(740, 209);
            this.grdDatos.TabIndex = 2;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 310);
            this.Controls.Add(this.grdDatos);
            this.Controls.Add(this.grbLog);
            this.Controls.Add(this.grbLogin);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.grbLogin.ResumeLayout(false);
            this.grbLogin.PerformLayout();
            this.grbLog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdDatos)).EndInit();
            this.ResumeLayout(false);

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
        private TextBox txtBearer;
        private Label label4;
        private Button btnLogin;
        private TextBox txtClaveIOL;
        private Label label3;
        private TextBox textBox1;
        private Label label8;
        private GroupBox grbLog;
        private ListBox lbLog;
        private DataGridView grdDatos;
    }
}