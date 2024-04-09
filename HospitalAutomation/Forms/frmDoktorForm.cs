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
    public partial class frmDoktorForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmDoktorForm()
        {
            InitializeComponent();
        }

        private void frmDoktorForm_Load(object sender, EventArgs e)
        {

            DoktorGetir();
            
            BransGetir();
            
        }

        /// <summary>
        /// doktorları getirir
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void DoktorGetir()
        {
            DataTable dt1 = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", connection.Baglanti());
            da.Fill(dt1);
            gridControl1.DataSource = dt1;
        }

        /// <summary>
        /// branşları getirir
        /// </summary>
        private void BransGetir()
        {
            DataTable dt = new DataTable();
            //SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", connection.Baglanti());
            SqlDataAdapter da = new SqlDataAdapter("Select Bransid AS '#',BransAd AS 'Branş' From Tbl_Branslar", connection.Baglanti());
            da.Fill(dt);
            
            lueDoktorBrans.Properties.ValueMember = "Bransid";
            lueDoktorBrans.Properties.DisplayMember = "BransAd";
            lueDoktorBrans.Properties.DataSource = dt;
            
        }

        private void btnDoktorEkle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Insert Into Tbl_Doktorlar (DoktorAd,DoktorSoyad,DoktorBrans,DoktorTc,DoktorSifre) Values(@doktorAd,@doktorSoyad,@doktorBrans,@doktorTC,@doktorSifre)", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorAd", txtDoktorAd.Text);
            command.Parameters.AddWithValue("@doktorSoyad", txtDoktorSoyad.Text);
            command.Parameters.AddWithValue("@doktorBrans", lueDoktorBrans.EditValue);
            command.Parameters.AddWithValue("@doktorTC", mskTxtDoktorTC.Text);
            command.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text);

            connection.Baglanti().Close();

            XtraMessageBox.Show("Doktor eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Update Tbl_Doktorlar Set DoktorAd=@doktorAd,DoktorSoyad=@doktorSoyad,DoktorBrans=@doktorBrans,DoktorSifre=@doktorSifre Where DoktorTc=@doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorAd", txtDoktorAd.Text);
            command.Parameters.AddWithValue("@doktorSoyad", txtDoktorSoyad.Text);
            command.Parameters.AddWithValue("@doktorBrans", lueDoktorBrans.EditValue);
            command.Parameters.AddWithValue("@doktorSifre", txtDoktorSifre.Text);
            command.Parameters.AddWithValue("@doktorTC", mskTxtDoktorTC.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Doktor güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorSil_Click(object sender, EventArgs e)
        {
            SqlCommand command = new SqlCommand("Delete From Tbl_Doktorlar Where DoktorTc=@doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorTC", mskTxtDoktorTC.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Doktor silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDoktorListele_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Doktorlar", connection.Baglanti());

            da.Fill(dt);

            gridControl1.DataSource = dt;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridView1.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridView1.OptionsBehavior.Editable = false;
        }

        //gridview içerisinden seçilen satıra göre verileri hedef nesnelere getirir
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtDoktorAd.Text = dr["DoktorAd"].ToString();
                
                txtDoktorSoyad.Text = dr["DoktorSoyad"].ToString();
                lueDoktorBrans.Text = dr["DoktorBrans"].ToString();//lookUpEdit'deki veriyi ilgili nesneye atama
                mskTxtDoktorTC.Text = dr["DoktorTc"].ToString();
                txtDoktorSifre.Text = dr["DoktorSifre"].ToString();
                
            }
        }
    }
}