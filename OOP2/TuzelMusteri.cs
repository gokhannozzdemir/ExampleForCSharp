using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{//Müşterileri tek çatı altında toplayarak çağırmaya "Inheritance" denir.Miras da denir.
    class TuzelMusteri:Musteri
    {
       
        public string SirketAdi { get; set; }
        public string VergiNo { get; set; }
    }
}
