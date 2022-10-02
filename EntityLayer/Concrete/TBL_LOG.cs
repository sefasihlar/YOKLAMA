using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_LOG
    {
        public int TBL_LOG_ID { get; set; }
        public int USER_ID { get; set; }
        public DateOnly TARIH { get; set; }
        public TimeOnly GIRIS { get; set; }
        public TimeOnly CIKIS { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
