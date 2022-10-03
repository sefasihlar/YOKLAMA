using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_KURUM
    {
        public int KURUM_ID { get; set; }
        public string KURUM_ADI { get; set; }
        public string KURUM_LISANS { get; set; }
        public string KURUM_LOGO { get; set; }
        public int AKTIF_DONEM { get; set; }
        public bool DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
    }
}
