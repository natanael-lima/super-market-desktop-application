using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Principal
{
    public partial class FrmHistorySale : Form
    {
        private SaleService saleService = new SaleService();
        public FrmHistorySale()
        {
            InitializeComponent();
        }
        private void LoadHistory()
        {
            dgvHistory.DataSource = saleService.GetAllSales();

        }

        private void FrmHistorySale_Load(object sender, EventArgs e)
        {
            LoadHistory();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
