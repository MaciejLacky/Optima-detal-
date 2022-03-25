using Optima_detal__.Files;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Optima_detal__
{
    public partial class SaleSettings : Form
    {
        public SaleSettings()
        {
            InitializeComponent();
            LoadConfig();
        }
        private void SaveConfig()
        {
            Settings.Default.SaleSettingsFormatFile = cbSaleSettingsFormatFile.SelectedItem.ToString();
            Settings.Default.SaleSettingsSearchEan = rdSaleSettingsSearchEan.Checked;
            Settings.Default.SaleSettingsSearchSku = rdSaleSettingsSearchSku.Checked;
            Settings.Default.SaleSettingsColumnCodeNumber = Convert.ToInt32(nudSaleSettingsColumnCodeNumber.Value);
            Settings.Default.SaleSettingsColumnPriceNumber = Convert.ToInt32(nudSaleSettingsColumnPriceNumber.Value);
            Settings.Default.SaleSettingsColumnSeparatorNumber = tbSaleSettingsColumnSeparatorNumber.Text;
            Settings.Default.FilePathSaleSettings = tbFilePathSaleSettings.Text;
            Settings.Default.DeleteHeadingCharValue = Convert.ToInt32(nudDeleteHeadingCharValue.Value);
            Settings.Default.SaleSettingsColumnSepColumn1 = tbSaleSettingsColumnSepColumn1.Text;
            Settings.Default.SaleSettingsColumnSepColumn2 = tbSaleSettingsColumnSepColumn2.Text;

            Settings.Default.Save();
            Settings.Default.Reload();
        }

        private void LoadConfig()
        {
            cbSaleSettingsFormatFile.SelectedItem = Settings.Default.SaleSettingsFormatFile;
            rdSaleSettingsSearchEan.Checked = Settings.Default.SaleSettingsSearchEan;
            rdSaleSettingsSearchSku.Checked = Settings.Default.SaleSettingsSearchSku;
            nudSaleSettingsColumnCodeNumber.Value = Settings.Default.SaleSettingsColumnCodeNumber;
            nudSaleSettingsColumnPriceNumber.Value = Settings.Default.SaleSettingsColumnPriceNumber;
            tbSaleSettingsColumnSeparatorNumber.Text = Settings.Default.SaleSettingsColumnSeparatorNumber;
            tbFilePathSaleSettings.Text = Settings.Default.FilePathSaleSettings;
            nudDeleteHeadingCharValue.Value = Settings.Default.DeleteHeadingCharValue;
            tbSaleSettingsColumnSepColumn1.Text = Settings.Default.SaleSettingsColumnSepColumn1;
            tbSaleSettingsColumnSepColumn2.Text = Settings.Default.SaleSettingsColumnSepColumn2;          
        }
        private void btnPickLogPath_Click(object sender, EventArgs e)
        {
            if (ofdSaleSettingsFile.ShowDialog() == DialogResult.OK) tbFilePathSaleSettings.Text = ofdSaleSettingsFile.FileName;
        }

        private void btnAddSaleSettings_Click(object sender, EventArgs e)
        {
            ReadSaleFileToConfig();
        }

        private void ReadSaleFileToConfig()
        {
            var file = FileToRead.SpecialOfferFile(Settings.Default.FilePathSaleSettings, tbLogSaleSettings);
            dgvSaleSettings.DataSource = file;
        }

        private void btnCancelSaleSettings_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSaveSaleSettings_Click(object sender, EventArgs e)
        {
            SaveConfig();
            LoadConfig();
            Close();
        }

        private void btnCheckSettings_Click(object sender, EventArgs e)
        {
            FileToRead.ReadFileTest(Settings.Default.FilePathSaleSettings, tbLogSaleSettings);
        }
    }
}
