using SirketOtomasyonu.Entity;
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
    public partial class PrjRehber : Form
    {
        public PrjRehber()
        {
            InitializeComponent();
        }
        Dbo_SirketOtomasyonEntities dbentity = new Dbo_SirketOtomasyonEntities();
        private void PrjRehber_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonFirmaBilgi.FirmaBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.firmaBilgiTableAdapter.Fill(this.dbo_SirketOtomasyonFirmaBilgi.FirmaBilgi);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonPersonelBilgi.PersonelBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.personelBilgiTableAdapter.Fill(this.dbo_SirketOtomasyonPersonelBilgi.PersonelBilgi);
            // TODO: Bu kod satırı 'dbo_SirketOtomasyonMusteriBilgisi.MusteriBilgi' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.musteriBilgiTableAdapter.Fill(this.dbo_SirketOtomasyonMusteriBilgisi.MusteriBilgi);

        }

      

        private void gridControlMusteri_DoubleClick(object sender, EventArgs e)
        {
            PrjMail prjmail = new PrjMail();
            DataRow dr = gridView1.GetDataRow(gridView1.FocusedRowHandle);

            if (dr != null)
            {
                prjmail.mail = dr["MAIL"].ToString();
            }
            prjmail.Show();
        }
    }
}
