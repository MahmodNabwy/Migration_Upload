using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.DTO
{
    public class New_News_DTO
    {
        public long id { get; set; }
        public string title { get; set; }
        
        public string brief { get; set; }
        public string pdfURL_Ar { get; set; }
        public string pdfURL_En { get; set; }
        public DateTime? publish_date { get; set; }
    }
}
