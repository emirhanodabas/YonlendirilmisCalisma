namespace SirketOtomasyonu
{
    partial class PrjFaturaUrunDetay
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
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colFATURAURUNID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colURUNAD = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMIKTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFIYAT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTUTAR = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colFATURAID = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1054, 556);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Appearance.Row.BackColor = System.Drawing.Color.Aqua;
            this.gridView1.Appearance.Row.BackColor2 = System.Drawing.Color.Yellow;
            this.gridView1.Appearance.Row.BorderColor = System.Drawing.Color.Blue;
            this.gridView1.Appearance.Row.Options.UseBackColor = true;
            this.gridView1.Appearance.Row.Options.UseBorderColor = true;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colFATURAURUNID,
            this.colURUNAD,
            this.colMIKTAR,
            this.colFIYAT,
            this.colTUTAR,
            this.colFATURAID});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // colFATURAURUNID
            // 
            this.colFATURAURUNID.FieldName = "FATURAURUNID";
            this.colFATURAURUNID.Name = "colFATURAURUNID";
            this.colFATURAURUNID.Visible = true;
            this.colFATURAURUNID.VisibleIndex = 0;
            // 
            // colURUNAD
            // 
            this.colURUNAD.FieldName = "URUNAD";
            this.colURUNAD.Name = "colURUNAD";
            this.colURUNAD.Visible = true;
            this.colURUNAD.VisibleIndex = 1;
            // 
            // colMIKTAR
            // 
            this.colMIKTAR.FieldName = "MIKTAR";
            this.colMIKTAR.Name = "colMIKTAR";
            this.colMIKTAR.Visible = true;
            this.colMIKTAR.VisibleIndex = 2;
            // 
            // colFIYAT
            // 
            this.colFIYAT.FieldName = "FIYAT";
            this.colFIYAT.Name = "colFIYAT";
            this.colFIYAT.Visible = true;
            this.colFIYAT.VisibleIndex = 3;
            // 
            // colTUTAR
            // 
            this.colTUTAR.FieldName = "TUTAR";
            this.colTUTAR.Name = "colTUTAR";
            this.colTUTAR.Visible = true;
            this.colTUTAR.VisibleIndex = 4;
            // 
            // colFATURAID
            // 
            this.colFATURAID.FieldName = "FATURAID";
            this.colFATURAID.Name = "colFATURAID";
            this.colFATURAID.Visible = true;
            this.colFATURAID.VisibleIndex = 5;
            // 
            // PrjFaturaUrunDetay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1054, 556);
            this.Controls.Add(this.gridControl1);
            this.Name = "PrjFaturaUrunDetay";
            this.Text = "PrjFaturaUrunDetay";
            this.Load += new System.EventHandler(this.PrjFaturaUrunDetay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAURUNID;
        private DevExpress.XtraGrid.Columns.GridColumn colURUNAD;
        private DevExpress.XtraGrid.Columns.GridColumn colMIKTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colFIYAT;
        private DevExpress.XtraGrid.Columns.GridColumn colTUTAR;
        private DevExpress.XtraGrid.Columns.GridColumn colFATURAID;
    }
}