using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOS.DTO
{
    public record History_Details_DTO
    {
        public int id { get; init; }
        public string titleAr { get; init; }
        public string titleEn { get; init; }
        public string Year { get; init; }
        public string PDF_Ar { get; init; }
        public string PDF_En{ get; init; }

    }
}
