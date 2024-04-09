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
    public partial class frmBransForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmBransForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// branşları gridControl içerisine getirir
        /// </summary>
        private void BransGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", connection.Baglanti());
            da.Fill(dt);

            gridControl1.DataSource= dt;
        }

        /// <summary>
        /// branşları listeler
        /// </summary>
        private void BransListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Branslar", connection.Baglanti());

            da.Fill(dt);

            gridControl1.DataSource= dt;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridView1.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridView1.OptionsBehavior.Editable = false;

        }

        /// <summary>
        /// veritabanına branş ekler
        /// </summary>
        private void BransEkle()
        {
            SqlCommand command = new SqlCommand("Insert Into Tbl_Branslar (BransAd) Values(@bransAd)", connection.Baglanti());
            command.Parameters.AddWithValue("@bransAd", txtBransAd.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Branş eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// veritabanındaki branşı günceller
        /// </summary>
        private void BransGuncelle()
        {
            SqlCommand command = new SqlCommand("Update Tbl_Branslar Set BransAd=@bransAd Where Bransid=@brandId", connection.Baglanti());
            command.Parameters.AddWithValue("@bransAd", txtBransAd.Text);
            command.Parameters.AddWithValue("@brandId", txtBransID.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Branş güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        /// <summary>
        /// veritabanındaki branşı siler
        /// </summary>
        private void BransSil()
        {
            SqlCommand command = new SqlCommand("Delete From Tbl_Branslar Where Bransid=@bransId", connection.Baglanti());

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Branş silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmBransForm_Load(object sender, EventArgs e)
        {
            BransGetir();
        }

        private void btnBransListele_Click(object sender, EventArgs e)
        {
            BransListele();
        }

        private void btnBransEkle_Click(object sender, EventArgs e)
        {
            BransEkle();
        }

        private void btnBransDuzenle_Click(object sender, EventArgs e)
        {
            BransGuncelle();
        }

        private void btnBransSil_Click(object sender, EventArgs e)
        {
            BransSil();
        }

        //gridview içerisinden seçilen satıra göre verileri hedef nesnelere getirir
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtBransID.Text = dr["Bransid"].ToString();
                txtBransAd.Text = dr["BransAd"].ToString();

            }
        }
    }
}