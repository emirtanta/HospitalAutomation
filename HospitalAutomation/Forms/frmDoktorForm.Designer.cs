namespace HospitalAutomation.Forms
{
    partial class frmDoktorForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnDoktorGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoktorEkle = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoktorSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnDoktorListele = new DevExpress.XtraEditors.SimpleButton();
            this.lueDoktorBrans = new DevExpress.XtraEditors.LookUpEdit();
            this.mskTxtDoktorTC = new System.Windows.Forms.MaskedTextBox();
            this.txtDoktorSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorSoyad = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.behaviorManager1 = new DevExpress.Utils.Behaviors.BehaviorManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoktorBrans.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnDoktorGuncelle);
            this.groupControl1.Controls.Add(this.btnDoktorEkle);
            this.groupControl1.Controls.Add(this.btnDoktorSil);
            this.groupControl1.Controls.Add(this.btnDoktorListele);
            this.groupControl1.Controls.Add(this.lueDoktorBrans);
            this.groupControl1.Controls.Add(this.mskTxtDoktorTC);
            this.groupControl1.Controls.Add(this.txtDoktorSifre);
            this.groupControl1.Controls.Add(this.txtDoktorSoyad);
            this.groupControl1.Controls.Add(this.txtDoktorAd);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(361, 331);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Doktor Bilgileri";
            // 
            // btnDoktorGuncelle
            // 
            this.btnDoktorGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorGuncelle.ImageOptions.Image")));
            this.btnDoktorGuncelle.Location = new System.Drawing.Point(195, 292);
            this.btnDoktorGuncelle.Name = "btnDoktorGuncelle";
            this.btnDoktorGuncelle.Size = new System.Drawing.Size(148, 23);
            this.btnDoktorGuncelle.TabIndex = 4;
            this.btnDoktorGuncelle.Text = "Güncelle";
            this.btnDoktorGuncelle.Click += new System.EventHandler(this.btnDoktorGuncelle_Click);
            // 
            // btnDoktorEkle
            // 
            this.btnDoktorEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorEkle.ImageOptions.Image")));
            this.btnDoktorEkle.Location = new System.Drawing.Point(195, 263);
            this.btnDoktorEkle.Name = "btnDoktorEkle";
            this.btnDoktorEkle.Size = new System.Drawing.Size(148, 23);
            this.btnDoktorEkle.TabIndex = 4;
            this.btnDoktorEkle.Text = "Ekle";
            this.btnDoktorEkle.Click += new System.EventHandler(this.btnDoktorEkle_Click);
            // 
            // btnDoktorSil
            // 
            this.btnDoktorSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorSil.ImageOptions.Image")));
            this.btnDoktorSil.Location = new System.Drawing.Point(22, 292);
            this.btnDoktorSil.Name = "btnDoktorSil";
            this.btnDoktorSil.Size = new System.Drawing.Size(148, 23);
            this.btnDoktorSil.TabIndex = 4;
            this.btnDoktorSil.Text = "Sil";
            this.btnDoktorSil.Click += new System.EventHandler(this.btnDoktorSil_Click);
            // 
            // btnDoktorListele
            // 
            this.btnDoktorListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDoktorListele.ImageOptions.Image")));
            this.btnDoktorListele.Location = new System.Drawing.Point(22, 263);
            this.btnDoktorListele.Name = "btnDoktorListele";
            this.btnDoktorListele.Size = new System.Drawing.Size(148, 23);
            this.btnDoktorListele.TabIndex = 4;
            this.btnDoktorListele.Text = "Listele";
            this.btnDoktorListele.Click += new System.EventHandler(this.btnDoktorListele_Click);
            // 
            // lueDoktorBrans
            // 
            this.lueDoktorBrans.Location = new System.Drawing.Point(146, 160);
            this.lueDoktorBrans.Name = "lueDoktorBrans";
            this.lueDoktorBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoktorBrans.Properties.NullText = "Seçiniz";
            this.lueDoktorBrans.Size = new System.Drawing.Size(148, 20);
            this.lueDoktorBrans.TabIndex = 3;
            // 
            // mskTxtDoktorTC
            // 
            this.mskTxtDoktorTC.Location = new System.Drawing.Point(146, 124);
            this.mskTxtDoktorTC.Mask = "00000000000";
            this.mskTxtDoktorTC.Name = "mskTxtDoktorTC";
            this.mskTxtDoktorTC.Size = new System.Drawing.Size(148, 21);
            this.mskTxtDoktorTC.TabIndex = 2;
            this.mskTxtDoktorTC.ValidatingType = typeof(int);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(146, 198);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Properties.UseSystemPasswordChar = true;
            this.txtDoktorSifre.Size = new System.Drawing.Size(148, 20);
            this.txtDoktorSifre.TabIndex = 1;
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(146, 79);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(148, 20);
            this.txtDoktorSoyad.TabIndex = 1;
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(146, 48);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(148, 20);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 132);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(17, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TC:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(38, 201);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Şifre:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(38, 163);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(27, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Branş";
            // 
            // labelControl2
            // 
            this.labelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl2.Location = new System.Drawing.Point(38, 86);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(63, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyad:";
            // 
            // labelControl1
            // 
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Location = new System.Drawing.Point(38, 48);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(63, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(361, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(479, 331);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Doktor Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(475, 306);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.FocusedRowObjectChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowObjectChangedEventHandler(this.gridView1_FocusedRowObjectChanged);
            // 
            // frmDoktorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 331);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoktorForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Paneli";
            this.Load += new System.EventHandler(this.frmDoktorForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoktorBrans.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.behaviorManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnDoktorGuncelle;
        private DevExpress.XtraEditors.SimpleButton btnDoktorEkle;
        private DevExpress.XtraEditors.SimpleButton btnDoktorSil;
        private DevExpress.XtraEditors.SimpleButton btnDoktorListele;
        private DevExpress.XtraEditors.LookUpEdit lueDoktorBrans;
        private System.Windows.Forms.MaskedTextBox mskTxtDoktorTC;
        private DevExpress.XtraEditors.TextEdit txtDoktorSifre;
        private DevExpress.XtraEditors.TextEdit txtDoktorAd;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.Utils.Behaviors.BehaviorManager behaviorManager1;
        private DevExpress.XtraEditors.TextEdit txtDoktorSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}