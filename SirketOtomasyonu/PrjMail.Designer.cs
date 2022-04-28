namespace SirketOtomasyonu
{
    partial class PrjMail
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrjMail));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.Btn_Gonder = new DevExpress.XtraEditors.SimpleButton();
            this.RchMesaj = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtKonu = new System.Windows.Forms.TextBox();
            this.TxtMail = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Btn_Gonder);
            this.panel1.Controls.Add(this.RchMesaj);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.TxtKonu);
            this.panel1.Controls.Add(this.TxtMail);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(535, 509);
            this.panel1.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 24.25F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(177, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(296, 38);
            this.label4.TabIndex = 4;
            this.label4.Text = "MAİL GÖNDERME";
            // 
            // Btn_Gonder
            // 
            this.Btn_Gonder.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F);
            this.Btn_Gonder.Appearance.Options.UseFont = true;
            this.Btn_Gonder.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.Btn_Gonder.Location = new System.Drawing.Point(242, 411);
            this.Btn_Gonder.Name = "Btn_Gonder";
            this.Btn_Gonder.Size = new System.Drawing.Size(146, 41);
            this.Btn_Gonder.TabIndex = 3;
            this.Btn_Gonder.Text = "Gönder";
            this.Btn_Gonder.Click += new System.EventHandler(this.Btn_Gonder_Click);
            // 
            // RchMesaj
            // 
            this.RchMesaj.Location = new System.Drawing.Point(211, 221);
            this.RchMesaj.Name = "RchMesaj";
            this.RchMesaj.Size = new System.Drawing.Size(219, 148);
            this.RchMesaj.TabIndex = 2;
            this.RchMesaj.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(144, 221);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mesaj:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(144, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Konu:";
            // 
            // TxtKonu
            // 
            this.TxtKonu.BackColor = System.Drawing.SystemColors.Window;
            this.TxtKonu.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TxtKonu.Location = new System.Drawing.Point(211, 176);
            this.TxtKonu.Name = "TxtKonu";
            this.TxtKonu.Size = new System.Drawing.Size(219, 24);
            this.TxtKonu.TabIndex = 1;
            // 
            // TxtMail
            // 
            this.TxtMail.BackColor = System.Drawing.SystemColors.Window;
            this.TxtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.TxtMail.Location = new System.Drawing.Point(211, 126);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Size = new System.Drawing.Size(219, 24);
            this.TxtMail.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(107, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mail Adresi:";
            // 
            // PrjMail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(535, 509);
            this.Controls.Add(this.panel1);
            this.Name = "PrjMail";
            this.Text = "PrjMail";
            this.Load += new System.EventHandler(this.PrjMail_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RichTextBox RchMesaj;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtKonu;
        private System.Windows.Forms.TextBox TxtMail;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.SimpleButton Btn_Gonder;
        private System.Windows.Forms.Label label4;
    }
}