using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SikayetFrm.Models
{
    public class Kisiler
    {
        [Key]
        public int ID { get; set; }
        public string AdSoyad { get; set; }
        public int Tel { get; set; }
        public string Aciklama { get; set; }
        public int Sikayetid { get; set; }
        public virtual Sikayetler Sikayetler { get; set; }
    }
}