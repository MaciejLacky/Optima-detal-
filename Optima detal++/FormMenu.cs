using Optima_detal__.Db;
using Optima_detal__.Files;
using Optima_detal__.Optima;
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
    public partial class FormMenu : Form
    {
        public FormMenu()
        {
            InitializeComponent();
            LoadConfig();
        }

        private void LoadConfig()
        {
            LoadMapping(dgvSpecialPrice, MappingType.SpecialPrice, bsSpecialPrice);
            Methods.FillComboBox(cbSpecialOfferPriceType, Config.GetPricesFromOPT());
            tbFilePath.Text = Settings.Default.FilePath;
            if (cbSpecialOfferPriceType.SelectedValue != null)
                cbSpecialOfferPriceType.SelectedValue = Settings.Default.SpecialOfferPriceType;
        }

        private void tsmiOptimaSettings_Click(object sender, EventArgs e)
        {
            FormOptimaSettings formOptimaSettings = new FormOptimaSettings();
            formOptimaSettings.ShowDialog();
        }

        private void tsmiSaleFromDateToDate_Click(object sender, EventArgs e)
        {
            SaleSettings saleSettings = new SaleSettings();
            saleSettings.ShowDialog();
        }

        private void btnPickLogPath_Click(object sender, EventArgs e)
        {
            if (ofdFileSpecialOffers.ShowDialog() == DialogResult.OK) tbFilePath.Text = ofdFileSpecialOffers.FileName;
        }

        private void btnAddSpecialOffer_Click(object sender, EventArgs e)
        {

            Settings.Default.FilePath = tbFilePath.Text;
            if (cbSpecialOfferPriceType.SelectedValue != null)
                Settings.Default.SpecialOfferPriceType = Convert.ToInt32(cbSpecialOfferPriceType.SelectedValue);
            Settings.Default.Save();

            string specialOfferName = tbSpecialOfferName.Text;
            DateTime dateFrom = dtpSpecialOfferFrom.Value;
            DateTime dateTo = dtpSpecialOfferTo.Value;
            int priceType = Convert.ToInt32(cbSpecialOfferPriceType.SelectedValue);
            var specialOfferData = FileToRead.SpecialOfferFile(tbFilePath.Text, tbLog);
            if (specialOfferData.Count() == 0)
            {
                tbLog.Text = "Brak danych do wczytania, Sprawdź konfiguracje";
                return;
            }
            OptSpecialPrices.CreateSpecialPricesFromTo(specialOfferData, specialOfferName, dateFrom, dateTo, priceType, tbLog);

            Config.AddMaping(0, specialOfferName, 0, dateFrom.ToString(), 0, dateTo.ToString(), MappingType.SpecialPrice);
            LoadConfig();

        }

        private void btnSpecialOfferDelete_Click(object sender, EventArgs e)
        {
            if (dgvSpecialPrice.Rows.Count == 0) return;
            if (MessageBox.Show("Czy na pewno chcesz usunac zaznaczoną promocje?", "Usuwanie", MessageBoxButtons.YesNo) == DialogResult.No) return;
            try
            {               
                int mapId = Convert.ToInt32(dgvSpecialPrice.Rows[dgvSpecialPrice.CurrentRow.Index].Cells[0].Value);
                string specialPricesName = dgvSpecialPrice.Rows[dgvSpecialPrice.CurrentRow.Index].Cells[2].Value.ToString();
                var succes = OptSpecialPrices.DeleteSpecialPricesFromTo(specialPricesName, tbLog);
                Config.DeleteMaping(mapId);
                LoadMapping(dgvSpecialPrice, MappingType.SpecialPrice, bsSpecialPrice);
            }
            catch (Exception)
            {
                MessageBox.Show("Nie zaznaczono elementu do usunięcia", "Usuwanie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
        }
        private void LoadMapping(DataGridView dgv, MappingType mappingType, BindingSource bs)
        {
            try
            {
                dgv.DataSource = null;
                dgv.DataSource = bs;
                bs.DataSource = null;
                bs.DataSource = Config.GetMapping(mappingType);
                if (dgv.Rows.Count == 0)
                {
                    dgv.ColumnHeadersVisible = false;
                    return;
                }
                else
                    dgv.ColumnHeadersVisible = true;
                dgv.Columns[0].Visible = false;
                dgv.Columns[1].Visible = false;              
                dgv.Columns[3].Visible = false;
                dgv.Columns[5].Visible = false;                         
                dgv.Columns[2].HeaderText = "Nazwa promocji";
                dgv.Columns[4].HeaderText = "Okres od";
                dgv.Columns[6].HeaderText = "Okres do";

            }
            catch (Exception ex) { MessageBox.Show("Dostosuj tabele i metody do najnowszej wersji programu w panelu konfiguracji.\r\n" + ex.Message); }
        }
    }
}
