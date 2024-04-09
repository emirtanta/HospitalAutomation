namespace HospitalAutomation.Forms
{
    partial class frmPersonelGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPersonelGirisForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtPersonelSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtPersonelTC = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(32, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TC Kimlik No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(32, 59);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnPersonelGiris.Location = new System.Drawing.Point(185, 96);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(75, 23);
            this.btnPersonelGiris.TabIndex = 2;
            this.btnPersonelGiris.Text = "Giriş";
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // txtPersonelSifre
            // 
            this.txtPersonelSifre.Location = new System.Drawing.Point(110, 57);
            this.txtPersonelSifre.Name = "txtPersonelSifre";
            this.txtPersonelSifre.Properties.UseSystemPasswordChar = true;
            this.txtPersonelSifre.Size = new System.Drawing.Size(150, 20);
            this.txtPersonelSifre.TabIndex = 1;
            // 
            // txtPersonelTC
            // 
            this.txtPersonelTC.EditValue = "00000000000";
            this.txtPersonelTC.Location = new System.Drawing.Point(110, 24);
            this.txtPersonelTC.Name = "txtPersonelTC";
            this.txtPersonelTC.Properties.MaskSettings.Set("mask", "d");
            this.txtPersonelTC.Properties.MaskSettings.Set("MaskManagerSignature", "allowNull=False");
            this.txtPersonelTC.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.txtPersonelTC.Size = new System.Drawing.Size(150, 20);
            this.txtPersonelTC.TabIndex = 1;
            // 
            // frmPersonelGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 205);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.txtPersonelSifre);
            this.Controls.Add(this.txtPersonelTC);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPersonelGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Personel Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPersonelGirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtPersonelTC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtPersonelTC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtPersonelSifre;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGiris;
    }
}