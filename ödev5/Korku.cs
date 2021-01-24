using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5
{
    class Korku:IOyunManager
    {
        public int KorkuFiyat { get; set; } = 22;
        public int korkustokadedi { get; set; } = 27;
        public void Kampanya()
        {
            Console.WriteLine("Korku Asıl fiyatı: " + KorkuFiyat + "Korku İndirimli Fiyat: "+ KorkuFiyat * 75 / 100);
        }
        public void stokadedi()
        {
            Console.WriteLine("korku oyunu stok adedi" + korkustokadedi);
        }


    }
}
