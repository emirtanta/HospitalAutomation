namespace HospitalAutomation.Forms
{
    partial class frmHastaGirisForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHastaGirisForm));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.btnHastaGiris = new DevExpress.XtraEditors.SimpleButton();
            this.txtHastaSifre = new DevExpress.XtraEditors.TextEdit();
            this.txtHastaTC = new DevExpress.XtraEditors.TextEdit();
            this.lnkUyeOl = new DevExpress.XtraEditors.HyperlinkLabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaTC.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(30, 32);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(61, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "TC Kimlik No:";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(30, 68);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(26, 13);
            this.labelControl2.TabIndex = 0;
            this.labelControl2.Text = "Şifre:";
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnHastaGiris.ImageOptions.Image")));
            this.btnHastaGiris.Location = new System.Drawing.Point(177, 91);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(75, 23);
            this.btnHastaGiris.TabIndex = 2;
            this.btnHastaGiris.Text = "Giriş";
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // txtHastaSifre
            // 
            this.txtHastaSifre.Location = new System.Drawing.Point(120, 65);
            this.txtHastaSifre.Name = "txtHastaSifre";
            this.txtHastaSifre.Properties.UseSystemPasswordChar = true;
            this.txtHastaSifre.Size = new System.Drawing.Size(138, 20);
            this.txtHastaSifre.TabIndex = 1;
            // 
            // txtHastaTC
            // 
            this.txtHastaTC.Location = new System.Drawing.Point(120, 29);
            this.txtHastaTC.Name = "txtHastaTC";
            this.txtHastaTC.Size = new System.Drawing.Size(138, 20);
            this.txtHastaTC.TabIndex = 1;
            // 
            // lnkUyeOl
            // 
            this.lnkUyeOl.Appearance.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lnkUyeOl.Appearance.Options.UseFont = true;
            this.lnkUyeOl.LineColor = System.Drawing.Color.Blue;
            this.lnkUyeOl.Location = new System.Drawing.Point(177, 131);
            this.lnkUyeOl.Name = "lnkUyeOl";
            this.lnkUyeOl.Size = new System.Drawing.Size(37, 16);
            this.lnkUyeOl.TabIndex = 3;
            this.lnkUyeOl.Text = "Üye Ol";
            // 
            // frmHastaGirisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 205);
            this.Controls.Add(this.lnkUyeOl);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.txtHastaSifre);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.txtHastaTC);
            this.Controls.Add(this.labelControl1);
            this.Name = "frmHastaGirisForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hasta Giriş Paneli";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHastaGirisForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaSifre.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHastaTC.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit txtHastaTC;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit txtHastaSifre;
        private DevExpress.XtraEditors.SimpleButton btnHastaGiris;
        private DevExpress.XtraEditors.HyperlinkLabelControl lnkUyeOl;
    }
}