using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proje01.Models.Siniflar;

namespace Proje01.Models.Siniflar
{
    public class Blogyorum
    {
        public IEnumerable<Blog> Deger1 { get; set; }
        public IEnumerable<Yorumlar> Deger2 { get; set; }
        public IEnumerable<Blog> Deger3 { get; set; }
    }
}