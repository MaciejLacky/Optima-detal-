using Optima_detal__.Optima;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optima_detal__
{
    public partial class FormOptimaSettings : Form
    {
        public FormOptimaSettings()
        {
            InitializeComponent();
            LoadConfig();
        }



        private void btnPickOptPath_Click(object sender, EventArgs e)
        {
            if (fbdOptPath.ShowDialog() == DialogResult.Cancel) return;
            var katalogOpt = fbdOptPath.SelectedPath;

            if (File.Exists(katalogOpt + "\\optima.exe") || File.Exists(katalogOpt + "\\Comarch OPT!MA.exe"))
            {
                tbOptPath.Text = katalogOpt;              
                return;
            }

            MessageBox.Show("Katalog nie zawiera pliku optima.exe", "informacja", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnOptConnectionTest_Click(object sender, EventArgs e)
        {
            string log = "";
            SaveConfig();           
            Opt.LogInTest(ref log);
            MessageBox.Show(log);
        }

        private void btnOptConfigSave_Click(object sender, EventArgs e)
        {
            SaveConfig();
            LoadConfig();
            Close();
        }

        private void SaveConfig()
        {           
            Settings.Default.OptPath = tbOptPath.Text;
            Settings.Default.OptCompany = tbOptCompany.Text;
            Settings.Default.OptUser = tbOptUser.Text;
            Settings.Default.OptPassword = tbOptPass.Text;
            Settings.Default.OptKBP = cbOptKBP.Checked;
            Settings.Default.OptHAP = cbOptHAP.Checked;
            Settings.Default.OptModulyUsera = cbOptModulyUsera.Checked;
            Settings.Default.LogPath = tbLogPath.Text;

            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void LoadConfig()
        {          
            tbOptPath.Text = Settings.Default.OptPath;
            tbOptCompany.Text = Settings.Default.OptCompany;
            tbOptUser.Text = Settings.Default.OptUser;
            tbOptPass.Text = Settings.Default.OptPassword;
            cbOptKBP.Checked = Settings.Default.OptKBP;
            cbOptHAP.Checked = Settings.Default.OptHAP;
            cbOptModulyUsera.Checked = Settings.Default.OptModulyUsera;
            tbLogPath.Text = Settings.Default.LogPath;
        }

        private void btnOptConfigCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPickLogPath_Click(object sender, EventArgs e)
        {
            if (fbdLogPath.ShowDialog() == DialogResult.OK) tbLogPath.Text = fbdLogPath.SelectedPath;
        }

        private void btnSqlPrepareTables_Click(object sender, EventArgs e) => SqlPrepareTables();
       
        private void SqlPrepareTables()
        {
            try
            {
                string[] procedures = SqlSplitProcedures(0).Split(new string[] { "GO" }, StringSplitOptions.None);

                using (SqlConnection conn = new SqlConnection(Methods.GetSqlConnectionString()))
                {
                    conn.Open();
                    foreach (string procedure in procedures)
                    {
                        if (string.IsNullOrWhiteSpace(procedure)) continue;

                        try { new SqlCommand(procedure, conn).ExecuteNonQuery(); }
                        catch (Exception ex)
                        {
                            //if (procedure.Contains("IF EXISTS(SELECT * FROM [ELTES].[Mapping]) AND (SELECT COUNT([Map_OptId]) FROM [ELTES].[BlMapping])=0")) continue;
                            MessageBox.Show(ex.Message.ToString(), "Problem z tworzeniem tabel/pól sql ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log.Error("Problem z tworzeniem tabel/pól sql " + ex.Message);
                        }
                    }
                }
                MessageBox.Show("Tabele zostały dostosowane.", "Sukces!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Problem ogólny z tworzeniem tabel/pól sql ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Problem ogólny z tworzeniem tabel/pól sql " + ex.Message);
            }
        }
        private string SqlSplitProcedures(int num)
        {
            string procedures;
            string fileName = "\\Procedury.sql";          
            try { procedures = File.ReadAllText(Path.GetDirectoryName(Assembly.GetEntryAssembly().Location) + fileName); }
            catch (Exception)
            {
                Environment.CurrentDirectory = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                procedures = File.ReadAllText(Environment.CurrentDirectory.Replace(@"bin\Debug", "") + fileName);
            }

            string[] splittedProcedures = procedures.Split(new string[] { "--StringSplitter" }, StringSplitOptions.None);
            return splittedProcedures[num];
        }

        private void btnSqlPrepareMethods_Click(object sender, EventArgs e) => SqlPrepareMethods();
       

        private void SqlPrepareMethods()
        {
            try
            {
                string[] procedures = SqlSplitProcedures(1).Split(new string[] { "GO" }, StringSplitOptions.None);
                using (SqlConnection conn = new SqlConnection(Methods.GetSqlConnectionString()))
                {
                    conn.Open();
                    foreach (string procedure in procedures)
                    {
                        if (string.IsNullOrWhiteSpace(procedure)) continue;

                        try { new SqlCommand(procedure, conn).ExecuteNonQuery(); }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message.ToString(), "Problem z tworzeniem procedur sql ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            Log.Error("Problem z tworzeniem procedur sql " + ex.Message);
                        }
                    }
                }
                MessageBox.Show("Metody zostały dostosowane.", "Sukces!", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Problem ogólny  z tworzeniem procedur sql ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Log.Error("Problem ogólny z tworzeniem procedur sql " + ex.Message);
            }
        }
    }
}
