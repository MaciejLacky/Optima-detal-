
namespace Optima_detal__
{
    partial class FormOptimaSettings
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbOptCompany = new System.Windows.Forms.TextBox();
            this.tbOptPass = new System.Windows.Forms.TextBox();
            this.tbOptUser = new System.Windows.Forms.TextBox();
            this.tbOptPath = new System.Windows.Forms.TextBox();
            this.btnPickOptPath = new System.Windows.Forms.Button();
            this.btnOptConnectionTest = new System.Windows.Forms.Button();
            this.cbOptHAP = new System.Windows.Forms.CheckBox();
            this.cbOptKBP = new System.Windows.Forms.CheckBox();
            this.cbOptModulyUsera = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOptConfigSave = new System.Windows.Forms.Button();
            this.btnOptConfigCancel = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbLogPath = new System.Windows.Forms.TextBox();
            this.btnPickLogPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.btnSqlPrepareMethods = new System.Windows.Forms.Button();
            this.btnSqlPrepareTables = new System.Windows.Forms.Button();
            this.fbdOptPath = new System.Windows.Forms.FolderBrowserDialog();
            this.fbdLogPath = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbOptCompany);
            this.groupBox1.Controls.Add(this.tbOptPass);
            this.groupBox1.Controls.Add(this.tbOptUser);
            this.groupBox1.Controls.Add(this.tbOptPath);
            this.groupBox1.Controls.Add(this.btnPickOptPath);
            this.groupBox1.Controls.Add(this.btnOptConnectionTest);
            this.groupBox1.Controls.Add(this.cbOptHAP);
            this.groupBox1.Controls.Add(this.cbOptKBP);
            this.groupBox1.Controls.Add(this.cbOptModulyUsera);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(14, 11);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(409, 288);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Optima";
            // 
            // tbOptCompany
            // 
            this.tbOptCompany.Location = new System.Drawing.Point(141, 125);
            this.tbOptCompany.Name = "tbOptCompany";
            this.tbOptCompany.Size = new System.Drawing.Size(188, 27);
            this.tbOptCompany.TabIndex = 12;
            // 
            // tbOptPass
            // 
            this.tbOptPass.Location = new System.Drawing.Point(141, 92);
            this.tbOptPass.Name = "tbOptPass";
            this.tbOptPass.Size = new System.Drawing.Size(188, 27);
            this.tbOptPass.TabIndex = 11;
            // 
            // tbOptUser
            // 
            this.tbOptUser.Location = new System.Drawing.Point(141, 59);
            this.tbOptUser.Name = "tbOptUser";
            this.tbOptUser.Size = new System.Drawing.Size(188, 27);
            this.tbOptUser.TabIndex = 10;
            // 
            // tbOptPath
            // 
            this.tbOptPath.Location = new System.Drawing.Point(141, 28);
            this.tbOptPath.Name = "tbOptPath";
            this.tbOptPath.Size = new System.Drawing.Size(188, 27);
            this.tbOptPath.TabIndex = 9;
            // 
            // btnPickOptPath
            // 
            this.btnPickOptPath.Location = new System.Drawing.Point(335, 26);
            this.btnPickOptPath.Name = "btnPickOptPath";
            this.btnPickOptPath.Size = new System.Drawing.Size(68, 29);
            this.btnPickOptPath.TabIndex = 8;
            this.btnPickOptPath.Text = "dodaj";
            this.btnPickOptPath.UseVisualStyleBackColor = true;
            this.btnPickOptPath.Click += new System.EventHandler(this.btnPickOptPath_Click);
            // 
            // btnOptConnectionTest
            // 
            this.btnOptConnectionTest.Location = new System.Drawing.Point(140, 218);
            this.btnOptConnectionTest.Name = "btnOptConnectionTest";
            this.btnOptConnectionTest.Size = new System.Drawing.Size(188, 54);
            this.btnOptConnectionTest.TabIndex = 7;
            this.btnOptConnectionTest.Text = "Pobierz dane Optima";
            this.btnOptConnectionTest.UseVisualStyleBackColor = true;
            this.btnOptConnectionTest.Click += new System.EventHandler(this.btnOptConnectionTest_Click);
            // 
            // cbOptHAP
            // 
            this.cbOptHAP.AutoSize = true;
            this.cbOptHAP.Location = new System.Drawing.Point(140, 188);
            this.cbOptHAP.Name = "cbOptHAP";
            this.cbOptHAP.Size = new System.Drawing.Size(109, 24);
            this.cbOptHAP.TabIndex = 6;
            this.cbOptHAP.Text = "Handel Plus";
            this.cbOptHAP.UseVisualStyleBackColor = true;
            // 
            // cbOptKBP
            // 
            this.cbOptKBP.AutoSize = true;
            this.cbOptKBP.Location = new System.Drawing.Point(6, 188);
            this.cbOptKBP.Name = "cbOptKBP";
            this.cbOptKBP.Size = new System.Drawing.Size(128, 24);
            this.cbOptKBP.TabIndex = 5;
            this.cbOptKBP.Text = "Kasa Bank Plus";
            this.cbOptKBP.UseVisualStyleBackColor = true;
            // 
            // cbOptModulyUsera
            // 
            this.cbOptModulyUsera.AutoSize = true;
            this.cbOptModulyUsera.Location = new System.Drawing.Point(6, 158);
            this.cbOptModulyUsera.Name = "cbOptModulyUsera";
            this.cbOptModulyUsera.Size = new System.Drawing.Size(219, 24);
            this.cbOptModulyUsera.TabIndex = 4;
            this.cbOptModulyUsera.Text = "Pobierz moduły użytkownika";
            this.cbOptModulyUsera.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Firma:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasło:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Operator:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Katalog Optimy:";
            // 
            // btnOptConfigSave
            // 
            this.btnOptConfigSave.Location = new System.Drawing.Point(694, 375);
            this.btnOptConfigSave.Name = "btnOptConfigSave";
            this.btnOptConfigSave.Size = new System.Drawing.Size(94, 33);
            this.btnOptConfigSave.TabIndex = 1;
            this.btnOptConfigSave.Text = "Zapisz";
            this.btnOptConfigSave.UseVisualStyleBackColor = true;
            this.btnOptConfigSave.Click += new System.EventHandler(this.btnOptConfigSave_Click);
            // 
            // btnOptConfigCancel
            // 
            this.btnOptConfigCancel.Location = new System.Drawing.Point(594, 375);
            this.btnOptConfigCancel.Name = "btnOptConfigCancel";
            this.btnOptConfigCancel.Size = new System.Drawing.Size(94, 33);
            this.btnOptConfigCancel.TabIndex = 2;
            this.btnOptConfigCancel.Text = "Anuluj";
            this.btnOptConfigCancel.UseVisualStyleBackColor = true;
            this.btnOptConfigCancel.Click += new System.EventHandler(this.btnOptConfigCancel_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbLogPath);
            this.groupBox2.Controls.Add(this.btnPickLogPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(433, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 74);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ścieżka logi";
            // 
            // tbLogPath
            // 
            this.tbLogPath.Location = new System.Drawing.Point(143, 25);
            this.tbLogPath.Name = "tbLogPath";
            this.tbLogPath.Size = new System.Drawing.Size(188, 27);
            this.tbLogPath.TabIndex = 12;
            // 
            // btnPickLogPath
            // 
            this.btnPickLogPath.Location = new System.Drawing.Point(337, 23);
            this.btnPickLogPath.Name = "btnPickLogPath";
            this.btnPickLogPath.Size = new System.Drawing.Size(68, 29);
            this.btnPickLogPath.TabIndex = 11;
            this.btnPickLogPath.Text = "dodaj";
            this.btnPickLogPath.UseVisualStyleBackColor = true;
            this.btnPickLogPath.Click += new System.EventHandler(this.btnPickLogPath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ścieżka logi:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbLog);
            this.groupBox3.Controls.Add(this.btnSqlPrepareMethods);
            this.groupBox3.Controls.Add(this.btnSqlPrepareTables);
            this.groupBox3.Location = new System.Drawing.Point(433, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(412, 206);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Dostosowanie bazy danych";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(8, 163);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(394, 27);
            this.tbLog.TabIndex = 2;
            // 
            // btnSqlPrepareMethods
            // 
            this.btnSqlPrepareMethods.Location = new System.Drawing.Point(212, 23);
            this.btnSqlPrepareMethods.Name = "btnSqlPrepareMethods";
            this.btnSqlPrepareMethods.Size = new System.Drawing.Size(193, 31);
            this.btnSqlPrepareMethods.TabIndex = 1;
            this.btnSqlPrepareMethods.Text = "Dostosuj metody";
            this.btnSqlPrepareMethods.UseVisualStyleBackColor = true;
            this.btnSqlPrepareMethods.Click += new System.EventHandler(this.btnSqlPrepareMethods_Click);
            // 
            // btnSqlPrepareTables
            // 
            this.btnSqlPrepareTables.Location = new System.Drawing.Point(8, 23);
            this.btnSqlPrepareTables.Name = "btnSqlPrepareTables";
            this.btnSqlPrepareTables.Size = new System.Drawing.Size(193, 31);
            this.btnSqlPrepareTables.TabIndex = 0;
            this.btnSqlPrepareTables.Text = "Dostosuj tabele";
            this.btnSqlPrepareTables.UseVisualStyleBackColor = true;
            this.btnSqlPrepareTables.Click += new System.EventHandler(this.btnSqlPrepareTables_Click);
            // 
            // FormOptimaSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(856, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnOptConfigCancel);
            this.Controls.Add(this.btnOptConfigSave);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormOptimaSettings";
            this.Text = "Ustawienia Optima";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbOptCompany;
        private System.Windows.Forms.TextBox tbOptPass;
        private System.Windows.Forms.TextBox tbOptUser;
        private System.Windows.Forms.TextBox tbOptPath;
        private System.Windows.Forms.Button btnPickOptPath;
        private System.Windows.Forms.Button btnOptConnectionTest;
        private System.Windows.Forms.CheckBox cbOptHAP;
        private System.Windows.Forms.CheckBox cbOptKBP;
        private System.Windows.Forms.CheckBox cbOptModulyUsera;
        private System.Windows.Forms.Button btnOptConfigSave;
        private System.Windows.Forms.Button btnOptConfigCancel;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbLogPath;
        private System.Windows.Forms.Button btnPickLogPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.Button btnSqlPrepareMethods;
        private System.Windows.Forms.Button btnSqlPrepareTables;
        private System.Windows.Forms.FolderBrowserDialog fbdOptPath;
        private System.Windows.Forms.FolderBrowserDialog fbdLogPath;
    }
}