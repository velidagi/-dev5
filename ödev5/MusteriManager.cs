using System;
using System.Collections.Generic;
using System.Text;

namespace Odev5
{

    class MusteriManager
    {
        List<Musteri> sanaldatabase;
        public MusteriManager()
        {
            sanaldatabase = new List<Musteri>();
        }



        public void Ekle(Musteri musteri)
        {
            sanaldatabase.Add(musteri);
            // Eklendi

        }

    }
}
