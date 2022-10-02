
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_IDARI_PERSONEL
    {
        public int IDARI_PERSONEL_ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string UNVAN { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public string SIFRE { get; set; }
        public bool DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI { get; set; }
        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI1 { get; set; }
        public virtual ICollection<TBL_DONEM> TBL_DONEM { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
        public virtual ICollection<TBL_OGRENCI> TBL_OGRENCI { get; set; }
        public virtual ICollection<TBL_VELI> TBL_VELI { get; set; }
    }
}
