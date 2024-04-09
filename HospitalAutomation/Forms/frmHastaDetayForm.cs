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
    public partial class frmHastaDetayForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        //formlar arası veri getirmek için tanımlandı
        public string tc;

        public frmHastaDetayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// hastanın ad soyad bilgilerini label nesnelerinin içerisine getirir
        /// </summary>
        private void AdSoyadBilgisiGetir()
        {
            lblHastaTC.Text = tc;

            SqlCommand command = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar Where HastaTc=@hastaTC", connection.Baglanti());

            SqlDataReader sqlDataReader = command.ExecuteReader();

            while (sqlDataReader.Read())
            {
                lblHastaAdSoyad.Text = sqlDataReader[0] + " " + sqlDataReader[1];
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// randevu geçmişini gridControl içerisine getirir
        /// </summary>
        private void RandevuGecmisiGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select RandevuTarih AS 'Tarih',RandevuSaat AS 'Saat',RandevuBrans AS 'Branş',RandevuDoktor AS 'Doktor',RandevuDurum AS 'Durum',HastaTc AS 'Hasta TC',HastaSikayet AS 'Şikayet' From Tbl_Randevular Where HastaTc="+tc, connection.Baglanti());
            
            da.Fill(dt);

            gridControlRandevuGecmisi.DataSource = dt;
        }

        /// <summary>
        /// branşları comboboxEdit içerisine getirir
        /// </summary>
        private void BransGetir()
        {
            SqlCommand command = new SqlCommand("Select BransAd From Tbl_Branslar", connection.Baglanti());
            SqlDataReader dr=command.ExecuteReader();

            while (dr.Read())
            {
                cmbBrans.Properties.Items.Add(dr[0]);
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// doktorları combobox içerisine getirir
        /// </summary>
        private void DoktorGetir()
        {
            cmbDoktor.Properties.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@doktorBrans", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorBrans", cmbBrans.Text);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                //dr[0] + " " + dr[1] => değerleri Doktorlar tablosundaki ad ve soyad sütün numaralarıdır
                cmbDoktor.Properties.Items.Add(dr[0] + " " + dr[1]);
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// doktora atanan randevuları gridControlRandevuGecmisi nesnesine getirir
        /// </summary>
        private void DoktoraBagliRandevuGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Randevuid,RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor from Tbl_Randevular where RandevuBrans='" + cmbBrans.Text + "'" + "and RandevuDoktor='" + cmbDoktor.Text + "' and RandevuDurum=0", connection.Baglanti());
            da.Fill(dt);

            gridControlRandevuGecmisi.DataSource = dt;
        }

        private void RandevuAl()
        {
            SqlCommand command = new SqlCommand("Update Tbl_Randevular Set RandevuDurum=1,HastaTc=@hastaTC,HastaSikayet=@hastaSikayet Where Randevuid=@randevuID", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaTC",lblHastaTC.Text);
            command.Parameters.AddWithValue("@hastaSikayet",memoSikayet.Text);
            command.Parameters.AddWithValue("@randevuID",txtRandevuId.Text);


            connection.Baglanti().Close();

            XtraMessageBox.Show("Randevu alınmıştır!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmHataDetayForm_Load(object sender, EventArgs e)
        {
            //Ad soyad bilgileri çekme
            lblHastaTC.Text = tc;
            SqlCommand komut = new SqlCommand("Select HastaAd,HastaSoyad From Tbl_Hastalar where HastaTc=@p1", connection.Baglanti());
            komut.Parameters.AddWithValue("@p1", tc);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblHastaAdSoyad.Text = dr[0] + " " + dr[1];
            }
            connection.Baglanti().Close();

            //AdSoyadBilgisiGetir();

            RandevuGecmisiGetir();

            BransGetir();

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridAktifRandevular.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridAktifRandevular.OptionsBehavior.Editable = false;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridRandevuGecmisi.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridRandevuGecmisi.OptionsBehavior.Editable = false;
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktorGetir();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DoktoraBagliRandevuGetir();
        }

        private void LnkBilgiGoruntule_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaDuzenleForm frm = new frmHastaDuzenleForm();
            frm.tc = lblHastaTC.Text;

            frm.Show();
        }

        private void LnkBilgiDuzenle_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            RandevuAl();
        }

        //gridview içerisinden seçilen satıra göre verileri hedef nesnelere getirir
        private void gridAktifRandevular_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridAktifRandevular.GetDataRow(gridAktifRandevular.FocusedRowHandle);

            if (dr != null)
            {
                txtRandevuId.Text = dr["Randevuid"].ToString();

            }
        }

        private void frmHastaDetayForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason==CloseReason.UserClosing)
            {
                if (XtraMessageBox.Show("Kapatmak istediğinize emin misiniz?","ABC Hastanesi",MessageBoxButtons.YesNo)==DialogResult.No)
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