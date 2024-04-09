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
    public partial class frmHastaGoruntuleForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        public string Tc;

        public frmHastaGoruntuleForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// hasta bilgilerini tc kimlik numarasına göre hedef nesnelere getirir
        /// </summary>
        private void HastaBilgileri()
        {
            SqlCommand command = new SqlCommand("Select * From Tbl_Hastalar Where HastaTc=@hastaTC", connection.Baglanti());
            command.Parameters.AddWithValue("@hastaTC", Tc);

            SqlDataReader dataReader = command.ExecuteReader();

            while (dataReader.Read())
            {
                //dataReader[1]=> değeri Tablodaki sütünun indis değeridir
                lblHastaAd.Text = dataReader[1].ToString();
                lblHastaSoyad.Text = dataReader[2].ToString();
                lblHastaTelefon.Text = dataReader[4].ToString();
                lblHastaSifre.Text = dataReader[5].ToString();
                lblHastaCinsiyet.Text= dataReader[6].ToString();
            }

            connection.Baglanti().Close();
        }

        private void frmHastaGoruntuleForm_Load(object sender, EventArgs e)
        {
            //Tc değerine labe nesnesine aktardık
            lblHastaTC.Text = Tc;

            HastaBilgileri();
        }
    }
}