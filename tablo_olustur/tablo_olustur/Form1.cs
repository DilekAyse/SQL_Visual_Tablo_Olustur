using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace tablo_olustur
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection baglan = new SqlConnection("Data Source=DILEKGUN\\SQLEXPRESS; Initial Catalog = ornek; Integrated Security=True");

            try
            {
                baglan.Open();
                //tablo oluşturduk
                using (SqlCommand command = new SqlCommand("CREATE TABLE " + MAKINE_ISMI.Text + MAKINA_1.Text + "(" +

                    "RECETE_BILGISI float," +

                    "SWITCH_ACI_ALT float , SWITCH_ACI_OK float , SWITCH_ACI_UST float, SWITCH_ACI_OK_BIT varchar(MAX)," +
                    "DISLI_KONTROL_ALT float, DISLI_KONTROL_OK float,DISLI_KONTROL_UST float, DISLI_KONTROL_OK_BIT varchar(MAX)," +
                    "EFFICIENCY_ALT float, EFFICIENCY_OK float, EFFICIENCY_UST float , EFFICIENCY_OK_BIT varchar(MAX)," +
                    "BUTON_MESAFESI_ALT float, BUTON_MESAFESI_OK float, BUTON_MESAFESI_UST float, BUTON_MESAFESI_OK_BIT varchar(MAX)," +
                    "BUTON_KUVVET1_ALT float, BUTON_KUVVET1_OK float,BUTON_KUVVET1_UST float,BUTON_KUVVET1_OK_BIT varchar(MAX), " +
                    "BUTON_KUVVET_2_ALT float, BUTON_KUVVET_2_OK float, BUTON_KUVVET_2_UST float, BUTON_KUVVET_2_OK_BIT varchar(MAX), " +
                    "BUTON_BASMA_KURS_OK float, BUTON_BASMA_KURS_UST float, BUTON_BASMA_KURS_OK_BIT varchar(MAX), " +
                    "YANAL_BOSLUK_OK float, YANAL_BOSLUK_UST float, YANAL_BOSLUK_OK_BIT varchar(MAX), " +
                    "OK_ADET float, NOK_ADET float, " +
                    "TARIH datetime);", baglan))

                    command.ExecuteNonQuery();

                baglan.Close();

            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

           

        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void veri_ekle_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=DILEKGUN\\SQLEXPRESS; Initial Catalog = ornek; Integrated Security=True");
                baglan.Open();
                string ekle = "insert into Z_FORD_EF_MAKINA_1_KISA_YUZDE_YUZ(RECETE_BILGISI,SWITCH_ACI_ALT,TARIH) values (@RECETE_BILGISI,@SWITCH_ACI_ALT,@TARIH)";
                SqlCommand MAKINA_1_KISA_YUZDE_YUZ = new SqlCommand(ekle,baglan);

                MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@RECETE_BILGISI", recete_bilgisi.Text);
                MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@SWITCH_ACI_ALT", textBox1.Text);
                MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@TARIH", DateTime.Now); 

              

                MAKINA_1_KISA_YUZDE_YUZ.ExecuteNonQuery();
                
                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                baglan.Close();
               


                /*
                  baglan.Open();  
                  SqlCommand MAKINA_1_KISA_YUZDE_YUZ = new SqlCommand("insert into" + LogTut.makine_ismi + "MAKINA_1_KISA_YUZDE_YUZ (" +

                  "RECETE_BILGISI, " + "TARIH,VardiyaAdi,Urun ) VALUES( " +
                  " @RECETE_BILGISI, " + "@TARIH, @VardiyaAdi, @Urun )", baglan);

                  MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@RECETE_BILGISI", 3.14);
                  MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@TARIH", DateTime.Now );
                  MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@VardiyaAdi", AktifVardiyaAdi );
                  MAKINA_1_KISA_YUZDE_YUZ.Parameters.AddWithValue("@Urun",AktifReferansAdi );

                  MAKINA_1_KISA_YUZDE_YUZ.ExecuteNonQuery();
                  */
            }

            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }



        }

        private void veri_sil_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection baglan = new SqlConnection("Data Source=DILEKGUN\\SQLEXPRESS; Initial Catalog = ornek; Integrated Security=True");
                baglan.Open();
                string secmeSorgusu = "SELECT * from Z_FORD_EF_MAKINA_1_KISA_YUZDE_YUZ where RECETE_BILGISI=@RECETE_BILGISI";
                SqlCommand secmeKomutu = new SqlCommand(secmeSorgusu, baglan);
                secmeKomutu.Parameters.AddWithValue("@RECETE_BILGISI", recete_bilgisi.Text);
                SqlDataAdapter da = new SqlDataAdapter(secmeKomutu);
                SqlDataReader dr = secmeKomutu.ExecuteReader();
                if (dr.Read()) //Datareader herhangi bir okuma yapabiliyorsa aşağıdaki kodlar çalışır.
                {
                    string recete_bilgisii = dr["RECETE_BILGISI"].ToString();
                    dr.Close();
                    //Datareader ile okunan reçete bilgisini recete_bilgisii değişkenine atadım.
                    //Datareader açık olduğu sürece başka bir sorgu çalıştıramayacağımız için dr nesnesini kapatıyoruz.
                    DialogResult durum = MessageBox.Show(recete_bilgisii + " kaydını silmek istediğinizden emin misiniz?", "Silme Onayı", MessageBoxButtons.YesNo);
                    //Kullanıcıya silme onay sorusu
                    if (DialogResult.Yes == durum) // Eğer kullanıcı Evet seçeneğini seçmişse, veritabanından kaydı silecek kodlar çalışır.
                    {
                        string silmeSorgusu = "DELETE from Z_FORD_EF_MAKINA_1_KISA_YUZDE_YUZ where RECETE_BILGISI=@RECETE_BILGISI";
                        //RECETE_BILGISI parametresine bağlı olarak müşteri kaydını silen sql sorgusu
                        SqlCommand silKomutu = new SqlCommand(silmeSorgusu, baglan);
                        silKomutu.Parameters.AddWithValue("@RECETE_BILGISI", recete_bilgisi.Text);
                        silKomutu.ExecuteNonQuery();
                        MessageBox.Show("Kayıt Silindi...");
                        //Silme işlemini gerçekleştirdikten sonra kullanıcıya mesaj verdik.
                    }
                }

                MessageBox.Show("Müşteri Kayıt İşlemi Gerçekleşti.");

                baglan.Close();

            }
            catch (Exception hata)
            {
                MessageBox.Show("İşlem Sırasında Hata Oluştu." + hata.Message);
            }
        }
     }
}
