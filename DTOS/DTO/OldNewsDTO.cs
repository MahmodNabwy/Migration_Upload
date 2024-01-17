using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.DTO
{
    public record OldNewsDTO
    {
        public int id { get; set; }
        public string News_NameAr { get; set; }
        public string News_NameEn { get; set; }
        public string News_Period { get; set; }
        public string News_BriefAr { get; set; }
        public string News_BriefEn { get; set; }
        public DateTime? News_PublishDate { get; set; }
    }
}
