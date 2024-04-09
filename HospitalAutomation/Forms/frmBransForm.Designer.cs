namespace HospitalAutomation.Forms
{
    partial class frmBransForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBransForm));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnBransListele = new DevExpress.XtraEditors.SimpleButton();
            this.btnBransSil = new DevExpress.XtraEditors.SimpleButton();
            this.btnBransDuzenle = new DevExpress.XtraEditors.SimpleButton();
            this.btnBransEkle = new DevExpress.XtraEditors.SimpleButton();
            this.txtBransAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.txtBransID = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBransAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBransID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnBransListele);
            this.groupControl1.Controls.Add(this.btnBransSil);
            this.groupControl1.Controls.Add(this.btnBransDuzenle);
            this.groupControl1.Controls.Add(this.btnBransEkle);
            this.groupControl1.Controls.Add(this.txtBransAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.txtBransID);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(200, 278);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Branş Bilgileri";
            // 
            // btnBransListele
            // 
            this.btnBransListele.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBransListele.ImageOptions.Image")));
            this.btnBransListele.Location = new System.Drawing.Point(69, 206);
            this.btnBransListele.Name = "btnBransListele";
            this.btnBransListele.Size = new System.Drawing.Size(125, 23);
            this.btnBransListele.TabIndex = 5;
            this.btnBransListele.Text = "Listele";
            this.btnBransListele.Click += new System.EventHandler(this.btnBransListele_Click);
            // 
            // btnBransSil
            // 
            this.btnBransSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBransSil.ImageOptions.Image")));
            this.btnBransSil.Location = new System.Drawing.Point(69, 177);
            this.btnBransSil.Name = "btnBransSil";
            this.btnBransSil.Size = new System.Drawing.Size(125, 23);
            this.btnBransSil.TabIndex = 4;
            this.btnBransSil.Text = "Sil";
            this.btnBransSil.Click += new System.EventHandler(this.btnBransSil_Click);
            // 
            // btnBransDuzenle
            // 
            this.btnBransDuzenle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBransDuzenle.ImageOptions.Image")));
            this.btnBransDuzenle.Location = new System.Drawing.Point(69, 148);
            this.btnBransDuzenle.Name = "btnBransDuzenle";
            this.btnBransDuzenle.Size = new System.Drawing.Size(125, 23);
            this.btnBransDuzenle.TabIndex = 3;
            this.btnBransDuzenle.Text = "Düzenle";
            this.btnBransDuzenle.Click += new System.EventHandler(this.btnBransDuzenle_Click);
            // 
            // btnBransEkle
            // 
            this.btnBransEkle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBransEkle.ImageOptions.Image")));
            this.btnBransEkle.Location = new System.Drawing.Point(69, 119);
            this.btnBransEkle.Name = "btnBransEkle";
            this.btnBransEkle.Size = new System.Drawing.Size(125, 23);
            this.btnBransEkle.TabIndex = 2;
            this.btnBransEkle.Text = "Ekle";
            this.btnBransEkle.Click += new System.EventHandler(this.btnBransEkle_Click);
            // 
            // txtBransAd
            // 
            this.txtBransAd.Location = new System.Drawing.Point(69, 83);
            this.txtBransAd.Name = "txtBransAd";
            this.txtBransAd.Size = new System.Drawing.Size(125, 20);
            this.txtBransAd.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(14, 83);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(49, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Branş Adı:";
            // 
            // txtBransID
            // 
            this.txtBransID.Enabled = false;
            this.txtBransID.Location = new System.Drawing.Point(69, 57);
            this.txtBransID.Name = "txtBransID";
            this.txtBransID.Size = new System.Drawing.Size(125, 20);
            this.txtBransID.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(14, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(47, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Branş No:";
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.gridControl1);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(200, 0);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(300, 278);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Branş Listesi";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(2, 23);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(296, 253);
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
            // frmBransForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 278);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBransForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Branş Formu";
            this.Load += new System.EventHandler(this.frmBransForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtBransAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtBransID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnBransListele;
        private DevExpress.XtraEditors.SimpleButton btnBransSil;
        private DevExpress.XtraEditors.SimpleButton btnBransDuzenle;
        private DevExpress.XtraEditors.SimpleButton btnBransEkle;
        private DevExpress.XtraEditors.TextEdit txtBransAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtBransID;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}