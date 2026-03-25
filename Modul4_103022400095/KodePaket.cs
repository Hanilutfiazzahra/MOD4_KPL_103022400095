using System;
using System.Collections.Generic;
using System.Text;

namespace Modul4_103022400095
{
    internal class KodePaket
    {
        private Dictionary<string, string> tabelKode = new Dictionary<string, string>()
        {
            {"Basic", "P201"},
            {"Standard", "P202"}, 
            {"Premium", "P203" },
            {"Unlimited", "P204"},
            {"Gaming", "P205"},
            {"Streaming", "P06"},
            {"Family", "P07" },
            {"Business", "P08"},
            {"Student", "P09"},
            {"Traveler", "P10"}
        };

        public string GetKode(string namaPaket)
        {
            if (tabelKode.ContainsKey(namaPaket))
            {
                return tabelKode[namaPaket];
            }
            else
            {
                return "Kode paket tidak ditemukan.";
            }
        }
    }
}
