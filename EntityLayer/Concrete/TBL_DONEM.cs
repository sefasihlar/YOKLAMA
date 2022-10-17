using MessagePack;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KeyAttribute = System.ComponentModel.DataAnnotations.KeyAttribute;

namespace EntityLayer.Concrete
{
    public class TBL_DONEM
    {
        [Key]
        public int DONEM_ID { get; set; }

        public string? ADI { get; set; }
        public DateTime TARIH { get; set; }
        public bool DURUM { get; set; }
        public int USER_ID { get; set; }
        public int SCHOOL_ID { get; set; }
        public string OZEL_KOD { get; set; }

        public ICollection<TBL_DERS_PROGRAMI>? TBL_DERS_PROGRAMIS { get; set; }
        public ICollection<TBL_OGRENCI>? TBL_OGRENCIS { get; set; }
        public ICollection<TBL_YOKLAMA_HAREKETLERI>? TBL_YOKLAMA_HAREKETLERIS { get; set; }
    }
}
