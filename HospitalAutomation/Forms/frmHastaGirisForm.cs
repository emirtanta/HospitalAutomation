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
    public partial class frmHastaGirisForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmHastaGirisForm()
        {
            InitializeComponent();
        }

        private void btnHastaGiris_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@hastaTC AND HastaSifre=@hastaSifre", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaTC", txtHastaTC.Text);
            command.Parameters.AddWithValue("@hastaSifre", txtHastaSifre.Text);

            SqlDataReader dr = command.ExecuteReader();

            if (dr.Read())
            {
                frmHastaDetayForm frm = new frmHastaDetayForm();
                frm.Show();

                this.Hide();
            }

            else
            {
                XtraMessageBox.Show("Hata Tc veya Şifre girişi yaptınız!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmHastaGirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("Kapatmak istediğine emin misiniz?","AVG Hastasi",MessageBoxButtons.YesNo)==DialogResult.No)
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