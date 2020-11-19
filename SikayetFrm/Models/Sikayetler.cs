using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SikayetFrm.Models
{
    public class Sikayetler
    {
        [Key]
        public int Sikayetid { get; set; }
        public String Sikayet { get; set; }
    }
}