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
    public partial class frmDuyuruPaneliForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmDuyuruPaneliForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// duyurularu gridControl içerisine getirir
        /// </summary>
        private void DuyuruListele()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Duyuruid,Duyuru,DuyuruTarih AS 'Tarih' From Tbl_Duyurular Order By Duyuruid DESC", connection.Baglanti());
            da.Fill(dt);

            gridControl1.DataSource = dt;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridView1.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridView1.OptionsBehavior.Editable = false;
        }

        /// <summary>
        /// id değerine göre duyuru günceller
        /// </summary>
        private void DuyuruGuncelle()
        {
            SqlCommand command = new SqlCommand("Update Tbl_Duyurular Set Duyuru=@duyuru Where Duyuruid=@duyuruId", connection.Baglanti());
            command.Parameters.AddWithValue("@duyuru", memoDuyuruAciklama.Text);
            command.Parameters.AddWithValue("@duyuruId", txtDuyuruId.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Duyuru güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// veritabanından bir adet duyuru siler
        /// </summary>
        private void DuyuruSil()
        {
            SqlCommand command = new SqlCommand("Delete From Tbl_Duyurular Where Duyuruid = @duyuruId", connection.Baglanti());
            command.Parameters.AddWithValue("@duyuruId", txtDuyuruId.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show("Duyuru silindi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmDuyuruPaneliForm_Load(object sender, EventArgs e)
        {
            DuyuruListele();
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            DuyuruListele();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DuyuruGuncelle();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DuyuruSil();
        }


        //gridview içerisinden seçilen satıra göre verileri hedef nesnelere getirir
        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtDuyuruId.Text = dr["Duyuruid"].ToString();
                memoDuyuruAciklama.Text = dr["Duyuru"].ToString();

            }
        }
    }
}