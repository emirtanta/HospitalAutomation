namespace HospitalAutomation.Forms
{
    partial class frmDoktorDuzenleForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorDuzenleForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoktorAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoktorSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoktorTC = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.txtDoktorSifre = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.lueDoktorBrans = new DevExpress.XtraEditors.LookUpEdit();
            this.btnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTC.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoktorBrans.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnGuncelle);
            this.groupControl1.Controls.Add(this.lueDoktorBrans);
            this.groupControl1.Controls.Add(this.txtDoktorSifre);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.txtDoktorTC);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.txtDoktorSoyad);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtDoktorAd);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(287, 254);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Doktor Bilgileri";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(15, 38);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Ad:";
            // 
            // txtDoktorAd
            // 
            this.txtDoktorAd.Location = new System.Drawing.Point(101, 38);
            this.txtDoktorAd.Name = "txtDoktorAd";
            this.txtDoktorAd.Size = new System.Drawing.Size(170, 20);
            this.txtDoktorAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(15, 64);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(34, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Soyad:";
            // 
            // txtDoktorSoyad
            // 
            this.txtDoktorSoyad.Location = new System.Drawing.Point(101, 64);
            this.txtDoktorSoyad.Name = "txtDoktorSoyad";
            this.txtDoktorSoyad.Size = new System.Drawing.Size(170, 20);
            this.txtDoktorSoyad.TabIndex = 1;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(15, 90);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(61, 13);
            this.labelControl3.TabIndex = 0;
            this.labelControl3.Text = "TC Kimlik No:";
            // 
            // txtDoktorTC
            // 
            this.txtDoktorTC.Location = new System.Drawing.Point(101, 90);
            this.txtDoktorTC.Name = "txtDoktorTC";
            this.txtDoktorTC.Size = new System.Drawing.Size(170, 20);
            this.txtDoktorTC.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(15, 155);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(26, 13);
            this.labelControl4.TabIndex = 0;
            this.labelControl4.Text = "Şifre:";
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(101, 155);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Properties.UseSystemPasswordChar = true;
            this.txtDoktorSifre.Size = new System.Drawing.Size(170, 20);
            this.txtDoktorSifre.TabIndex = 1;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(15, 120);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(31, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Branş:";
            // 
            // lueDoktorBrans
            // 
            this.lueDoktorBrans.Location = new System.Drawing.Point(101, 120);
            this.lueDoktorBrans.Name = "lueDoktorBrans";
            this.lueDoktorBrans.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lueDoktorBrans.Properties.NullText = "Seçiniz";
            this.lueDoktorBrans.Size = new System.Drawing.Size(170, 20);
            this.lueDoktorBrans.TabIndex = 2;
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnGuncelle.Appearance.Options.UseForeColor = true;
            this.btnGuncelle.AppearancePressed.BackColor = System.Drawing.Color.DarkBlue;
            this.btnGuncelle.AppearancePressed.Options.UseBackColor = true;
            this.btnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnGuncelle.Location = new System.Drawing.Point(196, 192);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(75, 42);
            this.btnGuncelle.TabIndex = 3;
            this.btnGuncelle.Text = "Güncelle";
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // frmDoktorDuzenleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(287, 254);
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDoktorDuzenleForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Düzenleme Kartı";
            this.Load += new System.EventHandler(this.frmDoktorDuzenleForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTC.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lueDoktorBrans.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LookUpEdit lueDoktorBrans;
        private DevExpress.XtraEditors.TextEdit txtDoktorSifre;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit txtDoktorTC;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit txtDoktorSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtDoktorAd;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton btnGuncelle;
    }
}