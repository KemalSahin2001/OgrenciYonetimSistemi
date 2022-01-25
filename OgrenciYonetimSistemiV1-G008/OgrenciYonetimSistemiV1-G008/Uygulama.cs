using System;
using System.Collections.Generic;

namespace OgrenciYonetimSistemiV1_G008
{
    class Uygulama
    {
        List<Ogrenci> Ogrenciler = new List<Ogrenci>();



        public void Calistir()
        {
            Test();

            // OgrenciYonetimUyg();
        }





        public void Test()
        {

            //Ogrenci o = new Ogrenci();
            //o.Ad = "Naz";
            //o.TurkceNotu = 23;
            //o.MatematikNotu = 34;
            //o.FenNotu = 45;

            //// o.Ortalama = (float)(o.TurkceNotu + o.FenNotu + o.MatematikNotu) / (float)3;

            //o.OrtalamaHesapla();
            //Console.WriteLine(o.Ortalama);




















            Ogrenci g = new Ogrenci();

            g.Ad = "Gizem";

            g.TurkceNotu = 2;
            g.MatematikNotu = 4;
            g.FenNotu = 7;
            //g.OrtalamaHesapla();
            Console.WriteLine(g.Sube);

            g.Sube = "C";


            Console.WriteLine(g.Ortalama);

            Console.WriteLine(g.OrtalamaGetir());
            //   Console.WriteLine(g.OrtalamaGetir("sayısal"));
            Console.WriteLine(g.OrtalamaGetir(Ogrenci.ORTALAMA_TIPI.Sayisal));
























            //Ogrenci k = new Ogrenci(40, "Kemal", "Şahin", "B");
            //Console.WriteLine(k.Ad + " " + k.Soyad);


            ////k.Cinsiyet = "erkek";
            ////k.Cinsiyet = "bay";


            ////k.Cinsiyet = "kız";
            ////k.Cinsiyet = "kadın";


            //k.Cinsiyet = CINSIYET.Erkek;

        }










        public void OgrenciYonetimUyg()
        {
            SahteVeriGir();
            Menu();

            while (true)
            {

                string secim = SecimAl();

                switch (secim)
                {
                    case "1":
                    case "E":
                        OgrenciEkle();
                        break;
                    case "2":
                    case "S":
                        OgrenciSil();
                        break;
                    case "3":
                    case "L":
                        OgrenciListele();
                        break;
                    case "4":
                        return;
                }
            }
        }


        public string SecimAl()
        {
            Console.WriteLine();
            string karakterler = "1234ESL";
            string giris;
            int sayac = 0;

            do
            {
                sayac++;

                if (sayac == 11)
                {
                    Console.WriteLine("Deneme hakkınız kalmadı. Program sonlandırılıyor.");
                    Environment.Exit(0);
                }

                Console.Write("Seçiminiz: ");
                giris = Console.ReadLine().ToUpper();


            } while ((giris.Length != 1 || karakterler.IndexOf(giris) == -1));

            Console.WriteLine();

            return giris;
        }






        public void Menu()
        {
            Console.WriteLine("Öğrenci Yönetim Uygulaması V1");
            Console.WriteLine("1 - Öğrenci Ekle(E)          ");
            Console.WriteLine("2 - Öğrenci Sil(S)           ");
            Console.WriteLine("3 - Öğrenci Listele(L)       ");
            Console.WriteLine("4 - Çıkış                    ");
        }


        public void OgrenciListele()
        {

            Console.WriteLine("3- Öğrenci Listele ----------------");
            Console.WriteLine();
            Console.WriteLine("Şube   No     Ad Soyad");
            Console.WriteLine("-------------------------------");

            foreach (Ogrenci item in Ogrenciler)
            {
                Console.WriteLine(item.Sube.PadRight(7) + item.No.ToString().PadRight(7) + item.Ad + " " + item.Soyad);
            }



        }


        public void OgrenciSil()
        {
            Console.WriteLine("2- Öğrenci Sil -----------");

            if (Ogrenciler.Count == 0)
            {
                Console.WriteLine("Listede silinecek öğrenci yok.");
                return;
            }

            Console.WriteLine("Silmek istediğiniz öğrencinin");
            Console.Write("No:");
            int no = int.Parse(Console.ReadLine());

            Ogrenci ogr = null;

            foreach (Ogrenci item in Ogrenciler)
            {
                if (item.No == no)
                {
                    ogr = item;
                }
            }

            if (ogr == null)
            {
                Console.WriteLine("Böyle bir öğrenci bulunamadı.");
            }
            else
            {
                Console.WriteLine("Adı: " + ogr.Ad);
                Console.WriteLine("Soyadı: " + ogr.Soyad);
                Console.WriteLine("Şubesi: " + ogr.Sube);
                Console.WriteLine();
                Console.WriteLine("Öğrenciyi silmek istediğinize emin misiniz? (E/H)");
                string giris = Console.ReadLine().ToLower();

                if (giris == "e")
                {
                    Ogrenciler.Remove(ogr);
                }
            }
        }




















        public void OgrenciEkle()
        {
            Ogrenci o = new Ogrenci();
            Console.WriteLine("1- Öğrenci Ekle ---------");

            int ogrenciSirasi = Ogrenciler.Count + 1;
            Console.WriteLine(ogrenciSirasi + ". Öğrencinin");

            Console.Write("No: ");
            o.No = int.Parse(Console.ReadLine());
            Console.Write("Adı: ");
            o.Ad = Console.ReadLine();
            Console.Write("Soyadı: ");
            o.Soyad = Console.ReadLine();
            Console.Write("Sube: ");
            o.Sube = Console.ReadLine();

            Console.WriteLine("Öğrenciyi kaydetmek istediğinize emin misiniz? (E/H)");
            string giris = Console.ReadLine().ToLower();

            if (giris == "e")
            {
                Ogrenciler.Add(o);
            }
        }



        public void SahteVeriGir()
        {
            Ogrenci o1 = new Ogrenci(1, "Deniz", "Yalçın", "C");
            Ogrenciler.Add(o1);

            Ogrenci o2 = new Ogrenci();
            o2.No = 2;
            o2.Ad = "Gözde";
            o2.Soyad = "Takıl";
            o2.Sube = "B";
            Ogrenciler.Add(o2);

            Ogrenciler.Add(new Ogrenci(3, "Burcu", "Yılmaz", "C"));
        }





    }
}
