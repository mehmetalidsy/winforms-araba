using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp_Araba.model
{
    [Table("yakitlar")]
    public class Yakit
    {
        public int Id { get; set; }

        // LPG, Dizel, Elektirkli gibi
        public string tur {  get; set; }

        public virtual ObservableCollection<Araba> arabalar { get; set; } = null!;
    }
}
