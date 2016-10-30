using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace XMLODEV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Urun> urunlerListesi;
        private void btnVerileriGoster_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("Urunler.xml");

            var urunElements = doc.GetElementsByTagName("Urun");
             urunlerListesi= new List<Urun>();
            foreach (XmlElement siradakiElement in urunElements)
            {
                var siradakiElementOzellikleri = "";
                //Attribute isimlerini bildiğimiz durumlarda aşağıdaki kullanım da mevcuttur.
                //var test = siradakiElement.Attributes["Id"].Value;
                Urun yeniUrun = new Urun();
                yeniUrun.Id = Convert.ToInt32(siradakiElement.Attributes["Id"].Value);
                yeniUrun.Ad = siradakiElement.Attributes["Ad"].Value;
                //decimal.TryParse();
                yeniUrun.Fiyat = string.IsNullOrEmpty(siradakiElement.Attributes["Fiyat"].Value) ? 0m : Convert.ToDecimal(siradakiElement.Attributes["Fiyat"].Value);
                yeniUrun.KategoriAdi = siradakiElement.Attributes["KategoriAdi"].Value;
                urunlerListesi.Add(yeniUrun);
                //foreach (XmlAttribute siradakiAttr in siradakiElement.Attributes)
                //{
                //    //Urun elementinin içindeki tüm attribute'leri geziyorum. Attribute isimlerini bilmediğimiz durumlarda bu kullanılabilir. 
                   
                //    siradakiElementOzellikleri += siradakiAttr.Value+" ";
                //}
                //lstUrunler.Items.Add(siradakiElementOzellikleri);
            }
            
            lstUrunler.DataSource = urunlerListesi;
            lstUrunler.DisplayMember = "Ad";
            lstUrunler.ValueMember = "Id";
        }

        private void btnVerileriYaz_Click(object sender, EventArgs e)
        {
            //SQL Server'a CodeFirst yaklaşımı ile yazılıyor.
            UrunDBEntities ent = new UrunDBEntities();
            ent.Urunler.AddRange(urunlerListesi);
            MessageBox.Show(ent.SaveChanges() > 0 ? "Veritabanına kayıt başarılı" : "Bir sorun var");
            //TEst yorumu
        }
    }
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public decimal Fiyat { get; set; }
        public string KategoriAdi { get; set; }
    }
    public class UrunDBEntities : DbContext
    {
        public UrunDBEntities()
        {
            Database.Connection.ConnectionString = "Server=.;Database=UrunDBEntities;User Id=sa;Password=Password1";
            Database.SetInitializer<UrunDBEntities>(new CreateDatabaseIfNotExists<UrunDBEntities>());
        }
        public DbSet<Urun> Urunler { get; set; }
    }
}
