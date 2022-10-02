using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_VELI
    {
        public int VELI_ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }
        public Nullable<int> OGRENCI_ID { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<int> USER_ID { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual TBL_IDARI_PERSONEL TBL_IDARI_PERSONEL { get; set; }
        public virtual TBL_OGRENCI TBL_OGRENCI { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
