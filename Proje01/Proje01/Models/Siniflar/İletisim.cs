using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proje01.Models.Siniflar
{
    public class İletisim
    {
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public string Mail { get; set; }
        public string Konu { get; set; }
        public string Mesaj { get; set; }

    }
}