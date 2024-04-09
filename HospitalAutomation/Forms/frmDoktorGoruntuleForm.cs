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
    public partial class frmDoktorGoruntuleForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection=new SqlBaglantisi();

        public string Tc;//DoktorDetay formuna tc verisini aktarmak için tanımlandı

        public frmDoktorGoruntuleForm()
        {
            InitializeComponent();
        }

        private void frmDoktorGoruntuleForm_Load(object sender, EventArgs e)
        {
            lblTc.Text = Tc;

            //hasta bilgilerini getirir
            SqlCommand command = new SqlCommand("Select * From Tbl_Doktorlar Where DoktorTc@doktorTC", connection.Baglanti());
            command.Parameters.AddWithValue("@doktorTC", Tc);

            SqlDataReader dr = command.ExecuteReader();

            //doktor bilgilerini label nesnelerine getirme işlemi
            while (dr.Read())
            {
                lblAd.Text = dr[1].ToString();
                lblSoyad.Text = dr[2].ToString();
                lblBrans.Text = dr[3].ToString();
                lblTc.Text = dr[4].ToString();
                lblSifre.Text = dr[5].ToString();
            }

            connection.Baglanti().Close();
        }
    }
}