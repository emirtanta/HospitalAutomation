namespace HospitalAutomation.Forms
{
    partial class frmDoktorGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDoktorGirisForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnDoktorGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtDoktorSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtDoktorTC = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(27, 57);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Tc Kimlik No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(27, 100);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Şifre:";
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnDoktorGiris.Location = new System.Drawing.Point(185, 140);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(75, 23);
            this.btnDoktorGiris.TabIndex = 4;
            this.btnDoktorGiris.Text = "Giriş";
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // txtDoktorSifre
            // 
            this.txtDoktorSifre.Location = new System.Drawing.Point(113, 97);
            this.txtDoktorSifre.Name = "txtDoktorSifre";
            this.txtDoktorSifre.Properties.UseSystemPasswordChar = true;
            this.txtDoktorSifre.Size = new System.Drawing.Size(147, 20);
            this.txtDoktorSifre.TabIndex = 3;
            // 
            // txtDoktorTC
            // 
            this.txtDoktorTC.Location = new System.Drawing.Point(113, 54);
            this.txtDoktorTC.Name = "txtDoktorTC";
            this.txtDoktorTC.Size = new System.Drawing.Size(147, 20);
            this.txtDoktorTC.TabIndex = 1;
            // 
            // frmDoktorGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 205);
            this.Controls.Add(this.btnDoktorGiris);
            this.Controls.Add(this.txtDoktorSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtDoktorTC);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmDoktorGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doktor Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDoktorGirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDoktorTC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtDoktorTC;
        private DevExpress.XtraEditors.TextEdit txtDoktorSifre;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton btnDoktorGiris;
    }
}