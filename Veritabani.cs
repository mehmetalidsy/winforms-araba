using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp_Araba.model;

namespace WinFormsApp_Araba
{
    public class Veritabani: DbContext
    {
        DbSet<Araba>? Arabalar {  get; set; }
        DbSet<Marka>? Markalar {  get; set; }
        DbSet<Yakit>? Yakitlar {  get; set; }
        DbSet<Renk>? Renkler {  get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ArabaAMP;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public BindingList<Araba> tumArabalariGetir() { Arabalar.Load(); return Arabalar.Local.ToBindingList(); }
        public BindingList<Marka> tumMarkalar() { Markalar.Load(); return Markalar.Local.ToBindingList(); }
        public BindingList<Yakit> tumYakitlar() { Yakitlar.Load(); return Yakitlar.Local.ToBindingList(); }
        public BindingList<Renk> tumRenkler() { Renkler.Load(); return Renkler.Local.ToBindingList(); }

        public void arabaEkle(Araba araba) { Arabalar.Add(araba); SaveChanges(); }
        public void markaEkle(Marka marka) { Markalar.Add(marka); SaveChanges(); }
        public void yakitEkle(Yakit yakit) { Yakitlar.Add(yakit); SaveChanges(); }
        public void renkEkle(Renk renk) { Renkler.Add(renk); SaveChanges(); }

        public void arabaSil(Araba ortak) { Arabalar.Remove(ortak); SaveChanges(); }
        public void markaSil(Marka ortak) { Markalar.Remove(ortak); SaveChanges(); }
        public void yakitSil(Yakit ortak) { Yakitlar.Remove(ortak); SaveChanges(); }
        public void renkSil(Renk ortak) { Renkler.Remove(ortak);  SaveChanges(); }

        public bool markaDuzenle(Marka eskiMarka, Marka yeniMarka)
        {
            var marka = Markalar.FirstOrDefault(k => k == eskiMarka);
            if (marka != null)
            {
                marka.adi = yeniMarka.adi;
                SaveChanges();
                return true;
            }
            return false;
        }

        internal bool yakitDuzenle(Yakit eskiYakit, Yakit yeniYakit)
        {
            var yakit = Yakitlar.FirstOrDefault(k => k == eskiYakit);
            if (yakit != null)
            {
                yakit.tur = yeniYakit.tur;
                SaveChanges();
                return true;
            }
            return false;
        }

        public bool renkDuzenle(Renk eskiRenk, Renk yeniRenk)
        {
            var renk = Renkler.FirstOrDefault(k => k == eskiRenk);
            if (renk != null)
            {
                renk.adi = yeniRenk.adi;
                SaveChanges();
                return true;
            }
            return false;
        }

        public bool arabaDuzenle(Araba eskiAraba, Araba yeniAraba)
        {
            var araba = Arabalar.FirstOrDefault(k => k == eskiAraba);
            if (araba != null)
            {
                araba.hasar = yeniAraba.hasar;
                araba.model = yeniAraba.model;
                araba.kiralik = yeniAraba.kiralik;
                araba.fiyat = yeniAraba.fiyat;
                araba.yil = yeniAraba.yil;
                araba.yakitID = yeniAraba.yakitID;
                araba.renkID = yeniAraba.renkID;
                araba.garantiSuresi = yeniAraba.garantiSuresi;
                araba.markaID = yeniAraba.markaID;
                SaveChanges();
                return true;
            }
            return false;
        }
    }
}
