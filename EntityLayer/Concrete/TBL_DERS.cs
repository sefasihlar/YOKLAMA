using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_DERS
    {
        public int DERS_ID { get; set; }
        public string ADI { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

       
        public virtual ICollection<TBL_DERS_PROGRAMI> TBL_DERS_PROGRAMI { get; set; }
        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
