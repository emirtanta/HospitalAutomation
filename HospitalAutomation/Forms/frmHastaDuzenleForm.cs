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
    public partial class frmHastaDuzenleForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public string tc;

        public frmHastaDuzenleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// tc değerine göre hasta bilgilerini hedef nesnelere getirir
        /// </summary>
        private void HastaBilgileri()
        {
            mskTxtHastaTC.Text = tc;

            SqlCommand command = new SqlCommand("Select HastaAd AS 'Ad',HastaSoyad AS 'Soyad',HastaTc AS 'TC',HastaTelefon AS 'Telefon',HastaCinsiyet AS 'Cinsiyet' From Tbl_Hastalar Where HastaTc=@hastaTC", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaTC", tc);

            SqlDataReader dr=command.ExecuteReader();

            while (dr.Read())
            {
                txtHastaAd.Text = dr[1].ToString();
                txtHastaSoyad.Text = dr[2].ToString();
                mskTxtHastaTelefon.Text = dr[4].ToString();
                cmbHastaCinsiyet.Text = dr[5].ToString();
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// tc değer,ne göre hasta bilgilerini günceller
        /// </summary>
        private void HastaGuncelle()
        {
            SqlCommand command = new SqlCommand("Update Tbl_Hastalar Set HastaAd=@hastaAd,HastaSoyad=@hastaSoyad,HastaTelefon=@hastaTelefon,HastaSifre=@hastaSifre,HastaCinsiyet=@hastaCinsiyet Where HastaTc=@hastaTC", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaAd",txtHastaAd.Text);
            command.Parameters.AddWithValue("@hastaSoyad",txtHastaSoyad.Text);
            command.Parameters.AddWithValue("@hastaTelefon",mskTxtHastaTelefon.Text);
            command.Parameters.AddWithValue("@hastaSifre",txtHastaSifre.Text);
            command.Parameters.AddWithValue("@hastaCinsiyet",cmbHastaCinsiyet.Text);
            command.Parameters.AddWithValue("@hastaTC",mskTxtHastaTC.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show($"{mskTxtHastaTC.Text} numaralı hasta bilgisi güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmHastaDuzenleForm_Load(object sender, EventArgs e)
        {
            HastaBilgileri();
        }

        private void btnHastaGuncelle_Click(object sender, EventArgs e)
        {
            HastaGuncelle();

            this.Close();
        }
    }
}