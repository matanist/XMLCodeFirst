using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3010_JSONHTML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnVerileriCek_Click(object sender, EventArgs e)
        {
            //Öncelikle json dosyamızın içerisini System.IO ile okuyoruz.string olarak bize dönecek json dosyası içindekiler.
            var okunan = File.ReadAllText("Kisiler.json");
            //string tipte okunan değişkeninin içerisinde bir JSON dizisi var. Bunu bu Kisi listesine dönüştürüyorum. bu işlemle birlikte bir JSON nesne dizisini C# listesine dönüştürüyorum.
            List<Kisi> kisiListesi = JsonConvert.DeserializeObject<List<Kisi>>(okunan);
            lstKisiler.DataSource = kisiListesi.Select(k => new
            {
                AdSoyadYas = k.Ad + " " + k.Soyad + " " + k.Yas,
                Id=k.Id

            }).ToList();
            lstKisiler.DisplayMember = "AdSoyadYas";
            lstKisiler.ValueMember = "Id";
        }
    }
    public class Kisi
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int Yas { get; set; }
    }
}
