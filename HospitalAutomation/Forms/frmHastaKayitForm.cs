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
    public partial class frmHastaKayitForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmHastaKayitForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// hatayı veritabanına kaydeder
        /// </summary>
        private void HastaKayit()
        {
            SqlCommand command = new SqlCommand("Insert Into Tbl_Hastalar (HastaAd,HastaSoyad,HastaTc,HastaTelefon,HastaSifre,HastaCinsiyet) Values(@hastaAd,@hastaSoyad,@hastaTC,@hastaTelefon,@hastaSifre,@hastaCinsiyet)", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaAd",txtHastaAd.Text);
            command.Parameters.AddWithValue("@hastaSoyad",txtHastaSoyad.Text);
            command.Parameters.AddWithValue("@hastaTC",mskTxtHastaTC.Text);
            command.Parameters.AddWithValue("@hastaTelefon",mskTxtHastaTelefon.Text);
            command.Parameters.AddWithValue("@hastaSifre",txtHastaSifre.Text);
            command.Parameters.AddWithValue("@hastaCinsiyet",cmbCinsiyet.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Kaydınız gerçekleşmiştir. Şifreniz: " + txtHastaSifre.Text, "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            
        }

        private void btnHastaKayit_Click(object sender, EventArgs e)
        {
            HastaKayit();

            this.Close();
        }
    }
}