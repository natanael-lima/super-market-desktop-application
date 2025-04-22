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
    public partial class Loading : Form
    {
        public Loading()
        {
            InitializeComponent();
        }
        int startpoint = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpoint += 1;
            ProgressBar1.Value = startpoint;
            if (ProgressBar1.Value == 100)
            {
                ProgressBar1.Value = 0;
                timer1.Stop();
                FrmLogin log = new FrmLogin();
                this.Hide();
                log.Show();
            }

        }

        private void Loading_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
