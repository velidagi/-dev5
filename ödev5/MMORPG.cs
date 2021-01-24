using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5
{
    class MMORPG:IOyunManager
    {
        public int MmorpgFiyat { get; set; } = 25;
        public int mmostokadedi { get; set; } = 14;

        public void Kampanya()
        {
            Console.WriteLine("MMORPG Asıl fiyatı: " + MmorpgFiyat+ "MMORPG İndirimli Fiyat: " + MmorpgFiyat *75 / 100);
        }
        public void stokadedi()
        {
            Console.WriteLine(" oyunu stok adedi" + mmostokadedi);
        }
    }
}
