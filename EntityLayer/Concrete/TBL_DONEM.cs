using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DONEM
    {
        [Key]
        public int DONEM_ID { get; set; }
        public string ADI { get; set; }
        public DateTime TARIH { get; set; }
        public bool DURUM { get; set; }
        public int USER_ID { get; set; }
        public string OZEL_KOD { get; set; }

    }
}
