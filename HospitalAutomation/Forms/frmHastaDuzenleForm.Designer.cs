namespace HospitalAutomation.Forms
{
    partial class frmHastaDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaDuzenleForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaSoyad = new DevExpress.XtraEditors.TextEdit();
            this.mskTxtHastaTC = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtHastaTelefon = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.txtHastaSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.cmbHastaCinsiyet = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnHastaGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHastaCinsiyet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnHastaGuncelle);
            this.groupControl1.Controls.Add(this.cmbHastaCinsiyet);
            this.groupControl1.Controls.Add(this.mskTxtHastaTelefon);
            this.groupControl1.Controls.Add(this.mskTxtHastaTC);
            this.groupControl1.Controls.Add(this.txtHastaSifre);
            this.groupControl1.Controls.Add(this.txtHastaSoyad);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtHastaAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(298, 268);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hasta Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(13, 52);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(88, 20);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // txtHastaAd
            // 
            this.txtHastaAd.Location = new System.Drawing.Point(107, 53);
            this.txtHastaAd.Name = "txtHastaAd";
            this.txtHastaAd.Size = new System.Drawing.Size(144, 20);
            this.txtHastaAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(13, 78);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 20);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyad:";
            // 
            // txtHastaSoyad
            // 
            this.txtHastaSoyad.Location = new System.Drawing.Point(107, 78);
            this.txtHastaSoyad.Name = "txtHastaSoyad";
            this.txtHastaSoyad.Size = new System.Drawing.Size(144, 20);
            this.txtHastaSoyad.TabIndex = 1;
            // 
            // mskTxtHastaTC
            // 
            this.mskTxtHastaTC.Location = new System.Drawing.Point(107, 106);
            this.mskTxtHastaTC.Mask = "00000000000";
            this.mskTxtHastaTC.Name = "mskTxtHastaTC";
            this.mskTxtHastaTC.Size = new System.Drawing.Size(144, 21);
            this.mskTxtHastaTC.TabIndex = 2;
            this.mskTxtHastaTC.ValidatingType = typeof(int);
            // 
            // mskTxtHastaTelefon
            // 
            this.mskTxtHastaTelefon.Location = new System.Drawing.Point(107, 133);
            this.mskTxtHastaTelefon.Mask = "(999) 000-0000";
            this.mskTxtHastaTelefon.Name = "mskTxtHastaTelefon";
            this.mskTxtHastaTelefon.Size = new System.Drawing.Size(144, 21);
            this.mskTxtHastaTelefon.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl3.Location = new System.Drawing.Point(13, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 22);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TC Kimlik No:";
            // 
            // labelControl4
            // 
            this.labelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl4.Location = new System.Drawing.Point(13, 132);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(88, 20);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Telefon:";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(13, 158);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(88, 20);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Şifre:";
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(107, 158);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Size = new System.Drawing.Size(144, 20);
            this.txtHastaSifre.TabIndex = 1;
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(13, 185);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(88, 20);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Cinsiyet";
            // 
            // cmbHastaCinsiyet
            // 
            this.cmbHastaCinsiyet.Location = new System.Drawing.Point(107, 182);
            this.cmbHastaCinsiyet.Name = "cmbHastaCinsiyet";
            this.cmbHastaCinsiyet.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbHastaCinsiyet.Properties.Items.AddRange(new object[] {
            "Erkek",
            "Kadın"});
            this.cmbHastaCinsiyet.Size = new System.Drawing.Size(144, 20);
            this.cmbHastaCinsiyet.TabIndex = 3;
            // 
            // btnHastaGuncelle
            // 
            this.btnHastaGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnHastaGuncelle.Location = new System.Drawing.Point(165, 215);
            this.btnHastaGuncelle.Name = "btnHastaGuncelle";
            this.btnHastaGuncelle.Size = new System.Drawing.Size(86, 23);
            this.btnHastaGuncelle.TabIndex = 4;
            this.btnHastaGuncelle.Text = "Güncelle";
            this.btnHastaGuncelle.Click += new System.EventHandler(this.btnHastaGuncelle_Click);
            // 
            // frmHastaDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 268);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHastaDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Düzenleme Formu";
            this.Load += new System.EventHandler(this.frmHastaDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbHastaCinsiyet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnHastaGuncelle;
        private DevExpress.XtraEditors.ComboBoxEdit cmbHastaCinsiyet;
        private System.Windows.Forms.MaskedTextBox mskTxtHastaTelefon;
        private System.Windows.Forms.MaskedTextBox mskTxtHastaTC;
        private DevExpress.XtraEditors.TextEdit txtHastaSifre;
        private DevExpress.XtraEditors.TextEdit txtHastaSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHastaAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}