using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5
{
    class Macera:IOyunManager
    {
        public int MaceraFiyat { get; set; } = 18;
        public int Macstokadedi { get; set; } = 3;

        public void Kampanya()
        {
            Console.WriteLine("Macera Asıl fiyatı: " + MaceraFiyat + "Macera İndirimli Fiyat: " + MaceraFiyat * 75 / 100);
        }
        public void stokadedi()
        {
            Console.WriteLine("Macera oyunu stok adedi" + Macstokadedi);
        }
    }
}
