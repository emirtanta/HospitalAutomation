namespace HospitalAutomation.Forms
{
    partial class frmHastaKayitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaKayitForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaSifre = new DevExpress.XtraEditors.TextEdit();
            this.mskTxtHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.mskTxtHastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.cmbCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.btnHastaKayit = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHastaKayit);
            this.groupControl1.Controls.Add(this.cmbCinsiyet);
            this.groupControl1.Controls.Add(this.mskTxtHastaTelefon);
            this.groupControl1.Controls.Add(this.mskTxtHastaTC);
            this.groupControl1.Controls.Add(this.txtHastaSifre);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.txtHastaSoyad);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtHastaAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(303, 238);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hasta Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(41, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(70, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(117, 39);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(148, 20);
            this.txtHastaAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(41, 65);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(70, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyad:";
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(117, 65);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(148, 20);
            this.txtHastaSoyad.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(41, 145);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(70, 20);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "Şifre:";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(117, 145);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Properties.UseSystemPasswordChar = true;
            this.txtHastaSifre.Size = new System.Drawing.Size(148, 20);
            this.txtHastaSifre.TabIndex = 1;
            // 
            // mskTxtHastaTC
            // 
            this.mskTxtHastaTC.Location = new System.Drawing.Point(117, 91);
            this.mskTxtHastaTC.Mask = "00000000000";
            this.mskTxtHastaTC.Name = "mskTxtHastaTC";
            this.mskTxtHastaTC.Size = new System.Drawing.Size(148, 21);
            this.mskTxtHastaTC.TabIndex = 2;
            this.mskTxtHastaTC.ValidatingType = typeof(int);
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(41, 91);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(70, 20);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "TC:";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(41, 118);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 20);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Telefon:";
            // 
            // mskTxtHastaTelefon
            // 
            this.mskTxtHastaTelefon.Location = new System.Drawing.Point(117, 118);
            this.mskTxtHastaTelefon.Mask = "(999) 000-0000";
            this.mskTxtHastaTelefon.Name = "mskTxtHastaTelefon";
            this.mskTxtHastaTelefon.Size = new System.Drawing.Size(148, 21);
            this.mskTxtHastaTelefon.TabIndex = 2;
            // 
            // cmbCinsiyet
            // 
            this.cmbCinsiyet.Location = new System.Drawing.Point(117, 171);
            this.cmbCinsiyet.Name = "cmbCinsiyet";
            this.cmbCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbCinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbCinsiyet.Size = new System.Drawing.Size(148, 20);
            this.cmbCinsiyet.TabIndex = 3;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(41, 170);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(70, 20);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Cinsiyet:";
            // 
            // btnHastaKayit
            // 
            this.btnHastaKayit.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnHastaKayit.Location = new System.Drawing.Point(165, 197);
            this.btnHastaKayit.Name = "btnHastaKayit";
            this.btnHastaKayit.Size = new System.Drawing.Size(100, 23);
            this.btnHastaKayit.TabIndex = 4;
            this.btnHastaKayit.Text = "Kayıt Yap";
            this.btnHastaKayit.Click += new System.EventHandler(this.btnHastaKayit_Click);
            // 
            // frmHastaKayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 238);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHastaKayitForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Kayıt Formu";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbCinsiyet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHastaKayit;
        private DevExpress.XtraEditors.ComboBoxEdit cmbCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTxtHastaTelefon;
        private System.Windows.Forms.MaskedTextBox mskTxtHastaTC;
        private DevExpress.XtraEditors.TextEdit txtHastaSifre;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit txtHastaSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHastaAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}