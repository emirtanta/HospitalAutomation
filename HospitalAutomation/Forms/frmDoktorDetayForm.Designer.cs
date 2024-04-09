namespace HospitalAutomation.Forms
{
    partial class frmDoktorDetayForm
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.btnCikis = new DevExpress.XtraEditors.SimpleButton();
            this.btnDuyurular = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lnkBilgiGuncelle = new System.Windows.Forms.LinkLabel();
            this.lnkBilgiGoruntule = new System.Windows.Forms.LinkLabel();
            this.lblTC = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.lblAdSoyad = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.memoSikayet = new DevExpress.XtraEditors.MemoEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.gridControl1);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Right;
            this.groupControl3.Location = new System.Drawing.Point(218, 0);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(600, 543);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Randevu Geçmişi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(596, 518);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.DoubleClick += new System.EventHandler(this.gridView1_DoubleClick);
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.groupControl2);
            this.groupControl4.Controls.Add(this.simpleButton2);
            this.groupControl4.Controls.Add(this.simpleButton1);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl4.Location = new System.Drawing.Point(0, 443);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(218, 100);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.Text = "Hızlı Erişim";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.btnCikis);
            this.groupControl2.Controls.Add(this.btnDuyurular);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl2.Location = new System.Drawing.Point(2, -2);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(214, 100);
            this.groupControl2.TabIndex = 3;
            this.groupControl2.Text = "Hızlı Erişim";
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(47, 67);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(75, 23);
            this.btnCikis.TabIndex = 1;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnDuyurular
            // 
            this.btnDuyurular.Location = new System.Drawing.Point(45, 29);
            this.btnDuyurular.Name = "btnDuyurular";
            this.btnDuyurular.Size = new System.Drawing.Size(75, 23);
            this.btnDuyurular.TabIndex = 0;
            this.btnDuyurular.Text = "Duyurular";
            this.btnDuyurular.Click += new System.EventHandler(this.btnDuyurular_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(47, 56);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(75, 23);
            this.simpleButton2.TabIndex = 1;
            this.simpleButton2.Text = "Çıkış";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(47, 27);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Duyurular";
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.lnkBilgiGuncelle);
            this.groupControl1.Controls.Add(this.lnkBilgiGoruntule);
            this.groupControl1.Controls.Add(this.lblTC);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.lblAdSoyad);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(2, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(202, 131);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Doktor Bilgileri";
            // 
            // lnkBilgiGuncelle
            // 
            this.lnkBilgiGuncelle.AutoSize = true;
            this.lnkBilgiGuncelle.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkBilgiGuncelle.Location = new System.Drawing.Point(105, 93);
            this.lnkBilgiGuncelle.Name = "lnkBilgiGuncelle";
            this.lnkBilgiGuncelle.Size = new System.Drawing.Size(82, 16);
            this.lnkBilgiGuncelle.TabIndex = 2;
            this.lnkBilgiGuncelle.TabStop = true;
            this.lnkBilgiGuncelle.Text = "Bilgi Güncelle";
            this.lnkBilgiGuncelle.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiGuncelle_LinkClicked);
            // 
            // lnkBilgiGoruntule
            // 
            this.lnkBilgiGoruntule.AutoSize = true;
            this.lnkBilgiGoruntule.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkBilgiGoruntule.Location = new System.Drawing.Point(10, 93);
            this.lnkBilgiGoruntule.Name = "lnkBilgiGoruntule";
            this.lnkBilgiGoruntule.Size = new System.Drawing.Size(89, 16);
            this.lnkBilgiGoruntule.TabIndex = 2;
            this.lnkBilgiGoruntule.TabStop = true;
            this.lnkBilgiGoruntule.Text = "Bilgi Görüntüle";
            this.lnkBilgiGoruntule.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lnkBilgiGoruntule_LinkClicked);
            // 
            // lblTC
            // 
            this.lblTC.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblTC.Appearance.Options.UseFont = true;
            this.lblTC.Location = new System.Drawing.Point(89, 46);
            this.lblTC.Name = "lblTC";
            this.lblTC.Size = new System.Drawing.Size(77, 16);
            this.lblTC.TabIndex = 0;
            this.lblTC.Text = "00000000000";
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(6, 46);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(77, 16);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "TC Kimlik No:";
            // 
            // lblAdSoyad
            // 
            this.lblAdSoyad.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdSoyad.Appearance.Options.UseFont = true;
            this.lblAdSoyad.Location = new System.Drawing.Point(89, 27);
            this.lblAdSoyad.Name = "lblAdSoyad";
            this.lblAdSoyad.Size = new System.Drawing.Size(75, 16);
            this.lblAdSoyad.TabIndex = 0;
            this.lblAdSoyad.Text = "labelControl1";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(6, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 16);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad Soyad:";
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.memoSikayet);
            this.groupControl5.Location = new System.Drawing.Point(2, 137);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(202, 298);
            this.groupControl5.TabIndex = 0;
            this.groupControl5.Text = "Randevu Bilgileri";
            // 
            // memoSikayet
            // 
            this.memoSikayet.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoSikayet.Location = new System.Drawing.Point(2, 23);
            this.memoSikayet.Name = "memoSikayet";
            this.memoSikayet.Size = new System.Drawing.Size(198, 273);
            this.memoSikayet.TabIndex = 0;
            // 
            // frmDoktorDetayForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(818, 543);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl5);
            this.Controls.Add(this.groupControl1);
            this.Name = "frmDoktorDetayForm";
            this.Text = "Doktor Detay Formu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoktorDetayForm_FormClosing);
            this.Load += new System.EventHandler(this.frmDoktorDetayForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.memoSikayet.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.SimpleButton btnCikis;
        private DevExpress.XtraEditors.SimpleButton btnDuyurular;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl lblTC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl lblAdSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.MemoEdit memoSikayet;
        private System.Windows.Forms.LinkLabel lnkBilgiGuncelle;
        private System.Windows.Forms.LinkLabel lnkBilgiGoruntule;
    }
}