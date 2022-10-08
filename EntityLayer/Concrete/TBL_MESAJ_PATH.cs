using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{

    public class TBL_MESAJ_PATH
    {
        [Key]
        public int  MESAJ_PATH_ID  { get; set; }
        public String  FIRMA_ADI  { get; set; }
        public String  API  { get; set; }
        public String  API_KEY  { get; set; }
        public String  SENDER  { get; set; }
        public String  CHARSET  { get; set; }
        public bool  DURUM  { get; set; }
        public int  SCHOOL_ID  { get; set; }
        public String OZEL_KOD { get; set; }





    }
}
