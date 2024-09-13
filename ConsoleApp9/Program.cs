class Program
{
    static void Main()
    {
        int ogrenciSayisi = 10;

        string[] ogrenciIsimleri = new string[ogrenciSayisi];
        int[] notlar = new int[ogrenciSayisi];
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.Write($"Öğrenci {i + 1} ismini girin: ");
            ogrenciIsimleri[i] = Console.ReadLine();
            int not;
            while (true)
            {
                Console.Write($"{i + 1} Lüfen Sınav Notunuzu Giriniz : ");
                if (int.TryParse(Console.ReadLine(), out not) && not >= 0 && not <= 100)
                {
                    notlar[i] = not;
                    break;
                }
                else
                {
                    Console.WriteLine("Geçersiz Bir Not Girdiniz! Lütfen Doğru Girdiğinizden Emin Olun.");
                }
            }
        }
        Console.WriteLine("\n Not Bilgileri : ");
        for (int i = 0; i < ogrenciSayisi; i++)
        {
            Console.WriteLine($"İsim: {ogrenciIsimleri[i]}, Not: {notlar[i]}");
        }

        int toplam = 0;
        int enYuksek = notlar[0];
        int enDusuk = notlar[0];
        string enYuksekOgrenci = ogrenciIsimleri[0];
        string enDusukOgrenci = ogrenciIsimleri[0];

        for (int i = 0; i < ogrenciSayisi; i++)
        {
            toplam += notlar[i];
            if (notlar[i] > enYuksek)
            {
                enYuksek = notlar[i];
                enYuksekOgrenci = ogrenciIsimleri[i];
            }
            if (notlar[i] < enDusuk)
            {
                enDusuk = notlar[i];
                enDusukOgrenci = ogrenciIsimleri[i];
            }
        }
        int ortalama = toplam / ogrenciSayisi;

        Console.WriteLine($"\n Sınıf Ortalaması : {ortalama}");
        Console.WriteLine($"Sınıftaki En Yüksek Not {enYuksekOgrenci} Adlı Öğrenciye Ait. Notu : {enYuksek}(Tebrik Ederiz!)");
        Console.WriteLine($"Sınıftaki En Düşük Not : {enDusukOgrenci} Adlı Öğrenciye Ait. Notu : {enDusuk}(Bidahaki Sefere Daha İyi Yap!)");
    }
}
