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
    }
}
