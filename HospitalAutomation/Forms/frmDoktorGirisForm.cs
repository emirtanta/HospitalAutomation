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
    public partial class frmDoktorGirisForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmDoktorGirisForm()
        {
            InitializeComponent();
        }

        private void btnDoktorGiris_Click(object sender, EventArgs e)
        {
            SqlCommand command=new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc=@doktorTC And DoktorSifre=@doktorSifre", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorTC", txtDoktorTC.Text);
            command.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text);

            SqlDataReader dr=command.ExecuteReader();

            if (dr.Read())
            {
                frmDoktorDetayForm frm = new frmDoktorDetayForm();
                frm.tc = txtDoktorTC.Text;
                frm.Show();

                frm.Hide();
            }

            else 
            {
                XtraMessageBox.Show("Hatalı tc veya şifre", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            connection.Baglanti().Close();
        }

        private void frmDoktorGirisForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("Kapatmak istediğine emin misiniz?", "AVG Hastasi", MessageBoxButtons.YesNo) == DialogResult.No)
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