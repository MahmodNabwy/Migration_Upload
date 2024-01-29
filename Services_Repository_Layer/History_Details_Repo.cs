using Context.Capmas_Test;
using Context.Old_Models;
using DTOS.DTO;
using IServices_Repository_Layer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
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
        private readonly IConfiguration _configuration;

        public History_Details_Repo(NewCapmasWebsiteContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<List<History_Details_DTO>> GetAllHistoryDetails()
        {
            if (_configuration.GetSection("recordsSize").Value == "")
            {

                var result = await (from q in _context.HistoryDetails.AsNoTracking()
                                    where q.HcsId == 5252 && q.HcaPdfar.EndsWith(".pdf")
                                    select new History_Details_DTO
                                    {
                                        id = q.HcaId,
                                        titleAr = q.HcaStatusAr,
                                        titleEn = q.HcaStatusEn,
                                        Year = q.HcaStatYear,
                                        PDF_Ar = q.HcaPdfar,
                                        PDF_En = q.HcaPdfen,
                                    }).ToListAsync();
                return result;
            }
            else
            {
                var result = await (from q in _context.HistoryDetails.AsNoTracking()
                                    where q.HcsId == 5252 && q.HcaPdfar.EndsWith(".pdf")
                                    select new History_Details_DTO
                                    {
                                        id = q.HcaId,
                                        titleAr = q.HcaStatusAr,
                                        titleEn = q.HcaStatusEn,
                                        Year = q.HcaStatYear,
                                        PDF_Ar = q.HcaPdfar,
                                        PDF_En = q.HcaPdfen,
                                    }).Take(int.Parse(_configuration.GetSection("recordsSize").Value)).ToListAsync();
                return result;
            }
        }
    }
}
