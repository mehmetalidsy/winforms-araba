using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Araba.model
{
    [Table("arabalar")]
    public class Araba
    {
        public int Id { get; set; }

        public bool hasar {  get; set; }

        public string model { get; set; }

        public int yil { get; set; }

        public int garantiSuresi { get; set; }

        public double fiyat { get; set; }

        public int markaID { get; set; }

        public int yakitID { get; set; }

        public int renkID { get; set; }

        public bool kiralik { get; set; }

        public virtual Marka marka { get; set; } = null!;
        public virtual Yakit yakit { get; set; } = null!;
    }
}
