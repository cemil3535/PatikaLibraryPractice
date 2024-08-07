// See https://aka.ms/new-console-template for more information

using PatikaLibraryPractice;

public class Program 
{ 
    public static void Main(string[] args)
    {
        // object generation for book registration from library class
        PatikaKutuphane register = new PatikaKutuphane
        {
            BookName = "Adi Aylin",
            WriterName = "Ayse",
            WriterSurname = "Kulin",
            NumberOfPage = 398,
            Publisher = "Remzi Kitabevi"

            
        };

        register.DisplayInfo();//displaying information on the screen

        Console.WriteLine("-----------------------------------------------------------------");

        //Generating objects for book registration from library class with value seeker constructor
        PatikaKutuphane register2 = new PatikaKutuphane("Ayse", "Adi Aylin", "Remzi Kitabevi", 398);
        register2.WriterSurname = "Kulin"; 
        register2.DisplayInfo();

    }
}

// Class: nesneler icin sablondur. Patika kutuphanesinde kitab nesnleri  icin kayit sablonu olusturulmustur. Her kitap buna gore kayit edilecektir.

// Property: fielde tanimlanan ozellikleri kontorllu olarak okuyup degistirmek icin kullanilir.Patika kutuphanesindeki; kitap adi, yazar ad ve soyad, kitabevi, sayfa sayisi guvenlikli olarak degistirilebilinir.

// New: ile siniftan nesne turetilir. Patika kutuphanesinden kitap kayit etmek icin register ve register2 olarak nesne turetilmistir.

// Constructor:yapicilardir. Nesne turetildigi anda kullanilir. Patika kutuphanesi sinifinda sinif adiyla ayni 2 tane yapici olusturlmustur. Bunlara kayit tarihi nesne turetildigi andan atanmistir. diger bir tanesinde de gerekli propertiler atanmistir.

