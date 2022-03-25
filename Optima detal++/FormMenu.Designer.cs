
namespace Optima_detal__
{
    partial class FormMenu
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiOptimaSettings = new System.Windows.Forms.ToolStripMenuItem();
            this.promocjeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSaleFromDateToDate = new System.Windows.Forms.ToolStripMenuItem();
            this.zamówieniaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.analizyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbLog = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSpecialOfferDelete = new System.Windows.Forms.Button();
            this.btnAddSpecialOffer = new System.Windows.Forms.Button();
            this.cbSpecialOfferPriceType = new System.Windows.Forms.ComboBox();
            this.tbSpecialOfferName = new System.Windows.Forms.TextBox();
            this.dtpSpecialOfferFrom = new System.Windows.Forms.DateTimePicker();
            this.dtpSpecialOfferTo = new System.Windows.Forms.DateTimePicker();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbFilePath = new System.Windows.Forms.TextBox();
            this.btnPickLogPath = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvSpecialPrice = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.ofdFileSpecialOffers = new System.Windows.Forms.OpenFileDialog();
            this.bsSpecialPrice = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.promocjeToolStripMenuItem,
            this.zamówieniaToolStripMenuItem,
            this.analizyToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1070, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiOptimaSettings});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem1.Text = "Optima";
            // 
            // tsmiOptimaSettings
            // 
            this.tsmiOptimaSettings.Name = "tsmiOptimaSettings";
            this.tsmiOptimaSettings.Size = new System.Drawing.Size(218, 26);
            this.tsmiOptimaSettings.Text = "Ustawienia Optima";
            this.tsmiOptimaSettings.Click += new System.EventHandler(this.tsmiOptimaSettings_Click);
            // 
            // promocjeToolStripMenuItem
            // 
            this.promocjeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSaleFromDateToDate});
            this.promocjeToolStripMenuItem.Name = "promocjeToolStripMenuItem";
            this.promocjeToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.promocjeToolStripMenuItem.Text = "Promocje";
            // 
            // tsmiSaleFromDateToDate
            // 
            this.tsmiSaleFromDateToDate.Name = "tsmiSaleFromDateToDate";
            this.tsmiSaleFromDateToDate.Size = new System.Drawing.Size(215, 26);
            this.tsmiSaleFromDateToDate.Text = "Promocja czasowa";
            this.tsmiSaleFromDateToDate.Click += new System.EventHandler(this.tsmiSaleFromDateToDate_Click);
            // 
            // zamówieniaToolStripMenuItem
            // 
            this.zamówieniaToolStripMenuItem.Name = "zamówieniaToolStripMenuItem";
            this.zamówieniaToolStripMenuItem.Size = new System.Drawing.Size(105, 24);
            this.zamówieniaToolStripMenuItem.Text = "Zamówienia";
            // 
            // analizyToolStripMenuItem
            // 
            this.analizyToolStripMenuItem.Name = "analizyToolStripMenuItem";
            this.analizyToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.analizyToolStripMenuItem.Text = "Analizy";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(11, 35);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.RightToLeftLayout = true;
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1059, 664);
            this.tabControl1.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1051, 631);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ustal promocje";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbLog);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnSpecialOfferDelete);
            this.groupBox1.Controls.Add(this.btnAddSpecialOffer);
            this.groupBox1.Controls.Add(this.cbSpecialOfferPriceType);
            this.groupBox1.Controls.Add(this.tbSpecialOfferName);
            this.groupBox1.Controls.Add(this.dtpSpecialOfferFrom);
            this.groupBox1.Controls.Add(this.dtpSpecialOfferTo);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.dgvSpecialPrice);
            this.groupBox1.Location = new System.Drawing.Point(6, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1039, 334);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Promocja czasowa";
            // 
            // tbLog
            // 
            this.tbLog.Location = new System.Drawing.Point(621, 26);
            this.tbLog.Name = "tbLog";
            this.tbLog.Size = new System.Drawing.Size(411, 27);
            this.tbLog.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(629, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 20);
            this.label4.TabIndex = 14;
            this.label4.Text = "Typ ceny Optima";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(629, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Data do:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 20);
            this.label2.TabIndex = 12;
            this.label2.Text = "Data od:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 11;
            this.label1.Text = "Nazwa promocji";
            // 
            // btnSpecialOfferDelete
            // 
            this.btnSpecialOfferDelete.Location = new System.Drawing.Point(822, 284);
            this.btnSpecialOfferDelete.Name = "btnSpecialOfferDelete";
            this.btnSpecialOfferDelete.Size = new System.Drawing.Size(98, 34);
            this.btnSpecialOfferDelete.TabIndex = 10;
            this.btnSpecialOfferDelete.Text = "zakończ";
            this.btnSpecialOfferDelete.UseVisualStyleBackColor = true;
            this.btnSpecialOfferDelete.Click += new System.EventHandler(this.btnSpecialOfferDelete_Click);
            // 
            // btnAddSpecialOffer
            // 
            this.btnAddSpecialOffer.Location = new System.Drawing.Point(926, 284);
            this.btnAddSpecialOffer.Name = "btnAddSpecialOffer";
            this.btnAddSpecialOffer.Size = new System.Drawing.Size(98, 34);
            this.btnAddSpecialOffer.TabIndex = 9;
            this.btnAddSpecialOffer.Text = "dodaj";
            this.btnAddSpecialOffer.UseVisualStyleBackColor = true;
            this.btnAddSpecialOffer.Click += new System.EventHandler(this.btnAddSpecialOffer_Click);
            // 
            // cbSpecialOfferPriceType
            // 
            this.cbSpecialOfferPriceType.FormattingEnabled = true;
            this.cbSpecialOfferPriceType.Location = new System.Drawing.Point(822, 250);
            this.cbSpecialOfferPriceType.Name = "cbSpecialOfferPriceType";
            this.cbSpecialOfferPriceType.Size = new System.Drawing.Size(202, 28);
            this.cbSpecialOfferPriceType.TabIndex = 8;
            // 
            // tbSpecialOfferName
            // 
            this.tbSpecialOfferName.Location = new System.Drawing.Point(822, 146);
            this.tbSpecialOfferName.Name = "tbSpecialOfferName";
            this.tbSpecialOfferName.Size = new System.Drawing.Size(202, 27);
            this.tbSpecialOfferName.TabIndex = 7;
            // 
            // dtpSpecialOfferFrom
            // 
            this.dtpSpecialOfferFrom.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSpecialOfferFrom.Location = new System.Drawing.Point(822, 179);
            this.dtpSpecialOfferFrom.Name = "dtpSpecialOfferFrom";
            this.dtpSpecialOfferFrom.Size = new System.Drawing.Size(202, 27);
            this.dtpSpecialOfferFrom.TabIndex = 6;
            // 
            // dtpSpecialOfferTo
            // 
            this.dtpSpecialOfferTo.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSpecialOfferTo.Location = new System.Drawing.Point(822, 212);
            this.dtpSpecialOfferTo.Name = "dtpSpecialOfferTo";
            this.dtpSpecialOfferTo.Size = new System.Drawing.Size(202, 27);
            this.dtpSpecialOfferTo.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbFilePath);
            this.groupBox2.Controls.Add(this.btnPickLogPath);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(621, 66);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(412, 74);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Wgraj plik z promocją";
            // 
            // tbFilePath
            // 
            this.tbFilePath.Location = new System.Drawing.Point(105, 25);
            this.tbFilePath.Name = "tbFilePath";
            this.tbFilePath.Size = new System.Drawing.Size(226, 27);
            this.tbFilePath.TabIndex = 12;
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
            this.label5.Size = new System.Drawing.Size(97, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Ścieżka pliku:";
            // 
            // dgvSpecialPrice
            // 
            this.dgvSpecialPrice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSpecialPrice.Location = new System.Drawing.Point(23, 26);
            this.dgvSpecialPrice.Name = "dgvSpecialPrice";
            this.dgvSpecialPrice.RowHeadersWidth = 51;
            this.dgvSpecialPrice.RowTemplate.Height = 29;
            this.dgvSpecialPrice.Size = new System.Drawing.Size(592, 295);
            this.dgvSpecialPrice.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1051, 631);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Zrób zamówienie";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1051, 631);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Pokaż analize";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // ofdFileSpecialOffers
            // 
            this.ofdFileSpecialOffers.FileName = "openFileDialog1";
            // 
            // FormMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1070, 700);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormMenu";
            this.Text = "Optima Detal++";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSpecialPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsSpecialPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem tsmiOptimaSettings;
        private System.Windows.Forms.ToolStripMenuItem promocjeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiSaleFromDateToDate;
        private System.Windows.Forms.ToolStripMenuItem zamówieniaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem analizyToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvSpecialPrice;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSpecialOfferDelete;
        private System.Windows.Forms.Button btnAddSpecialOffer;
        private System.Windows.Forms.ComboBox cbSpecialOfferPriceType;
        private System.Windows.Forms.TextBox tbSpecialOfferName;
        private System.Windows.Forms.DateTimePicker dtpSpecialOfferFrom;
        private System.Windows.Forms.DateTimePicker dtpSpecialOfferTo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox tbFilePath;
        private System.Windows.Forms.Button btnPickLogPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.OpenFileDialog ofdFileSpecialOffers;
        private System.Windows.Forms.TextBox tbLog;
        private System.Windows.Forms.BindingSource bsSpecialPrice;
    }
}

