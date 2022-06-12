using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SirketOtomasyonu
{
    public partial class PrjRapor : Form
    {
        public PrjRapor()
        {
            InitializeComponent();
        }

        private void PrjRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'Dbo_SirketOtomasyonGiderRapor.TBL_GIDERLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_GIDERLERTableAdapter.Fill(this.Dbo_SirketOtomasyonGiderRapor.TBL_GIDERLER);
            // TODO: Bu kod satırı 'Dbo_SirketOtomasyonFirmaRapor.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_FIRMALARTableAdapter.Fill(this.Dbo_SirketOtomasyonFirmaRapor.TBL_FIRMALAR);
            // TODO: Bu kod satırı 'Dbo_SirketOtomasyonCompany_Reports.TBL_FIRMALAR' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.

            // TODO: Bu kod satırı 'Dbo_SirketOtomasyonDataSet2.TBL_MUSTERILER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_MUSTERILERTableAdapter.Fill(this.Dbo_SirketOtomasyonDataSet2.TBL_MUSTERILER);
            // TODO: Bu kod satırı 'Dbo_SirketOtomasyonPersonnel_Reports.TBL_PERSONELLER' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.TBL_PERSONELLERTableAdapter.Fill(this.Dbo_SirketOtomasyonPersonnel_Reports.TBL_PERSONELLER);



            this.reportViewer1.RefreshReport();
            this.reportViewer2.RefreshReport();
            this.reportViewer3.RefreshReport();
            this.reportViewer4.RefreshReport();
        }

        private void xtraTabControl1_Click(object sender, EventArgs e)
        {

        }
    }
}
