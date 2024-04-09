namespace HospitalAutomation.Forms
{
    partial class frmPersonelDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelDetayForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.btnDoktorPaneli = new DevExpress.XtraEditors.SimpleButton();
            this.btnBransPaneli = new DevExpress.XtraEditors.SimpleButton();
            this.btnRandevuPaneli = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuyuruPaneli = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblPersonelAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblPersonelTC = new DevExpress.XtraEditors.LabelControl();
            this.memoDuyuru = new DevExpress.XtraEditors.MemoEdit();
            this.lblTarih = new DevExpress.XtraEditors.LabelControl();
            this.btnDuyuruOlustur = new DevExpress.XtraEditors.SimpleButton();
            this.mskTxtTarih = new System.Windows.Forms.MaskedTextBox();
            this.mskTxtSaat = new System.Windows.Forms.MaskedTextBox();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.txtId = new DevExpress.XtraEditors.TextEdit();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbDoktor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlBrans = new DevExpress.XtraGrid.GridControl();
            this.gridBrans = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridControlDoktor = new DevExpress.XtraGrid.GridControl();
            this.gridDoktor = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoDuyuru.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoktor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrans)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoktor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoktor)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lblPersonelTC);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblPersonelAdSoyad);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(266, 111);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Personel Bilgileri";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnDuyuruOlustur);
            this.groupControl2.Controls.Add(this.lblTarih);
            this.groupControl2.Controls.Add(this.memoDuyuru);
            this.groupControl2.Location = new System.Drawing.Point(12, 129);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(266, 395);
            this.groupControl2.TabIndex = 0;
            this.groupControl2.Text = "Duyuru Oluştur";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlBrans);
            this.groupControl3.Location = new System.Drawing.Point(585, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(260, 225);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Branşlar";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControlDoktor);
            this.groupControl4.Location = new System.Drawing.Point(585, 243);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(260, 276);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Doktorlar";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.btnKaydet);
            this.groupControl5.Controls.Add(this.cmbDoktor);
            this.groupControl5.Controls.Add(this.cmbBrans);
            this.groupControl5.Controls.Add(this.txtId);
            this.groupControl5.Controls.Add(this.mskTxtSaat);
            this.groupControl5.Controls.Add(this.labelControl5);
            this.groupControl5.Controls.Add(this.labelControl7);
            this.groupControl5.Controls.Add(this.labelControl6);
            this.groupControl5.Controls.Add(this.labelControl4);
            this.groupControl5.Controls.Add(this.labelControl3);
            this.groupControl5.Controls.Add(this.mskTxtTarih);
            this.groupControl5.Location = new System.Drawing.Point(284, 12);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(295, 507);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Doktor Randevu Oluşturma";
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.btnDuyuruPaneli);
            this.groupControl6.Controls.Add(this.btnRandevuPaneli);
            this.groupControl6.Controls.Add(this.btnBransPaneli);
            this.groupControl6.Controls.Add(this.btnDoktorPaneli);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl6.Location = new System.Drawing.Point(0, 529);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(845, 100);
            this.groupControl6.TabIndex = 0;
            this.groupControl6.Text = "Hızlı Erişim";
            // 
            // btnDoktorPaneli
            // 
            this.btnDoktorPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDoktorPaneli.Location = new System.Drawing.Point(2, 23);
            this.btnDoktorPaneli.Name = "btnDoktorPaneli";
            this.btnDoktorPaneli.Size = new System.Drawing.Size(111, 75);
            this.btnDoktorPaneli.TabIndex = 0;
            this.btnDoktorPaneli.Text = "Doktor Paneli";
            this.btnDoktorPaneli.Click += new System.EventHandler(this.btnDoktorPaneli_Click);
            // 
            // btnBransPaneli
            // 
            this.btnBransPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnBransPaneli.Location = new System.Drawing.Point(113, 23);
            this.btnBransPaneli.Name = "btnBransPaneli";
            this.btnBransPaneli.Size = new System.Drawing.Size(111, 75);
            this.btnBransPaneli.TabIndex = 1;
            this.btnBransPaneli.Text = "Branş Paneli";
            this.btnBransPaneli.Click += new System.EventHandler(this.btnBransPaneli_Click);
            // 
            // btnRandevuPaneli
            // 
            this.btnRandevuPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRandevuPaneli.Location = new System.Drawing.Point(224, 23);
            this.btnRandevuPaneli.Name = "btnRandevuPaneli";
            this.btnRandevuPaneli.Size = new System.Drawing.Size(111, 75);
            this.btnRandevuPaneli.TabIndex = 2;
            this.btnRandevuPaneli.Text = "Randevu Paneli";
            this.btnRandevuPaneli.Click += new System.EventHandler(this.btnRandevuPaneli_Click);
            // 
            // btnDuyuruPaneli
            // 
            this.btnDuyuruPaneli.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnDuyuruPaneli.Location = new System.Drawing.Point(335, 23);
            this.btnDuyuruPaneli.Name = "btnDuyuruPaneli";
            this.btnDuyuruPaneli.Size = new System.Drawing.Size(111, 75);
            this.btnDuyuruPaneli.TabIndex = 3;
            this.btnDuyuruPaneli.Text = "Duyuru Paneli";
            this.btnDuyuruPaneli.Click += new System.EventHandler(this.btnDuyuruPaneli_Click);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(85, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "labelControl1";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 73);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(85, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "labelControl1";
            // 
            // lblPersonelAdSoyad
            // 
            this.lblPersonelAdSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelAdSoyad.Appearance.Options.UseFont = true;
            this.lblPersonelAdSoyad.Location = new System.Drawing.Point(115, 38);
            this.lblPersonelAdSoyad.Name = "lblPersonelAdSoyad";
            this.lblPersonelAdSoyad.Size = new System.Drawing.Size(75, 16);
            this.lblPersonelAdSoyad.TabIndex = 0;
            this.lblPersonelAdSoyad.Text = "labelControl1";
            // 
            // lblPersonelTC
            // 
            this.lblPersonelTC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblPersonelTC.Appearance.Options.UseFont = true;
            this.lblPersonelTC.Location = new System.Drawing.Point(115, 73);
            this.lblPersonelTC.Name = "lblPersonelTC";
            this.lblPersonelTC.Size = new System.Drawing.Size(77, 16);
            this.lblPersonelTC.TabIndex = 0;
            this.lblPersonelTC.Text = "00000000000";
            // 
            // memoDuyuru
            // 
            this.memoDuyuru.Location = new System.Drawing.Point(6, 39);
            this.memoDuyuru.Name = "memoDuyuru";
            this.memoDuyuru.Size = new System.Drawing.Size(255, 290);
            this.memoDuyuru.TabIndex = 0;
            // 
            // lblTarih
            // 
            this.lblTarih.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTarih.Appearance.Options.UseFont = true;
            this.lblTarih.Location = new System.Drawing.Point(6, 335);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(75, 16);
            this.lblTarih.TabIndex = 1;
            this.lblTarih.Text = "labelControl3";
            // 
            // btnDuyuruOlustur
            // 
            this.btnDuyuruOlustur.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnDuyuruOlustur.Location = new System.Drawing.Point(125, 356);
            this.btnDuyuruOlustur.Name = "btnDuyuruOlustur";
            this.btnDuyuruOlustur.Size = new System.Drawing.Size(136, 34);
            this.btnDuyuruOlustur.TabIndex = 2;
            this.btnDuyuruOlustur.Text = "Duyuru Oluştur";
            this.btnDuyuruOlustur.Click += new System.EventHandler(this.btnDuyuruOlustur_Click);
            // 
            // mskTxtTarih
            // 
            this.mskTxtTarih.Location = new System.Drawing.Point(141, 103);
            this.mskTxtTarih.Mask = "00/00/0000";
            this.mskTxtTarih.Name = "mskTxtTarih";
            this.mskTxtTarih.Size = new System.Drawing.Size(100, 21);
            this.mskTxtTarih.TabIndex = 0;
            this.mskTxtTarih.ValidatingType = typeof(System.DateTime);
            // 
            // mskTxtSaat
            // 
            this.mskTxtSaat.Location = new System.Drawing.Point(142, 144);
            this.mskTxtSaat.Mask = "90:00";
            this.mskTxtSaat.Name = "mskTxtSaat";
            this.mskTxtSaat.Size = new System.Drawing.Size(100, 21);
            this.mskTxtSaat.TabIndex = 0;
            this.mskTxtSaat.ValidatingType = typeof(System.DateTime);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(17, 149);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(31, 16);
            this.labelControl3.TabIndex = 1;
            this.labelControl3.Text = "Saat:";
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(17, 108);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(35, 16);
            this.labelControl4.TabIndex = 1;
            this.labelControl4.Text = "Tarih:";
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(17, 73);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(20, 16);
            this.labelControl5.TabIndex = 1;
            this.labelControl5.Text = "No:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(17, 231);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(42, 16);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Doktor:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(17, 190);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(37, 16);
            this.labelControl7.TabIndex = 1;
            this.labelControl7.Text = "Branş:";
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(141, 68);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(100, 20);
            this.txtId.TabIndex = 2;
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(141, 185);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Size = new System.Drawing.Size(100, 20);
            this.cmbBrans.TabIndex = 3;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Location = new System.Drawing.Point(141, 227);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDoktor.Size = new System.Drawing.Size(100, 20);
            this.cmbDoktor.TabIndex = 3;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton6.ImageOptions.Image")));
            this.btnKaydet.Location = new System.Drawing.Point(148, 268);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(93, 49);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // gridControlBrans
            // 
            this.gridControlBrans.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlBrans.Location = new System.Drawing.Point(2, 23);
            this.gridControlBrans.MainView = this.gridBrans;
            this.gridControlBrans.Name = "gridControlBrans";
            this.gridControlBrans.Size = new System.Drawing.Size(256, 200);
            this.gridControlBrans.TabIndex = 0;
            this.gridControlBrans.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridBrans});
            // 
            // gridBrans
            // 
            this.gridBrans.GridControl = this.gridControlBrans;
            this.gridBrans.Name = "gridBrans";
            this.gridBrans.OptionsView.ShowGroupPanel = false;
            // 
            // gridControlDoktor
            // 
            this.gridControlDoktor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlDoktor.Location = new System.Drawing.Point(2, 23);
            this.gridControlDoktor.MainView = this.gridDoktor;
            this.gridControlDoktor.Name = "gridControlDoktor";
            this.gridControlDoktor.Size = new System.Drawing.Size(256, 251);
            this.gridControlDoktor.TabIndex = 0;
            this.gridControlDoktor.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridDoktor});
            // 
            // gridDoktor
            // 
            this.gridDoktor.GridControl = this.gridControlDoktor;
            this.gridDoktor.Name = "gridDoktor";
            // 
            // frmPersonelDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 629);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl6);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Detay Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonelDetayForm_FormClosing);
            this.Load += new System.EventHandler(this.frmPersonelDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            this.groupControl5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoDuyuru.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoktor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlBrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridBrans)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlDoktor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridDoktor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.SimpleButton btnDuyuruPaneli;
        private DevExpress.XtraEditors.SimpleButton btnRandevuPaneli;
        private DevExpress.XtraEditors.SimpleButton btnBransPaneli;
        private DevExpress.XtraEditors.SimpleButton btnDoktorPaneli;
        private DevExpress.XtraEditors.LabelControl lblPersonelTC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblPersonelAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnDuyuruOlustur;
        private DevExpress.XtraEditors.LabelControl lblTarih;
        private DevExpress.XtraEditors.MemoEdit memoDuyuru;
        private DevExpress.XtraGrid.GridControl gridControlBrans;
        private DevExpress.XtraGrid.Views.Grid.GridView gridBrans;
        private DevExpress.XtraGrid.GridControl gridControlDoktor;
        private DevExpress.XtraGrid.Views.Grid.GridView gridDoktor;
        private DevExpress.XtraEditors.SimpleButton btnKaydet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDoktor;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
        private DevExpress.XtraEditors.TextEdit txtId;
        private System.Windows.Forms.MaskedTextBox mskTxtSaat;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.MaskedTextBox mskTxtTarih;
    }
}