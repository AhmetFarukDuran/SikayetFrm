using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SikayetFrm.Models
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        public String Kullanici { get; set; }
        public string Sifre { get; set; }
    }
}