using System;
using System.Collections.Generic;
using System.Text;

namespace ödev5
{
    class OyunTalebi
    {
        public void Hesaplama (List<IOyunManager> oyunmanager)
        {
            foreach (var oyun in oyunmanager)
            {
                oyun.Kampanya();
                oyun.stokadedi();
            }

        }

    }
}
