using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Forms
{
    public partial class frmLoginForm : DevExpress.XtraEditors.XtraForm
    {
        public frmLoginForm()
        {
            InitializeComponent();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            frmDoktorGirisForm frm = new frmDoktorGirisForm();
            frm.Show();

            this.Hide();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            frmHastaGirisForm frm = new frmHastaGirisForm();
            frm.Show();

            this.Hide();
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            frmPersonelGirisForm frm = new frmPersonelGirisForm();
            frm.Show();

            this.Hide();
        }
    }
}