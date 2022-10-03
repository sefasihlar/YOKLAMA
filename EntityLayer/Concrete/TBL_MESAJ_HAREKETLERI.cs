using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_MESAJ_HAREKETLERI
    {
        public int MESAJ_ID { get; set; }
        public string KULLANICI_TURU { get; set; }
        public Nullable<int> KULLANICI_ID { get; set; }
        public string MESAJ { get; set; }
        public Nullable<System.DateTime> TARIH { get; set; }
        public Nullable<System.TimeSpan> SAAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public string OZEL_KOD { get; set; }
        public Nullable<int> SCHOOL_ID { get; set; }
        public Nullable<int> USER_ID { get; set; }
    }
}
