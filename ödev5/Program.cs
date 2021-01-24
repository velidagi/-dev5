using System;
using System.Collections.Generic;
using ödev5;

namespace Odev5
{
    class Program
    {
        static void Main(string[] args)
        {

            //MusteriManager databaseolusumu = new MusteriManager();

            //Musteri M1 = new Musteri() { MusteriId = 1, MusteriAdi = "Veli", MusteriSoyadi = "dağı", TcNo = "222220202", DogumTarihi = "1000" };

            //MusteriManager musterimanager = new MusteriManager();

            //musterimanager.Ekle(M1);

            //Musteri M2 = new Musteri() { MusteriId = 2, MusteriAdi = "omer", MusteriSoyadi = "selim", TcNo = "10101010", DogumTarihi = "500" };

            //musterimanager.Ekle(M2);

            

            IOyunManager mmorpg = new MMORPG();
            IOyunManager Macera = new Macera();
            IOyunManager Korku = new Korku();
            List<IOyunManager> oyunlar = new List<IOyunManager>() { mmorpg,Macera};

            OyunTalebi otb = new OyunTalebi();

            otb.Hesaplama(oyunlar);

        }
    }
}