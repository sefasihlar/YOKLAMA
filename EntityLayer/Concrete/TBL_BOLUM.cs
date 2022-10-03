using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class TBL_BOLUM
    {
        public int BOLUM_ID  { get; set; }
        public string ADI  { get; set; }
        public bool DURUM { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public virtual TBL_SCHOOL_DURUMLARI TBL_SCHOOL_DURUMLARI { get; set; }
        public virtual ICollection<TBL_OGRENCI> TBL_OGRENCI { get; set; }
    }
}
