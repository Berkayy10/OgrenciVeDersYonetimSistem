using System;
using System.Collections.Generic;

public abstract class Kisi
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public abstract void BilgiGoster();
}

public interface IKisi
{
    void Login();
}

public class Ogrenci : Kisi, IKisi
{
    public int OgrenciNo { get; set; }
    public List<Ders> KayıtlıDersler { get; set; } = new List<Ders>();

    public override void BilgiGoster()
    {
        Console.WriteLine($"Öğrenci: {Ad} {Soyad}, No: {OgrenciNo}");
    }

    public void Login()
    {
        Console.WriteLine($"Öğrenci {Ad} {Soyad} sisteme giriş yaptı.");
    }
}

public class OgretimGorevlisi : Kisi, IKisi
{
    public string AkademikUnvan { get; set; }

    public override void BilgiGoster()
    {
        Console.WriteLine($"Öğretim Görevlisi: {AkademikUnvan} {Ad} {Soyad}");
    }

    public void Login()
    {
        Console.WriteLine($"Öğretim Görevlisi {Ad} {Soyad} sisteme giriş yaptı.");
    }
}

public class Ders
{
    public string DersAdi { get; set; }
    public int Kredi { get; set; }
    public OgretimGorevlisi OgretimGorevlisi { get; set; }
    public List<Ogrenci> KayitliOgrenciler { get; set; } = new List<Ogrenci>();

    public void BilgiGoster()
    {
        Console.WriteLine($"Ders: {DersAdi}, Kredi: {Kredi}, Öğretim Görevlisi: {OgretimGorevlisi.Ad} {OgretimGorevlisi.Soyad}");
        Console.WriteLine("Kayıtlı Öğrenciler:");
        foreach (var ogrenci in KayitliOgrenciler)
        {
            Console.WriteLine($" - {ogrenci.Ad} {ogrenci.Soyad}");
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Öğretim Görevlisi Bilgilerini Girin:");
        Console.Write("Ad: ");
        var ogretimGorevlisiAd = Console.ReadLine();
        Console.Write("Soyad: ");
        var ogretimGorevlisiSoyad = Console.ReadLine();
        Console.Write("Akademik Ünvan: ");
        var akademikUnvan = Console.ReadLine();

        var ogretimGorevlisi1 = new OgretimGorevlisi
        {
            Ad = ogretimGorevlisiAd,
            Soyad = ogretimGorevlisiSoyad,
            AkademikUnvan = akademikUnvan
        };

        Console.WriteLine("\nÖğrenci 1 Bilgilerini Girin:");
        Console.Write("Ad: ");
        var ogrenciAd1 = Console.ReadLine();
        Console.Write("Soyad: ");
        var ogrenciSoyad1 = Console.ReadLine();
        Console.Write("Öğrenci No: ");
        var ogrenciNo1 = Convert.ToInt32(Console.ReadLine());

        var ogrenci1 = new Ogrenci
        {
            Ad = ogrenciAd1,
            Soyad = ogrenciSoyad1,
            OgrenciNo = ogrenciNo1
        };

        Console.WriteLine("\nÖğrenci 2 Bilgilerini Girin:");
        Console.Write("Ad: ");
        var ogrenciAd2 = Console.ReadLine();
        Console.Write("Soyad: ");
        var ogrenciSoyad2 = Console.ReadLine();
        Console.Write("Öğrenci No: ");
        var ogrenciNo2 = Convert.ToInt32(Console.ReadLine());

        var ogrenci2 = new Ogrenci
        {
            Ad = ogrenciAd2,
            Soyad = ogrenciSoyad2,
            OgrenciNo = ogrenciNo2
        };

        Console.WriteLine("\nDers Bilgilerini Girin:");
        Console.Write("Ders Adı: ");
        var dersAdi = Console.ReadLine();
        Console.Write("Kredi: ");
        var kredi = Convert.ToInt32(Console.ReadLine());

        var ders1 = new Ders
        {
            DersAdi = dersAdi,
            Kredi = kredi,
            OgretimGorevlisi = ogretimGorevlisi1
        };

        ders1.KayitliOgrenciler.Add(ogrenci1);
        ders1.KayitliOgrenciler.Add(ogrenci2);

        Console.WriteLine("\n--- Sistemdeki Bilgiler ---");
        ogretimGorevlisi1.BilgiGoster();
        ogrenci1.BilgiGoster();
        ogrenci2.BilgiGoster();
        ders1.BilgiGoster();

        ogretimGorevlisi1.Login();
        ogrenci1.Login();
        ogrenci2.Login();
    }
}
