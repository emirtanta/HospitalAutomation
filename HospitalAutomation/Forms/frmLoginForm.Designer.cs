namespace HospitalAutomation.Forms
{
    partial class frmLoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoginForm));
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnDoktorGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnHastaGiris = new DevExpress.XtraEditors.SimpleButton();
            this.btnPersonelGiris = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "doctor_male.png");
            this.ımageList1.Images.SetKeyName(1, "patient.png");
            this.ımageList1.Images.SetKeyName(2, "person.png");
            // 
            // btnDoktorGiris
            // 
            this.btnDoktorGiris.ImageOptions.ImageIndex = 0;
            this.btnDoktorGiris.ImageOptions.ImageList = this.ımageList1;
            this.btnDoktorGiris.Location = new System.Drawing.Point(65, 39);
            this.btnDoktorGiris.Name = "btnDoktorGiris";
            this.btnDoktorGiris.Size = new System.Drawing.Size(107, 83);
            this.btnDoktorGiris.TabIndex = 6;
            this.btnDoktorGiris.Text = "Doktor";
            this.btnDoktorGiris.Click += new System.EventHandler(this.btnDoktorGiris_Click);
            // 
            // btnHastaGiris
            // 
            this.btnHastaGiris.ImageOptions.ImageIndex = 1;
            this.btnHastaGiris.ImageOptions.ImageList = this.ımageList1;
            this.btnHastaGiris.Location = new System.Drawing.Point(65, 128);
            this.btnHastaGiris.Name = "btnHastaGiris";
            this.btnHastaGiris.Size = new System.Drawing.Size(107, 83);
            this.btnHastaGiris.TabIndex = 7;
            this.btnHastaGiris.Text = "Hasta";
            this.btnHastaGiris.Click += new System.EventHandler(this.btnHastaGiris_Click);
            // 
            // btnPersonelGiris
            // 
            this.btnPersonelGiris.ImageOptions.ImageIndex = 2;
            this.btnPersonelGiris.ImageOptions.ImageList = this.ımageList1;
            this.btnPersonelGiris.Location = new System.Drawing.Point(65, 217);
            this.btnPersonelGiris.Name = "btnPersonelGiris";
            this.btnPersonelGiris.Size = new System.Drawing.Size(107, 83);
            this.btnPersonelGiris.TabIndex = 8;
            this.btnPersonelGiris.Text = "Personel";
            this.btnPersonelGiris.Click += new System.EventHandler(this.btnPersonelGiris_Click);
            // 
            // frmLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(298, 340);
            this.Controls.Add(this.btnPersonelGiris);
            this.Controls.Add(this.btnHastaGiris);
            this.Controls.Add(this.btnDoktorGiris);
            this.Name = "frmLoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList ımageList1;
        private DevExpress.XtraEditors.SimpleButton btnDoktorGiris;
        private DevExpress.XtraEditors.SimpleButton btnHastaGiris;
        private DevExpress.XtraEditors.SimpleButton btnPersonelGiris;
    }
}