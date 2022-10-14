using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class TBL_SUBE
    {
        [Key]
        public int SUBE_ID { get; set; }
        public string ADI { get; set; }
        public bool DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }



    }
}
