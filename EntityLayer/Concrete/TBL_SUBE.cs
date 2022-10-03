using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_SUBE
    {
        public int SUBE_ID { get; set; }
        public string ADI { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI { get; set; }
    }
}
