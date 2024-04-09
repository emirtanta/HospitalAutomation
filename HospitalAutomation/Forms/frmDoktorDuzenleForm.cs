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
    public partial class frmDoktorDuzenleForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public string TCNO; //frmDoktorDetay formuna tc verisini aktarmak için taımlandı

        public frmDoktorDuzenleForm()
        {
            InitializeComponent();
        }

        private void frmDoktorDuzenleForm_Load(object sender, EventArgs e)
        {
            txtDoktorTC.Text = TCNO;

            SqlCommand command = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc = @doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorTC", TCNO);

            SqlDataReader dr = command.ExecuteReader();

            while(dr.Read()) 
            {
                txtDoktorAd.Text = dr[1].ToString();
                txtDoktorSoyad.Text = dr[2].ToString();
                lueDoktorBrans.Text = dr[3].ToString();
                txtDoktorSifre.Text = dr[5].ToString();
            }

            connection.Baglanti().Close();

            //branşları lookUp nesnesine getirme
            SqlCommand command2 = new SqlCommand("Select BransAd From Tbl_Branslar", connection.Baglanti());
            SqlDataReader dr2 = command2.ExecuteReader();

            while (dr2.Read())
            {
                lueDoktorBrans.Properties.ValueMember = "Bransid";
                lueDoktorBrans.Properties.DisplayMember = "BransAd";
                lueDoktorBrans.Properties.DataSource = command2;
            }
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@doktorAd,DoktorSoyad=@doktorSoyad,DoktorBrans=@doktorBrans,DoktorSifre=@doktorSifre Where DoktorTc=@doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorAd", txtDoktorAd.Text);
            command.Parameters.AddWithValue("@doktorSoyad", txtDoktorSoyad.Text);
            command.Parameters.AddWithValue("@doktorBrans", lueDoktorBrans.EditValue);
            command.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text);


            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Bilgiler güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.Close();
        }
    }
}