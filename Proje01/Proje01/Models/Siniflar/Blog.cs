using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Proje01.Models.Siniflar
{
    public class Blog
    {
        [Key]
        public int ID { get; set; }
        public string Baslik { get; set; }
        public string FilmDetay { get; set; }
        public string Aciklama { get; set; }
        public string BlogImage { get; set; }
        public string KucukResim { get; set; }
        public string Video { get; set; }


        public ICollection<Yorumlar> Yorumlars { get; set; }
    }
}