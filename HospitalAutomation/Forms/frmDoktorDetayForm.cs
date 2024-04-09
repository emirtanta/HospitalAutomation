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
    public partial class frmDoktorDetayForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public string tc; //frmDoktorGiris formuna veri aktarmak için tanımlandı

        public frmDoktorDetayForm()
        {
            InitializeComponent();
        }

        private void frmDoktorDetayForm_Load(object sender, EventArgs e)
        {
            //doktor tc'sini getirme
            lblTC.Text = tc;

            //doktor bilgilerini getirme
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorTc=@doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorTC", tc);

            SqlDataReader dr=command.ExecuteReader();

            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1]; //ad soyadı getirir
            }

            connection.Baglanti().Close();

            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * from Tbl_Randevular where RandevuDoktor='" + lblAdSoyad.Text + "'", connection.Baglanti());
            //command.Parameters.AddWithValue("@adSoyad", lblAdSoyad.Text);

            da.Fill(dt);

            gridControl1.DataSource = dt;
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurularForm frm = new frmDuyurularForm();
            frm.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gridView1_DoubleClick(object sender, EventArgs e)
        {
            //int secilen = gridView1.GetDataSourceRowIndex(gridView1.FocusedRowHandle);
            //memoSikayet.Text= gridView1.GetRowCellValue(secilen, "HastaSikayet").ToString(); //Randevular tablosundaki HastaSikayet kolonunu seçer

            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                memoSikayet.Text = dr["HastaSikayet"].ToString();

            }
        }

        private void lnkBilgiGoruntule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoktorGoruntuleForm frm = new frmDoktorGoruntuleForm();
            frm.Tc = lblTC.Text;

            frm.Show();
        }

        private void lnkBilgiGuncelle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmDoktorDuzenleForm frm = new frmDoktorDuzenleForm();
            frm.TCNO = lblTC.Text;
            frm.Show();
        }



        private void frmDoktorDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("Kapatmak istediğinize emin misiniz?","ABC Hastanesi",MessageBoxButtons.YesNo)==DialogResult.No)
                {
                    e.Cancel=true;

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