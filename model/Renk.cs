using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Araba.model
{
    [Table("renkler")]
    public class Renk
    {
        public int Id { get; set; }
        public string adi { get; set; }

        public virtual ObservableCollection<Araba> arabalar { get; set; } = null!;
    }
}
