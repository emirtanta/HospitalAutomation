using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.BandedGrid;
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
    public partial class frmRandevuForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public frmRandevuForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// randevuları gridview içerisine getirir
        /// </summary>
        private void RandevuListesi()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Randevular", connection.Baglanti());
            da.Fill(dt);

            gridControl1.DataSource = dt;
        }

        private void RandevuSil()
        {
            SqlCommand command = new SqlCommand("Delete  From Tbl_Randevular Where Randevuid=@randevuID", connection.Baglanti());
            command.Parameters.AddWithValue("@randevuID",txtRandevuId.Text);

            command.ExecuteNonQuery();

            connection.Baglanti().Close();

            XtraMessageBox.Show($"{txtRandevuId} numaralı randevu silindi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RandevuGuncelle()
        {
            SqlCommand command = new SqlCommand("Update Tbl_Randevular Set RandevuTarih=@randevuTarih,RandevuSaat=@randevuSaat,RandevuBrans=@randevuBrans,RandevuDoktor=@randevuDoktor,RandevuDurum=@randevuDurum,HastaTc=@hastaTC,HastaSikayet=@hastaSikayet Where Randevuid=@randevuID", connection.Baglanti());
            command.Parameters.AddWithValue("@randevuTarih",mskTxtTarih.Text);
            command.Parameters.AddWithValue("@randevuSaat",mskTxtSaat.Text);
            command.Parameters.AddWithValue("@randevuBrans",cmbBrans.Text);
            command.Parameters.AddWithValue("@randevuDoktor",cmbDoktor.Text);
            command.Parameters.AddWithValue("@randevuDurum",cmbDurum.Text);
            command.Parameters.AddWithValue("@hastaTC",mskTxtTC.Text);
            command.Parameters.AddWithValue("@hastaSikayet",memoSikayet.Text);
            command.Parameters.AddWithValue("@randevuID",txtRandevuId.Text);

            command.ExecuteNonQuery();

            XtraMessageBox.Show("Randevu güncellendi!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// branşları comboboxBrans içerisine getirir
        /// </summary>
        private void Branslar()
        {
            SqlCommand command = new SqlCommand("Select BransAd From Tbl_Branslar", connection.Baglanti());
            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read()) 
            {
                cmbBrans.Properties.Items.Add(dr[0]);
            }

            connection.Baglanti().Close();
        }

        /// <summary>
        /// durumları comboboxDurum nesnesine getirir
        /// </summary>
        private void Durumlar()
        {
            string[] durum = { "True", "False" };

            foreach (var item in durum)
            {
                cmbDurum.Properties.Items.Add(item);
            }
        }

        /// <summary>
        /// doktorları doktorların bulunduğu combobox nesnesine branşa göre getirir getirir
        /// </summary>
        private void Doktorlar()
        {
            SqlCommand command = new SqlCommand("Select DoktorAd,DoktorSoyad From Tbl_Doktorlar Where DoktorBrans=@doktorBrans", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorBrans", cmbBrans.Text);

            SqlDataReader dr = command.ExecuteReader();

            while (dr.Read())
            {
                cmbDoktor.Properties.Items.Add(dr[0] + " " + dr[1]);
            }

            connection.Baglanti().Close();
        }

        private void frmRandevuForm_Load(object sender, EventArgs e)
        {
            RandevuListesi();

            Branslar();

            Durumlar();

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridView1.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridView1.OptionsBehavior.Editable = false;
        }

        

        private void btnListele_Click(object sender, EventArgs e)
        {
            RandevuListesi();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (mskTxtTC.Text=="" || mskTxtTC.Text==string.Empty)
            {
                XtraMessageBox.Show("Lütfen tc kimlik numarası giriniz!", "Bilgi");
            }

            else
            {
                RandevuGuncelle();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            RandevuSil();
        }

        private void cmbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            Doktorlar();
        }

        private void gridView1_FocusedRowObjectChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventArgs e)
        {
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                txtRandevuId.Text = dr["Randevuid"].ToString();
                mskTxtTarih.Text = dr["RandevuTarih"].ToString();
                mskTxtSaat.Text = dr["RandevuSaat"].ToString();
                cmbBrans.Text = dr["RandevuBrans"].ToString();
                cmbDoktor.Text = dr["RandevuDoktor"].ToString();
                cmbDurum.Text = dr["RandevuDurum"].ToString();
                mskTxtTC.Text = dr["HastaTc"].ToString();
                memoSikayet.Text = dr["HastaSikayet"].ToString();

            }
        }
    }
}