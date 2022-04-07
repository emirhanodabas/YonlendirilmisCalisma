namespace SirketOtomasyonu
{
    partial class PrjPersoneller
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrjPersoneller));
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.BtnGuncelle = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.cmbilce = new System.Windows.Forms.ComboBox();
            this.cmbil = new System.Windows.Forms.ComboBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.TxtMaas = new DevExpress.XtraEditors.TextEdit();
            this.BtnSil = new DevExpress.XtraEditors.SimpleButton();
            this.MskTC = new System.Windows.Forms.MaskedTextBox();
            this.BtnKaydet = new DevExpress.XtraEditors.SimpleButton();
            this.MskTelefon1 = new System.Windows.Forms.MaskedTextBox();
            this.RchAdres = new System.Windows.Forms.RichTextBox();
            this.TxtMail = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.TxtGorev = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.TxtSoyad = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.TxtAd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.TxtId = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.dbo_SirketOtomasyonDataSet = new SirketOtomasyonu.Dbo_SirketOtomasyonDataSet();
            this.illerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.illerTableAdapter = new SirketOtomasyonu.Dbo_SirketOtomasyonDataSetTableAdapters.illerTableAdapter();
            this.fKilcelerillerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ilcelerTableAdapter = new SirketOtomasyonu.Dbo_SirketOtomasyonDataSetTableAdapters.ilcelerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaas.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(0, 1);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1584, 954);
            this.gridControl1.TabIndex = 4;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // BtnGuncelle
            // 
            this.BtnGuncelle.Appearance.Font = new System.Drawing.Font("Tahoma", 11F);
            this.BtnGuncelle.Appearance.Options.UseFont = true;
            this.BtnGuncelle.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnGuncelle.ImageOptions.Image")));
            this.BtnGuncelle.Location = new System.Drawing.Point(119, 793);
            this.BtnGuncelle.Name = "BtnGuncelle";
            this.BtnGuncelle.Size = new System.Drawing.Size(156, 37);
            this.BtnGuncelle.TabIndex = 13;
            this.BtnGuncelle.Text = "GÜNCELLE";
            this.BtnGuncelle.Click += new System.EventHandler(this.BtnGuncelle_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.cmbilce);
            this.groupControl1.Controls.Add(this.cmbil);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.TxtMaas);
            this.groupControl1.Controls.Add(this.BtnGuncelle);
            this.groupControl1.Controls.Add(this.BtnSil);
            this.groupControl1.Controls.Add(this.MskTC);
            this.groupControl1.Controls.Add(this.BtnKaydet);
            this.groupControl1.Controls.Add(this.MskTelefon1);
            this.groupControl1.Controls.Add(this.RchAdres);
            this.groupControl1.Controls.Add(this.TxtMail);
            this.groupControl1.Controls.Add(this.labelControl11);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl7);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.TxtGorev);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.TxtSoyad);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.TxtAd);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.TxtId);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(1590, 1);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(322, 954);
            this.groupControl1.TabIndex = 5;
            // 
            // cmbilce
            // 
            this.cmbilce.DataSource = this.fKilcelerillerBindingSource;
            this.cmbilce.DisplayMember = "ilce";
            this.cmbilce.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbilce.FormattingEnabled = true;
            this.cmbilce.Location = new System.Drawing.Point(119, 362);
            this.cmbilce.Name = "cmbilce";
            this.cmbilce.Size = new System.Drawing.Size(156, 26);
            this.cmbilce.TabIndex = 17;
            // 
            // cmbil
            // 
            this.cmbil.DataSource = this.illerBindingSource;
            this.cmbil.DisplayMember = "sehir";
            this.cmbil.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbil.FormattingEnabled = true;
            this.cmbil.Location = new System.Drawing.Point(119, 314);
            this.cmbil.Name = "cmbil";
            this.cmbil.Size = new System.Drawing.Size(156, 26);
            this.cmbil.TabIndex = 16;
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl4.Appearance.Options.UseFont = true;
            this.labelControl4.Location = new System.Drawing.Point(64, 410);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 19);
            this.labelControl4.TabIndex = 15;
            this.labelControl4.Text = "MAAŞ:";
            // 
            // TxtMaas
            // 
            this.TxtMaas.Location = new System.Drawing.Point(119, 407);
            this.TxtMaas.Name = "TxtMaas";
            this.TxtMaas.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMaas.Properties.Appearance.Options.UseFont = true;
            this.TxtMaas.Size = new System.Drawing.Size(156, 26);
            this.TxtMaas.TabIndex = 14;
            // 
            // BtnSil
            // 
            this.BtnSil.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnSil.Appearance.Options.UseFont = true;
            this.BtnSil.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnSil.ImageOptions.Image")));
            this.BtnSil.Location = new System.Drawing.Point(119, 734);
            this.BtnSil.Name = "BtnSil";
            this.BtnSil.Size = new System.Drawing.Size(156, 37);
            this.BtnSil.TabIndex = 10;
            this.BtnSil.Text = "SİL";
            this.BtnSil.Click += new System.EventHandler(this.BtnSil_Click);
            // 
            // MskTC
            // 
            this.MskTC.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTC.Location = new System.Drawing.Point(119, 223);
            this.MskTC.Mask = "00000000000";
            this.MskTC.Name = "MskTC";
            this.MskTC.Size = new System.Drawing.Size(156, 27);
            this.MskTC.TabIndex = 7;
            this.MskTC.ValidatingType = typeof(int);
            // 
            // BtnKaydet
            // 
            this.BtnKaydet.Appearance.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.BtnKaydet.Appearance.Options.UseFont = true;
            this.BtnKaydet.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("BtnKaydet.ImageOptions.Image")));
            this.BtnKaydet.Location = new System.Drawing.Point(119, 680);
            this.BtnKaydet.Name = "BtnKaydet";
            this.BtnKaydet.Size = new System.Drawing.Size(156, 37);
            this.BtnKaydet.TabIndex = 9;
            this.BtnKaydet.Text = "KAYDET";
            this.BtnKaydet.Click += new System.EventHandler(this.BtnKaydet_Click);
            // 
            // MskTelefon1
            // 
            this.MskTelefon1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MskTelefon1.Location = new System.Drawing.Point(119, 176);
            this.MskTelefon1.Mask = "(999) 000-0000";
            this.MskTelefon1.Name = "MskTelefon1";
            this.MskTelefon1.Size = new System.Drawing.Size(156, 27);
            this.MskTelefon1.TabIndex = 7;
            // 
            // RchAdres
            // 
            this.RchAdres.Location = new System.Drawing.Point(119, 517);
            this.RchAdres.Name = "RchAdres";
            this.RchAdres.Size = new System.Drawing.Size(156, 129);
            this.RchAdres.TabIndex = 8;
            this.RchAdres.Text = "";
            // 
            // TxtMail
            // 
            this.TxtMail.Location = new System.Drawing.Point(119, 269);
            this.TxtMail.Name = "TxtMail";
            this.TxtMail.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtMail.Properties.Appearance.Options.UseFont = true;
            this.TxtMail.Size = new System.Drawing.Size(156, 26);
            this.TxtMail.TabIndex = 6;
            // 
            // labelControl11
            // 
            this.labelControl11.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl11.Appearance.Options.UseFont = true;
            this.labelControl11.Location = new System.Drawing.Point(55, 457);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(58, 19);
            this.labelControl11.TabIndex = 5;
            this.labelControl11.Text = "GÖREV:";
            // 
            // labelControl10
            // 
            this.labelControl10.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl10.Appearance.Options.UseFont = true;
            this.labelControl10.Location = new System.Drawing.Point(53, 517);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(56, 19);
            this.labelControl10.TabIndex = 5;
            this.labelControl10.Text = "ADRES:";
            // 
            // labelControl8
            // 
            this.labelControl8.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl8.Appearance.Options.UseFont = true;
            this.labelControl8.Location = new System.Drawing.Point(74, 362);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(39, 19);
            this.labelControl8.TabIndex = 5;
            this.labelControl8.Text = "İLÇE:";
            // 
            // labelControl7
            // 
            this.labelControl7.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl7.Appearance.Options.UseFont = true;
            this.labelControl7.Location = new System.Drawing.Point(85, 314);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(20, 19);
            this.labelControl7.TabIndex = 5;
            this.labelControl7.Text = "İL:";
            // 
            // labelControl6
            // 
            this.labelControl6.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl6.Appearance.Options.UseFont = true;
            this.labelControl6.Location = new System.Drawing.Point(70, 269);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(43, 19);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "MAİL:";
            // 
            // TxtGorev
            // 
            this.TxtGorev.Location = new System.Drawing.Point(119, 454);
            this.TxtGorev.Name = "TxtGorev";
            this.TxtGorev.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtGorev.Properties.Appearance.Options.UseFont = true;
            this.TxtGorev.Size = new System.Drawing.Size(156, 26);
            this.TxtGorev.TabIndex = 3;
            // 
            // labelControl5
            // 
            this.labelControl5.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl5.Appearance.Options.UseFont = true;
            this.labelControl5.Location = new System.Drawing.Point(87, 224);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(26, 19);
            this.labelControl5.TabIndex = 2;
            this.labelControl5.Text = "TC:";
            // 
            // TxtSoyad
            // 
            this.TxtSoyad.Location = new System.Drawing.Point(119, 131);
            this.TxtSoyad.Name = "TxtSoyad";
            this.TxtSoyad.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtSoyad.Properties.Appearance.Options.UseFont = true;
            this.TxtSoyad.Size = new System.Drawing.Size(156, 26);
            this.TxtSoyad.TabIndex = 3;
            // 
            // labelControl9
            // 
            this.labelControl9.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl9.Appearance.Options.UseFont = true;
            this.labelControl9.Location = new System.Drawing.Point(55, 134);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(59, 19);
            this.labelControl9.TabIndex = 2;
            this.labelControl9.Text = "SOYAD:";
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl3.Appearance.Options.UseFont = true;
            this.labelControl3.Location = new System.Drawing.Point(31, 179);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(82, 19);
            this.labelControl3.TabIndex = 2;
            this.labelControl3.Text = "TELEFON1:";
            // 
            // TxtAd
            // 
            this.TxtAd.Location = new System.Drawing.Point(119, 86);
            this.TxtAd.Name = "TxtAd";
            this.TxtAd.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtAd.Properties.Appearance.Options.UseFont = true;
            this.TxtAd.Size = new System.Drawing.Size(156, 26);
            this.TxtAd.TabIndex = 3;
            // 
            // labelControl2
            // 
            this.labelControl2.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl2.Appearance.Options.UseFont = true;
            this.labelControl2.Location = new System.Drawing.Point(85, 89);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(28, 19);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "AD:";
            // 
            // TxtId
            // 
            this.TxtId.Location = new System.Drawing.Point(119, 41);
            this.TxtId.Name = "TxtId";
            this.TxtId.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TxtId.Properties.Appearance.Options.UseFont = true;
            this.TxtId.Size = new System.Drawing.Size(156, 26);
            this.TxtId.TabIndex = 1;
            this.TxtId.EditValueChanged += new System.EventHandler(this.TxtId_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelControl1.Appearance.Options.UseFont = true;
            this.labelControl1.Location = new System.Drawing.Point(90, 44);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(23, 19);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "ID:";
            // 
            // dbo_SirketOtomasyonDataSet
            // 
            this.dbo_SirketOtomasyonDataSet.DataSetName = "Dbo_SirketOtomasyonDataSet";
            this.dbo_SirketOtomasyonDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // illerBindingSource
            // 
            this.illerBindingSource.DataMember = "iller";
            this.illerBindingSource.DataSource = this.dbo_SirketOtomasyonDataSet;
            // 
            // illerTableAdapter
            // 
            this.illerTableAdapter.ClearBeforeFill = true;
            // 
            // fKilcelerillerBindingSource
            // 
            this.fKilcelerillerBindingSource.DataMember = "FK_ilceler_iller";
            this.fKilcelerillerBindingSource.DataSource = this.illerBindingSource;
            // 
            // ilcelerTableAdapter
            // 
            this.ilcelerTableAdapter.ClearBeforeFill = true;
            // 
            // PrjPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.groupControl1);
            this.Name = "PrjPersoneller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.FrmPersoneller_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMaas.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtMail.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtGorev.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtSoyad.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtAd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TxtId.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.illerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fKilcelerillerBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SimpleButton BtnGuncelle;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton BtnSil;
        private System.Windows.Forms.MaskedTextBox MskTC;
        private DevExpress.XtraEditors.SimpleButton BtnKaydet;
        private System.Windows.Forms.MaskedTextBox MskTelefon1;
        private System.Windows.Forms.RichTextBox RchAdres;
        private DevExpress.XtraEditors.TextEdit TxtMail;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit TxtGorev;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit TxtSoyad;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit TxtAd;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit TxtId;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit TxtMaas;
        private System.Windows.Forms.ComboBox cmbil;
        private System.Windows.Forms.ComboBox cmbilce;
        private Dbo_SirketOtomasyonDataSet dbo_SirketOtomasyonDataSet;
        private System.Windows.Forms.BindingSource illerBindingSource;
        private Dbo_SirketOtomasyonDataSetTableAdapters.illerTableAdapter illerTableAdapter;
        private System.Windows.Forms.BindingSource fKilcelerillerBindingSource;
        private Dbo_SirketOtomasyonDataSetTableAdapters.ilcelerTableAdapter ilcelerTableAdapter;
    }
}