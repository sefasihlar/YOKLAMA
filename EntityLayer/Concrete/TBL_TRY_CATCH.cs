using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_TRY_CATCH
    {
        public int TRY_CATCH_ID { get; set; }
        public string ERROR { get; set; }
        public Nullable<System.DateTime> DATE { get; set; }
        public Nullable<System.TimeSpan> TIME { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }
        public string ISLEM { get; set; }
        public Nullable<bool> DURUM { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
