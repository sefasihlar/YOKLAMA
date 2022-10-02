using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_SCHOOL_DURUMLARI
    {
        public int SCHOOL_ID { get; set; }
        public string LISANS { get; set; }
        public string OKUL_ADI { get; set; }
        public string OKUL_MAIL { get; set; }
        public string OKUL_TELOFON { get; set; }
        public string OKUL_FAX { get; set; }
        public string SORUMLU_YETKILI1 { get; set; }
        public string SORUMLU_YETKILI_NUMARA1 { get; set; }
        public string SORUMLU_YETKILI2 { get; set; }
        public string SORUMLU_YETKILI_NUMARA2 { get; set; }
        public Nullable<System.DateTime> BASLAMA_TARIHI { get; set; }
        public Nullable<System.DateTime> BITIS_TARIHI { get; set; }
        public Nullable<System.DateTime> GUNCELLENEME_TARIHI { get; set; }
        public string KURUM_KODU { get; set; }
        public Nullable<bool> DURUM { get; set; }


        public virtual ICollection<TBL_BOLUM> TBL_BOLUM { get; set; }
        public virtual ICollection<TBL_DERS> TBL_DERS { get; set; }
        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI { get; set; }
        public virtual ICollection<TBL_DERSLER> TBL_DERSLER { get; set; }
        public virtual ICollection<TBL_DONEM> TBL_DONEM { get; set; }
        public virtual ICollection<TBL_IDARI_PERSONEL> TBL_IDARI_PERSONEL { get; set; }
        public virtual ICollection<TBL_KURUM> TBL_KURUM { get; set; }
        public virtual ICollection<TBL_LOG> TBL_LOG { get; set; }
        public virtual ICollection<TBL_OGRENCI> TBL_OGRENCI { get; set; }
        public virtual ICollection<TBL_TRY_CATCH> TBL_TRY_CATCH { get; set; }
        public virtual ICollection<TBL_VELI> TBL_VELI { get; set; }
        public virtual ICollection<TBL_YOKLAMA_HAREKETLERI> TBL_YOKLAMA_HAREKETLERI { get; set; }
     
    }
}
