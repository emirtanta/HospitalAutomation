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
    public partial class frmPersonelDetayForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public string TcNumara;

        public frmPersonelDetayForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// giriş yapan personelin ad soyad bilgisini getirir
        /// </summary>
        private void AdSoyadBilgisiGetir()
        {
            lblPersonelTC.Text = TcNumara;

            //ad soyad bilgilerini çeker
            SqlCommand command = new SqlCommand("Select SekreterAdSoyad From Tbl_Sekreterler Where SekreterTc=@sekreterTC", connection.Baglanti());
            command.Parameters.AddWithValue("@sekreterTC", TcNumara);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                lblPersonelAdSoyad.Text = dr[0].ToString();
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// branşları gridcontrol içerisine getirir
        /// </summary>
        private void BransGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", connection.Baglanti());
            da.Fill(dt);

            gridControlBrans.DataSource = dt;
        }

        /// <summary>
        /// doktorları gridcontrol içerisine getirir
        /// </summary>
        private void DoktorGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter dr = new SqlDataAdapter("Select DoktorAd+' '+DoktorSoyad AS 'Ad Soyad',DoktorBrans AS 'Branş' From Tbl_Doktorlar", connection.Baglanti());
            dr.Fill(dt);

            gridControlDoktor.DataSource = dt;
        }

        /// <summary>
        /// branş combobox nesnesine branşları getirir
        /// </summary>
        private void ComboBransGetir()
        {
            SqlCommand command = new SqlCommand("Select BransAd From Tbl_Branslar", connection.Baglanti());
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbBrans.Properties.Items.Add(dr[0]);
            }

            connection.Baglanti().Close();
        }

        private void  RandevuKaydet()
        {
            SqlCommand command = new SqlCommand("Insert Into Tbl_Randevular (RandevuTarih,RandevuSaat,RandevuBrans,RandevuDoktor) Values(@randevuTarih,@randevuSaat,@randevuBrans,@randevuDoktor)", connection.Baglanti());
            command.Parameters.AddWithValue("@randevuTarih",mskTxtTarih.Text);
            command.Parameters.AddWithValue("@randevuSaat",mskTxtSaat.Text);
            command.Parameters.AddWithValue("@randevuBrans",cmbBrans.Text);
            command.Parameters.AddWithValue("@randevuDoktor",cmbDoktor.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Randevu kayıt edilmiştir", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DuyuruOlustur()
        {
            SqlCommand command = new SqlCommand("Insert Into Tbl_Duyurular(Duyuru,DuyuruTarih) Values(@duyuru,@duyuruTarih)", connection.Baglanti());
            command.Parameters.AddWithValue("@duyuru", memoDuyuru.Text);
            command.Parameters.AddWithValue("@duyuruTarih", lblTarih.Text);

            connection.Baglanti().Close();

            XtraMessageBox.Show("Duyuru oluşturuldu!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmPersonelDetayForm_Load(object sender, EventArgs e)
        {
            AdSoyadBilgisiGetir();

            BransGetir();

            DoktorGetir();

            ComboBransGetir();

            lblTarih.Text = DateTime.Now.ToString();

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridBrans.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridBrans.OptionsBehavior.Editable = false;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridDoktor.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridDoktor.OptionsBehavior.Editable = false;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            RandevuKaydet();
        }

        private void btnDuyuruOlustur_Click(object sender, EventArgs e)
        {
            DuyuruOlustur();
        }

        private void frmPersonelDetayForm_FormClosing(object sender, FormClosingEventArgs e)
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

        private void btnDuyuruPaneli_Click(object sender, EventArgs e)
        {
            frmDuyuruPaneliForm frm = new frmDuyuruPaneliForm();
            frm.Show();
        }

        private void btnRandevuPaneli_Click(object sender, EventArgs e)
        {
            frmRandevuForm frm = new frmRandevuForm();
            frm.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBransForm frm = new frmBransForm();
            frm.Show();
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorForm frm = new frmDoktorForm();
            frm.Show();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDoktor.Properties.Items.Clear();

            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@doktorBrans", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorBrans", cmbBrans.Text);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbDoktor.Properties.Items.Add(dr[0] + " " + dr[1]);
            }

            connection.Baglanti().Close();
        }

        private void cmbDoktor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}