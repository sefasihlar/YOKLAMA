
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_IDARI_PERSONEL
    {
        [Key]
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



    }
}


