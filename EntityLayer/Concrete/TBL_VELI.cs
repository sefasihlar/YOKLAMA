using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EntityLayer.Concrete
{
    public class TBL_VELI
    {
        [Key]
        public int VELI_ID { get; set; }
        public string ADI { get; set; }
        public string SOYADI { get; set; }
        public string TELEFON { get; set; }
        public string MAIL { get; set; }

        public TBL_OGRENCI? OGRENCI { get; set; }

        public bool DURUM { get; set; }
        public DateTime TARIH { get; set; }
        public int USER_ID { get; set; }
        public TBL_SCHOOL_DURUMLARI SCHOOL { get; set; }
        public string OZEL_KOD { get; set; }


    }
}
