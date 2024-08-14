using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstraction
{
    abstract class Calisan
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public string Departman { get; set; }

        public Calisan(string ad, string soyad, string departman)
        {
            Ad = ad;
            Soyad = soyad;
            Departman = departman;
        }

        // Abstract method
        public abstract void Gorev();
    }

    class YazilimGelistirici : Calisan
    {
        public YazilimGelistirici(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}: Yazılım geliştirici olarak çalışıyorum.");
        }
    }

    class ProjeYoneticisi : Calisan
    {
        public ProjeYoneticisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}: Proje yöneticisi olarak çalışıyorum.");
        }
    }

    class SatisTemsilcisi : Calisan
    {
        public SatisTemsilcisi(string ad, string soyad, string departman)
            : base(ad, soyad, departman) { }

        public override void Gorev()
        {
            Console.WriteLine($"{Ad} {Soyad}: Satış temsilcisi olarak çalışıyorum.");
        }
    }
}
