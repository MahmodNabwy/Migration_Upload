using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.DTO
{
    public record OldNewsImagesDTO
    {
        public int news_id { get; init; }
        public string NameAr { get; init; }
        public string NameEn { get; init; }
        public string BriefAr { get; init; }
        public string BriefEn { get; init; }
        public string News_IconLink { get; init; }
        public DateTime? PublishDate { get; init; }
    }
}
