namespace HospitalAutomation.Forms
{
    partial class frmHastaDetayForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaDetayForm));
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnRandevuAl = new DevExpress.XtraEditors.SimpleButton();
            this.memoSikayet = new DevExpress.XtraEditors.MemoEdit();
            this.cmbDoktor = new DevExpress.XtraEditors.ComboBoxEdit();
            this.cmbBrans = new DevExpress.XtraEditors.ComboBoxEdit();
            this.txtRandevuId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlRandevuGecmisi = new DevExpress.XtraGrid.GridControl();
            this.gridRandevuGecmisi = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.gridControlAktifRandevular = new DevExpress.XtraGrid.GridControl();
            this.gridAktifRandevular = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblHastaAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.lblHastaTC = new DevExpress.XtraEditors.LabelControl();
            this.LnkBilgiDuzenle = new System.Windows.Forms.LinkLabel();
            this.LnkBilgiGoruntule = new System.Windows.Forms.LinkLabel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoktor.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandevuId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRandevuGecmisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandevuGecmisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAktifRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAktifRandevular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnRandevuAl);
            this.groupControl2.Controls.Add(this.memoSikayet);
            this.groupControl2.Controls.Add(this.cmbDoktor);
            this.groupControl2.Controls.Add(this.cmbBrans);
            this.groupControl2.Controls.Add(this.txtRandevuId);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.labelControl6);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Location = new System.Drawing.Point(12, 177);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(294, 384);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Randevu Bilgileri";
            // 
            // btnRandevuAl
            // 
            this.btnRandevuAl.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnRandevuAl.Location = new System.Drawing.Point(167, 322);
            this.btnRandevuAl.Name = "btnRandevuAl";
            this.btnRandevuAl.Size = new System.Drawing.Size(122, 57);
            this.btnRandevuAl.TabIndex = 4;
            this.btnRandevuAl.Text = "Randevu Al";
            this.btnRandevuAl.Click += new System.EventHandler(this.btnRandevuAl_Click);
            // 
            // memoSikayet
            // 
            this.memoSikayet.Location = new System.Drawing.Point(119, 150);
            this.memoSikayet.Name = "memoSikayet";
            this.memoSikayet.Size = new System.Drawing.Size(170, 166);
            this.memoSikayet.TabIndex = 3;
            // 
            // cmbDoktor
            // 
            this.cmbDoktor.Location = new System.Drawing.Point(119, 113);
            this.cmbDoktor.Name = "cmbDoktor";
            this.cmbDoktor.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbDoktor.Size = new System.Drawing.Size(170, 20);
            this.cmbDoktor.TabIndex = 2;
            this.cmbDoktor.SelectedIndexChanged += new System.EventHandler(this.cmbDoktor_SelectedIndexChanged);
            // 
            // cmbBrans
            // 
            this.cmbBrans.Location = new System.Drawing.Point(119, 81);
            this.cmbBrans.Name = "cmbBrans";
            this.cmbBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cmbBrans.Size = new System.Drawing.Size(170, 20);
            this.cmbBrans.TabIndex = 2;
            this.cmbBrans.SelectedIndexChanged += new System.EventHandler(this.cmbBrans_SelectedIndexChanged);
            // 
            // txtRandevuId
            // 
            this.txtRandevuId.Location = new System.Drawing.Point(119, 50);
            this.txtRandevuId.Name = "txtRandevuId";
            this.txtRandevuId.Size = new System.Drawing.Size(170, 20);
            this.txtRandevuId.TabIndex = 1;
            // 
            // labelControl8
            // 
            this.labelControl8.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl8.Location = new System.Drawing.Point(5, 151);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(99, 25);
            this.labelControl8.TabIndex = 0;
            this.labelControl8.Text = "Şikayet:";
            // 
            // labelControl7
            // 
            this.labelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl7.Location = new System.Drawing.Point(5, 110);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(99, 25);
            this.labelControl7.TabIndex = 0;
            this.labelControl7.Text = "Doktor:";
            // 
            // labelControl6
            // 
            this.labelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl6.Location = new System.Drawing.Point(5, 77);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(99, 25);
            this.labelControl6.TabIndex = 0;
            this.labelControl6.Text = "Branş:";
            // 
            // labelControl5
            // 
            this.labelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl5.Location = new System.Drawing.Point(5, 46);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(99, 25);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Randevu No:";
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControlRandevuGecmisi);
            this.groupControl3.Location = new System.Drawing.Point(312, 12);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(485, 272);
            this.groupControl3.TabIndex = 0;
            this.groupControl3.Text = "Randevu Geçmişi";
            // 
            // gridControlRandevuGecmisi
            // 
            this.gridControlRandevuGecmisi.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlRandevuGecmisi.Location = new System.Drawing.Point(2, 23);
            this.gridControlRandevuGecmisi.MainView = this.gridRandevuGecmisi;
            this.gridControlRandevuGecmisi.Name = "gridControlRandevuGecmisi";
            this.gridControlRandevuGecmisi.Size = new System.Drawing.Size(481, 247);
            this.gridControlRandevuGecmisi.TabIndex = 0;
            this.gridControlRandevuGecmisi.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridRandevuGecmisi});
            // 
            // gridRandevuGecmisi
            // 
            this.gridRandevuGecmisi.GridControl = this.gridControlRandevuGecmisi;
            this.gridRandevuGecmisi.Name = "gridRandevuGecmisi";
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.gridControlAktifRandevular);
            this.groupControl4.Location = new System.Drawing.Point(312, 290);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(485, 271);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Aktif Randevular";
            // 
            // gridControlAktifRandevular
            // 
            this.gridControlAktifRandevular.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlAktifRandevular.Location = new System.Drawing.Point(2, 23);
            this.gridControlAktifRandevular.MainView = this.gridAktifRandevular;
            this.gridControlAktifRandevular.Name = "gridControlAktifRandevular";
            this.gridControlAktifRandevular.Size = new System.Drawing.Size(481, 246);
            this.gridControlAktifRandevular.TabIndex = 0;
            this.gridControlAktifRandevular.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridAktifRandevular});
            // 
            // gridAktifRandevular
            // 
            this.gridAktifRandevular.GridControl = this.gridControlAktifRandevular;
            this.gridAktifRandevular.Name = "gridAktifRandevular";
            this.gridAktifRandevular.OptionsView.ShowGroupPanel = false;
            this.gridAktifRandevular.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridAktifRandevular_FocusedRowObjectChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(15, 43);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(67, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad Soyad:";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(15, 76);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(79, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "TC Kimlik No:";
            // 
            // lblHastaAdSoyad
            // 
            this.lblHastaAdSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaAdSoyad.Appearance.Options.UseFont = true;
            this.lblHastaAdSoyad.Location = new System.Drawing.Point(144, 43);
            this.lblHastaAdSoyad.Name = "lblHastaAdSoyad";
            this.lblHastaAdSoyad.Size = new System.Drawing.Size(46, 16);
            this.lblHastaAdSoyad.TabIndex = 1;
            this.lblHastaAdSoyad.Text = "Null Null";
            // 
            // lblHastaTC
            // 
            this.lblHastaTC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblHastaTC.Appearance.Options.UseFont = true;
            this.lblHastaTC.Location = new System.Drawing.Point(144, 76);
            this.lblHastaTC.Name = "lblHastaTC";
            this.lblHastaTC.Size = new System.Drawing.Size(77, 16);
            this.lblHastaTC.TabIndex = 1;
            this.lblHastaTC.Text = "00000000000";
            // 
            // LnkBilgiDuzenle
            // 
            this.LnkBilgiDuzenle.AutoSize = true;
            this.LnkBilgiDuzenle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkBilgiDuzenle.Location = new System.Drawing.Point(164, 121);
            this.LnkBilgiDuzenle.Name = "LnkBilgiDuzenle";
            this.LnkBilgiDuzenle.Size = new System.Drawing.Size(111, 16);
            this.LnkBilgiDuzenle.TabIndex = 3;
            this.LnkBilgiDuzenle.TabStop = true;
            this.LnkBilgiDuzenle.Text = "Bilgilerimi Düzenle";
            this.LnkBilgiDuzenle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkBilgiDuzenle_LinkClicked);
            // 
            // LnkBilgiGoruntule
            // 
            this.LnkBilgiGoruntule.AutoSize = true;
            this.LnkBilgiGoruntule.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LnkBilgiGoruntule.Location = new System.Drawing.Point(12, 121);
            this.LnkBilgiGoruntule.Name = "LnkBilgiGoruntule";
            this.LnkBilgiGoruntule.Size = new System.Drawing.Size(121, 16);
            this.LnkBilgiGoruntule.TabIndex = 3;
            this.LnkBilgiGoruntule.TabStop = true;
            this.LnkBilgiGoruntule.Text = "Bilgilerimi Görüntüle";
            this.LnkBilgiGoruntule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkBilgiGoruntule_LinkClicked);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.LnkBilgiGoruntule);
            this.groupControl1.Controls.Add(this.LnkBilgiDuzenle);
            this.groupControl1.Controls.Add(this.lblHastaTC);
            this.groupControl1.Controls.Add(this.lblHastaAdSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(12, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(294, 159);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Hasta Bilgileri";
            // 
            // frmHastaDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 573);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmHastaDetayForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Detay Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaDetayForm_FormClosing);
            this.Load += new System.EventHandler(this.frmHataDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbDoktor.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cmbBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtRandevuId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlRandevuGecmisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridRandevuGecmisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlAktifRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridAktifRandevular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraGrid.GridControl gridControlRandevuGecmisi;
        private DevExpress.XtraGrid.Views.Grid.GridView gridRandevuGecmisi;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControlAktifRandevular;
        private DevExpress.XtraGrid.Views.Grid.GridView gridAktifRandevular;
        private DevExpress.XtraEditors.SimpleButton btnRandevuAl;
        private DevExpress.XtraEditors.MemoEdit memoSikayet;
        private DevExpress.XtraEditors.ComboBoxEdit cmbDoktor;
        private DevExpress.XtraEditors.ComboBoxEdit cmbBrans;
        private DevExpress.XtraEditors.TextEdit txtRandevuId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblHastaAdSoyad;
        private DevExpress.XtraEditors.LabelControl lblHastaTC;
        private System.Windows.Forms.LinkLabel LnkBilgiDuzenle;
        private System.Windows.Forms.LinkLabel LnkBilgiGoruntule;
        private DevExpress.XtraEditors.GroupControl groupControl1;
    }
}