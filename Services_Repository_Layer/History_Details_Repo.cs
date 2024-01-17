using Context.Capmas_Test;
using Context.Old_Models;
using DTOS.DTO;
using IServices_Repository_Layer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services_Repository_Layer
{
    public class History_Details_Repo : GenericRepository<NewCapmasWebsiteContext, HistoryDetail>, IHistory_Details_Repo
    {
        private readonly NewCapmasWebsiteContext _context;

        public History_Details_Repo(NewCapmasWebsiteContext context)
        {
            _context = context;
        }
        public async Task<List<History_Details_DTO>> GetAllHistoryDetails()
        {
            var result = await (from q in _context.HistoryDetails.AsNoTracking()
                                where q.HcsId == 5252 && q.HcaPdfar.EndsWith(".pdf")
                                select new History_Details_DTO
                                {
                                    id = q.HcaId,
                                    HCA_StatusAr = q.HcaStatusAr,
                                    HCA_StatYear = q.HcaStatYear,
                                    HCA_PDFAr = q.HcaPdfar
                                }).ToListAsync();
            return result;
        }
    }
}
