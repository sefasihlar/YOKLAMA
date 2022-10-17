using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TBL_BOLUM
    {
        [Key]
        public int BOLUM_ID { get; set; }
        public string? ADI { get; set; }
        public bool DURUM { get; set; }
        public string? OZEL_KOD { get; set; }

        public ICollection<TBL_OGRENCI>? TBL_OGRENCIS { get; set; }

    }
}
