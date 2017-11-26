using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.OleDb;

namespace Emlak_Otomasyon
{
    public partial class AnaSayfa : Form
    {
        OleDbConnection con;
        OleDbDataAdapter adap;
        OleDbCommand cmd;
        DataSet ds;
        public AnaSayfa()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Emlak.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            
            cmd.CommandText = "insert into Emlak (SEMT,MAHALLESİ,SOKAĞI,BLOK_VE_DAİRE_NO,KİRALANAN_KONUTUN_CİNSİ,KİRAYA_VERENİN_ADI_SOYADI,VE_İKAMETGAHI_TEL_NO,KİRACININ_ADI_SOYADI,VE_İKAMETGÂHI_TEL_NO,BİR_SENELİK_KİRA_KARŞILIĞI,BİR_AYLIK_KİRA_KARŞILIĞI,KİRA_KARŞILIĞININ_ÖDENECEĞİ_HESAP_NO,KİRA_MÜDDETİ,KİRANIN_BAŞLANGICI,KİRALANAN_KONUTUN_ŞİMDİKİ_DURUMU,KİRALANAN_KONUTUN_NE_İÇİN_KULLANILACAĞI,Kiralanan_konut_ile_beraber_teslim_olunan_demirbaş_eşyanın_beyan,Kira_bedelleri_her_ayın_06_08_inci_günü_akşamı_mesai_saati_bit,Depozito_Rakam,Depozito_Yazı_ile,Düzenleme_Tarihi,KİRACI_LAR,MÜTESELSİL_KEFİL_LER,KiRAYA_VEREN) values ('" + Semt.Text + "','" + Mahallesi.Text + "','" + Sokagı.Text + "','" + Blok.Text + "','" + textBox1.Text + "','" + Veren_ad.Text + "','" + Veren_Adress.Text + "','" + Kir__ad.Text + "','" + Kir_adress.Text + "','" + sene_kira.Text + "','" + Ay_kira.Text + "','" + Hesap_no.Text + "','" + Kira_müd.Text + "','" + kira_baş.Text + "','" + Şimdiki_durum.Text + "','" + Kullanım.Text + "','" + Eşya.Text + "','" + mesai.Text + "','" + depozito.Text + "','" + depozito_yazı.Text + "','" + düzenleme_ta.Text + "','" + kiracılar.Text + "','" + kefil.Text + "','" + kiraya_veren.Text + "')";
            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Başarılı");


        }

        private void Semt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Mahallesi_TextChanged(object sender, EventArgs e)
        {

        }

        private void Sokagı_TextChanged(object sender, EventArgs e)
        {

        }

        private void Emlak_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void Blok_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Veren_ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kir_adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Veren_Adress_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kir__ad_TextChanged(object sender, EventArgs e)
        {

        }

        private void sene_kira_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ay_kira_TextChanged(object sender, EventArgs e)
        {

        }

        private void Hesap_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kira_müd_TextChanged(object sender, EventArgs e)
        {

        }

        private void kira_baş_TextChanged(object sender, EventArgs e)
        {

        }

        private void Şimdiki_durum_TextChanged(object sender, EventArgs e)
        {

        }

        private void Kullanım_TextChanged(object sender, EventArgs e)
        {

        }

        private void Eşya_TextChanged(object sender, EventArgs e)
        {

        }

        private void mesai_TextChanged(object sender, EventArgs e)
        {

        }

        private void depozito_TextChanged(object sender, EventArgs e)
        {

        }

        private void depozito_yazı_TextChanged(object sender, EventArgs e)
        {

        }

        private void düzenleme_ta_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiracılar_TextChanged(object sender, EventArgs e)
        {

        }

        private void kefil_TextChanged(object sender, EventArgs e)
        {

        }

        private void kiraya_veren_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
