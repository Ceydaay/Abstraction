using Abstraction;

class Program
{
    static void Main(string[] args)
    {
        // Çalışanları tanımlıyoruz
        Calisan yazilimci = new YazilimGelistirici("Ahmet", "Yılmaz", "Yazılım");
        Calisan projeYoneticisi = new ProjeYoneticisi("Hasan", "Çıldırmış", "Proje Yönetimi");
        Calisan satisTemsilcisi = new SatisTemsilcisi("Ayşe", "Kara", "Satış");

        // Her çalışanın görevini çağırıyoruz
        yazilimci.Gorev();
        projeYoneticisi.Gorev();
        satisTemsilcisi.Gorev();

        Console.ReadKey();
    }
}
