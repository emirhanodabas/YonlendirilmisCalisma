namespace SirketOtomasyonu
{
    partial class PrjRehber
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
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlMusteri = new DevExpress.XtraGrid.GridControl();
            this.musteriBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_SirketOtomasyonMusteriBilgisi = new SirketOtomasyonu.Dbo_SirketOtomasyonMusteriBilgisi();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlFirma = new DevExpress.XtraGrid.GridControl();
            this.firmaBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_SirketOtomasyonFirmaBilgi = new SirketOtomasyonu.Dbo_SirketOtomasyonFirmaBilgi();
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAD2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colYETKILIADSOYAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON21 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFAX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraTabPage3 = new DevExpress.XtraTab.XtraTabPage();
            this.gridControlPersonel = new DevExpress.XtraGrid.GridControl();
            this.personelBilgiBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbo_SirketOtomasyonPersonelBilgi = new SirketOtomasyonu.Dbo_SirketOtomasyonPersonelBilgi();
            this.gridView3 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSOYAD1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTELEFON1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMAIL1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.musteriBilgiTableAdapter = new SirketOtomasyonu.Dbo_SirketOtomasyonMusteriBilgisiTableAdapters.MusteriBilgiTableAdapter();
            this.personelBilgiTableAdapter = new SirketOtomasyonu.Dbo_SirketOtomasyonPersonelBilgiTableAdapters.PersonelBilgiTableAdapter();
            this.firmaBilgiTableAdapter = new SirketOtomasyonu.Dbo_SirketOtomasyonFirmaBilgiTableAdapters.FirmaBilgiTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonMusteriBilgisi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.xtraTabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFirma)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonFirmaBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            this.xtraTabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonPersonelBilgi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraTabControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage1;
            this.xtraTabControl1.Size = new System.Drawing.Size(1924, 1061);
            this.xtraTabControl1.TabIndex = 0;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2,
            this.xtraTabPage3});
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.gridControlMusteri);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(1922, 1036);
            this.xtraTabPage1.Text = "Müşteriler";
            // 
            // gridControlMusteri
            // 
            this.gridControlMusteri.DataSource = this.musteriBilgiBindingSource;
            this.gridControlMusteri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlMusteri.Location = new System.Drawing.Point(0, 0);
            this.gridControlMusteri.MainView = this.gridView1;
            this.gridControlMusteri.Name = "gridControlMusteri";
            this.gridControlMusteri.Size = new System.Drawing.Size(1922, 1036);
            this.gridControlMusteri.TabIndex = 7;
            this.gridControlMusteri.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.gridControlMusteri.DoubleClick += new System.EventHandler(this.gridControlMusteri_DoubleClick);
            // 
            // musteriBilgiBindingSource
            // 
            this.musteriBilgiBindingSource.DataMember = "MusteriBilgi";
            this.musteriBilgiBindingSource.DataSource = this.dbo_SirketOtomasyonMusteriBilgisi;
            // 
            // dbo_SirketOtomasyonMusteriBilgisi
            // 
            this.dbo_SirketOtomasyonMusteriBilgisi.DataSetName = "Dbo_SirketOtomasyonMusteriBilgisi";
            this.dbo_SirketOtomasyonMusteriBilgisi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAD,
            this.colSOYAD,
            this.colTELEFON,
            this.colTELEFON2,
            this.colMAIL});
            this.gridView1.GridControl = this.gridControlMusteri;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colAD
            // 
            this.colAD.FieldName = "AD";
            this.colAD.Name = "colAD";
            this.colAD.Visible = true;
            this.colAD.VisibleIndex = 0;
            // 
            // colSOYAD
            // 
            this.colSOYAD.FieldName = "SOYAD";
            this.colSOYAD.Name = "colSOYAD";
            this.colSOYAD.Visible = true;
            this.colSOYAD.VisibleIndex = 1;
            // 
            // colTELEFON
            // 
            this.colTELEFON.FieldName = "TELEFON";
            this.colTELEFON.Name = "colTELEFON";
            this.colTELEFON.Visible = true;
            this.colTELEFON.VisibleIndex = 2;
            // 
            // colTELEFON2
            // 
            this.colTELEFON2.FieldName = "TELEFON2";
            this.colTELEFON2.Name = "colTELEFON2";
            this.colTELEFON2.Visible = true;
            this.colTELEFON2.VisibleIndex = 3;
            // 
            // colMAIL
            // 
            this.colMAIL.FieldName = "MAIL";
            this.colMAIL.Name = "colMAIL";
            this.colMAIL.Visible = true;
            this.colMAIL.VisibleIndex = 4;
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.gridControlFirma);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(1922, 1036);
            this.xtraTabPage2.Text = "Firmalar";
            // 
            // gridControlFirma
            // 
            this.gridControlFirma.DataSource = this.firmaBilgiBindingSource;
            this.gridControlFirma.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlFirma.Location = new System.Drawing.Point(0, 0);
            this.gridControlFirma.MainView = this.gridView2;
            this.gridControlFirma.Name = "gridControlFirma";
            this.gridControlFirma.Size = new System.Drawing.Size(1922, 1036);
            this.gridControlFirma.TabIndex = 7;
            this.gridControlFirma.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView2});
            // 
            // firmaBilgiBindingSource
            // 
            this.firmaBilgiBindingSource.DataMember = "FirmaBilgi";
            this.firmaBilgiBindingSource.DataSource = this.dbo_SirketOtomasyonFirmaBilgi;
            // 
            // dbo_SirketOtomasyonFirmaBilgi
            // 
            this.dbo_SirketOtomasyonFirmaBilgi.DataSetName = "Dbo_SirketOtomasyonFirmaBilgi";
            this.dbo_SirketOtomasyonFirmaBilgi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView2
            // 
            this.gridView2.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView2.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView2.Appearance.Row.Options.UseBackColor = true;
            this.gridView2.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAD2,
            this.colYETKILIADSOYAD,
            this.colTELEFON11,
            this.colTELEFON21,
            this.colTELEFON3,
            this.colMAIL2,
            this.colFAX});
            this.gridView2.GridControl = this.gridControlFirma;
            this.gridView2.Name = "gridView2";
            this.gridView2.OptionsView.ShowGroupPanel = false;
            //this.gridView2.DoubleClick += new System.EventHandler(this.gridView2_DoubleClick);
            // 
            // colAD2
            // 
            this.colAD2.FieldName = "AD";
            this.colAD2.Name = "colAD2";
            this.colAD2.Visible = true;
            this.colAD2.VisibleIndex = 0;
            // 
            // colYETKILIADSOYAD
            // 
            this.colYETKILIADSOYAD.FieldName = "YETKILIADSOYAD";
            this.colYETKILIADSOYAD.Name = "colYETKILIADSOYAD";
            this.colYETKILIADSOYAD.Visible = true;
            this.colYETKILIADSOYAD.VisibleIndex = 1;
            // 
            // colTELEFON11
            // 
            this.colTELEFON11.FieldName = "TELEFON1";
            this.colTELEFON11.Name = "colTELEFON11";
            this.colTELEFON11.Visible = true;
            this.colTELEFON11.VisibleIndex = 2;
            // 
            // colTELEFON21
            // 
            this.colTELEFON21.FieldName = "TELEFON2";
            this.colTELEFON21.Name = "colTELEFON21";
            this.colTELEFON21.Visible = true;
            this.colTELEFON21.VisibleIndex = 3;
            // 
            // colTELEFON3
            // 
            this.colTELEFON3.FieldName = "TELEFON3";
            this.colTELEFON3.Name = "colTELEFON3";
            this.colTELEFON3.Visible = true;
            this.colTELEFON3.VisibleIndex = 4;
            // 
            // colMAIL2
            // 
            this.colMAIL2.FieldName = "MAIL";
            this.colMAIL2.Name = "colMAIL2";
            this.colMAIL2.Visible = true;
            this.colMAIL2.VisibleIndex = 5;
            // 
            // colFAX
            // 
            this.colFAX.FieldName = "FAX";
            this.colFAX.Name = "colFAX";
            this.colFAX.Visible = true;
            this.colFAX.VisibleIndex = 6;
            // 
            // xtraTabPage3
            // 
            this.xtraTabPage3.Controls.Add(this.gridControlPersonel);
            this.xtraTabPage3.Name = "xtraTabPage3";
            this.xtraTabPage3.Size = new System.Drawing.Size(1922, 1036);
            this.xtraTabPage3.Text = "Personel";
            // 
            // gridControlPersonel
            // 
            this.gridControlPersonel.DataSource = this.personelBilgiBindingSource;
            this.gridControlPersonel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlPersonel.Location = new System.Drawing.Point(0, 0);
            this.gridControlPersonel.MainView = this.gridView3;
            this.gridControlPersonel.Name = "gridControlPersonel";
            this.gridControlPersonel.Size = new System.Drawing.Size(1922, 1036);
            this.gridControlPersonel.TabIndex = 8;
            this.gridControlPersonel.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView3});
            // 
            // personelBilgiBindingSource
            // 
            this.personelBilgiBindingSource.DataMember = "PersonelBilgi";
            this.personelBilgiBindingSource.DataSource = this.dbo_SirketOtomasyonPersonelBilgi;
            // 
            // dbo_SirketOtomasyonPersonelBilgi
            // 
            this.dbo_SirketOtomasyonPersonelBilgi.DataSetName = "Dbo_SirketOtomasyonPersonelBilgi";
            this.dbo_SirketOtomasyonPersonelBilgi.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gridView3
            // 
            this.gridView3.Appearance.Row.BackColor = System.Drawing.Color.Yellow;
            this.gridView3.Appearance.Row.BackColor2 = System.Drawing.Color.Aqua;
            this.gridView3.Appearance.Row.Options.UseBackColor = true;
            this.gridView3.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colAD1,
            this.colSOYAD1,
            this.colTELEFON1,
            this.colMAIL1});
            this.gridView3.GridControl = this.gridControlPersonel;
            this.gridView3.Name = "gridView3";
            this.gridView3.OptionsView.ShowGroupPanel = false;
            // 
            // colAD1
            // 
            this.colAD1.FieldName = "AD";
            this.colAD1.Name = "colAD1";
            this.colAD1.Visible = true;
            this.colAD1.VisibleIndex = 0;
            // 
            // colSOYAD1
            // 
            this.colSOYAD1.FieldName = "SOYAD";
            this.colSOYAD1.Name = "colSOYAD1";
            this.colSOYAD1.Visible = true;
            this.colSOYAD1.VisibleIndex = 1;
            // 
            // colTELEFON1
            // 
            this.colTELEFON1.FieldName = "TELEFON";
            this.colTELEFON1.Name = "colTELEFON1";
            this.colTELEFON1.Visible = true;
            this.colTELEFON1.VisibleIndex = 2;
            // 
            // colMAIL1
            // 
            this.colMAIL1.FieldName = "MAIL";
            this.colMAIL1.Name = "colMAIL1";
            this.colMAIL1.Visible = true;
            this.colMAIL1.VisibleIndex = 3;
            // 
            // musteriBilgiTableAdapter
            // 
            this.musteriBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // personelBilgiTableAdapter
            // 
            this.personelBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // firmaBilgiTableAdapter
            // 
            this.firmaBilgiTableAdapter.ClearBeforeFill = true;
            // 
            // PrjRehber
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.xtraTabControl1);
            this.Name = "PrjRehber";
            this.Text = "Rehber";
            this.Load += new System.EventHandler(this.PrjRehber_Load);
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlMusteri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musteriBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonMusteriBilgisi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.xtraTabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlFirma)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firmaBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonFirmaBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            this.xtraTabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlPersonel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personelBilgiBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbo_SirketOtomasyonPersonelBilgi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraGrid.GridControl gridControlMusteri;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl gridControlFirma;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage3;
        private DevExpress.XtraGrid.GridControl gridControlPersonel;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView3;
        private Dbo_SirketOtomasyonMusteriBilgisi dbo_SirketOtomasyonMusteriBilgisi;
        private System.Windows.Forms.BindingSource musteriBilgiBindingSource;
        private Dbo_SirketOtomasyonMusteriBilgisiTableAdapters.MusteriBilgiTableAdapter musteriBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAD;
        private DevExpress.XtraGrid.Columns.GridColumn colSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON2;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL;
        private Dbo_SirketOtomasyonPersonelBilgi dbo_SirketOtomasyonPersonelBilgi;
        private System.Windows.Forms.BindingSource personelBilgiBindingSource;
        private Dbo_SirketOtomasyonPersonelBilgiTableAdapters.PersonelBilgiTableAdapter personelBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAD1;
        private DevExpress.XtraGrid.Columns.GridColumn colSOYAD1;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON1;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL1;
        private Dbo_SirketOtomasyonFirmaBilgi dbo_SirketOtomasyonFirmaBilgi;
        private System.Windows.Forms.BindingSource firmaBilgiBindingSource;
        private Dbo_SirketOtomasyonFirmaBilgiTableAdapters.FirmaBilgiTableAdapter firmaBilgiTableAdapter;
        private DevExpress.XtraGrid.Columns.GridColumn colAD2;
        private DevExpress.XtraGrid.Columns.GridColumn colYETKILIADSOYAD;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON11;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON21;
        private DevExpress.XtraGrid.Columns.GridColumn colTELEFON3;
        private DevExpress.XtraGrid.Columns.GridColumn colMAIL2;
        private DevExpress.XtraGrid.Columns.GridColumn colFAX;
    }
}