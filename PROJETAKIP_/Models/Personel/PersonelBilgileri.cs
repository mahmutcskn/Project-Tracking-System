using PROJETAKIP_.Models.ProjeTakip;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PROJETAKIP_.Models.Personel
{
    public class PersonelBilgileri
    {
        public PersonelBilgileri()
        {
            this.PersonelProjeleris = new HashSet<PersonelProjeleri>();
        }
        [Key]
        public int PersonelBilgileriId { get; set; }
        [DisplayName("E-POSTA")]
        public string Eposta { get; set; }
        [DisplayName("SIFRE")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string Sifre { get; set; }
        [DisplayName("YETKI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olmalı")]
        public string Yetki { get; set; }
        [DisplayName("AD SOYAD")]
        [StringLength(50, ErrorMessage = "Maximum uzunluk 50 karakterden fazla olmalı")]
        public string AdSoyad { get; set; }


        [DisplayName("PERSONEL GÖRSELİ")]
        public string PersonelGörseli { get; set; }


        [DisplayName("TC KIMLIK NO")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olmalı")]
        public string TCNO { get; set; }
        [DisplayName("DEPARTMANI")]
        public string Departman { get; set; }
        [DisplayName("GOREVI")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]



        public string Gorev { get; set; }
        [DisplayName("ACIKLAMA")]
        public string PozisyonAcıklama { get; set; }
        [DisplayName("TELEFON NUMARASI")]
        [StringLength(15, ErrorMessage = "Maximum uzunluk 15 karakterden fazla olmalı")]
        public string TelNo { get; set; }
        [DisplayName("ADRES BILGILERI")]
        public string Adres { get; set; }
        [DisplayName("MEDENI HAL")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string MedeniHal { get; set; }
        [DisplayName("YAKINLIK BILGISI")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string YakinBilgisi { get; set; }
        [DisplayName("YAKIN TC NO")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string YakinTC { get; set; }
        [DisplayName("YAKIN AD SOYAD")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string YakinAdSoyad { get; set; }
        [DisplayName("YAKIN TELEFONU")]
        [StringLength(25, ErrorMessage = "Maximum uzunluk 25 karakterden fazla olmalı")]
        public string YakinTel { get; set; }
        [DisplayName("DOGUM TARIHI")]
        public DateTime DogumTarihi { get; set; }
        [DisplayName("ISE GIRIS TARIHI")]
        public DateTime IseGirisTarihi { get; set; }
        public virtual ICollection<PersonelProjeleri> PersonelProjeleris { get; set; }
    }
}