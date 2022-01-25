using System;
using System.Collections.Generic;
using System.Text;

namespace OgrenciYonetimSistemiV1_G008
{
    class Ogrenci
    {
        public int No;
        public string Ad;
        public string Soyad;
        public string Sube;

        public int MatematikNotu;
        public int FenNotu;
        public int TurkceNotu;
        public int TarihNotu;
        public float Ortalama;
        public CINSIYET Cinsiyet;

        public Ogrenci()
        {

        }
        public Ogrenci(int no, string ad)
        {
            this.No = no;
            this.Ad = ad;
        }
        public Ogrenci(int no, string ad, string soyadi, string sube)
        {
            this.No = no;
            this.Ad = ad;
            this.Soyad = soyadi;
            this.Sube = sube;
        }
        public void OrtalamaHesapla()
        {
            Ortalama = (MatematikNotu + FenNotu + TurkceNotu + TarihNotu) / 4;
        }
        public float OrtalamaGetir()
        {

            return (MatematikNotu + FenNotu + TurkceNotu + TarihNotu) / 4;

        }
        public float OrtalamaGetir(string tip)
        {
            if (tip == "sayisal")
            {
                return (MatematikNotu + FenNotu) / 2;
            }
            else if (tip == "sozel")
            {
                return (TarihNotu + TurkceNotu) / 2;
            }

            return -1;
        }

        public float OrtalamaGetir(ORTALAMA_TIPI ot)
        {
            if (ot == ORTALAMA_TIPI.Sayisal)
            {
                return (MatematikNotu + FenNotu) / 2;
            }
            else if (ot == ORTALAMA_TIPI.Sozel)
            {
                return (TarihNotu + TurkceNotu) / 2;
            }

            return -1;
        }

        public enum ORTALAMA_TIPI
        {
            Sayisal,
            Sozel
        }

    }
    public enum CINSIYET
    {
        Empty,
        Kiz,
        Erkek
    }





}
