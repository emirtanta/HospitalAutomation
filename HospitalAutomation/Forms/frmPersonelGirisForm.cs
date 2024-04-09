using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Forms
{
    public partial class frmPersonelGirisForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmPersonelGirisForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// personellerin sisteme giriş yapmasını sağlar
        /// </summary>
        private void PersonelGiris()
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Sekreterler Where SekreterTc=@sekreterTC AND SekreterSifre=@sekreterSifre", connection.Baglanti());
            command.Parameters.AddWithValue("@sekreterTC",txtPersonelTC.Text);
            command.Parameters.AddWithValue("@sekreterSifre",txtPersonelSifre.Text);

            SqlDataReader dr=command.ExecuteReader();

            if (dr.Read())
            {
                frmPersonelDetayForm frm = new frmPersonelDetayForm();
                frm.TcNumara=txtPersonelTC.Text;

                frm.Show();

                this.Hide();
            }

            else
            {
                XtraMessageBox.Show("Hatalı tc ve şifre", "Bilgi",
         MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnPersonelGiris_Click(object sender, EventArgs e)
        {
            PersonelGiris();
        }

        private void frmPersonelGirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("Kapatmak İstediginizden Emin Misiniz ?", "ABC Hastanesi",
         MessageBoxButtons.YesNo) == DialogResult.No)
                {
                    e.Cancel = true;
                    return;
                }
                Application.Exit();
            }
            else
            {
                Application.Exit();
            }
        }
    }
}