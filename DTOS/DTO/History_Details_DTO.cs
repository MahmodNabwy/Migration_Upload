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
        public string HCA_StatusAr { get; init; }
        public string HCA_StatYear { get; init; }
        public string HCA_PDFAr { get; init; }

    }
}
