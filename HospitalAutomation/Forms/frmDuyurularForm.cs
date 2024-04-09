﻿using DevExpress.XtraEditors;
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
    public partial class frmDuyurularForm : DevExpress.XtraEditors.XtraForm
    {
        SqlBaglantisi connection = new SqlBaglantisi();

        /// <summary>
        /// duyurularu gridControl içerisine getirir
        /// </summary>
        private void DuyuruGetir()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select Duyuruid AS '#',Duyuru,DuyuruTarih AS 'Tarih' From Tbl_Duyurular Order By Duyuruid DESC", connection.Baglanti());
            da.Fill(dt);

            gridControl1.DataSource= dt;

            // Sütün boyutlarının yeniden boyutlandırılmasını engelleyelim
            gridView1.OptionsCustomization.AllowColumnResizing = false;

            //gridView içerisindeki sütunların düzenlenebilir olmasını engeller
            gridView1.OptionsBehavior.Editable=false;
        }

        public frmDuyurularForm()
        {
            InitializeComponent();

            DuyuruGetir();
        }
    }
}