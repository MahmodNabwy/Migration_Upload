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
    public class OLDNewsRepo : GenericRepository<NewCapmasWebsiteContext, TblNews>, IOLDNewsRepo
    {
        private readonly NewCapmasWebsiteContext _context;
        private readonly IConfiguration _configuration;

        public OLDNewsRepo(NewCapmasWebsiteContext context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;
        }
        public async Task<List<OldNewsDTO>> GetAllNews()
        {


            var result = await (from q in _context.TblNews.AsNoTracking()
                                select new OldNewsDTO
                                {
                                    id = q.NewsId,
                                    News_BriefAr = q.NewsBriefAr,
                                    News_BriefEn = q.NewsBriefEn,
                                    News_NameAr = q.NewsNameAr,
                                    News_NameEn = q.NewsNameEn,
                                    News_Period = q.NewsPeriod,
                                    News_PublishDate = q.NewsPublishDate
                                }).ToListAsync();
            return result;

        }
        public async Task<List<oldNewsFilesDTO>> GetAllNewsFiles()
        {
            
            if (_configuration.GetSection("recordsSize").Value == "")
            {

                var result = await (from q in _context.TblNewsFiles.AsNoTracking()
                                    where q.NewsId != null && q.NlLinkAr.EndsWith(".pdf")
                                    select new oldNewsFilesDTO
                                    {
                                        News_ID = q.NewsId,
                                        NL_LinkAr = q.NlLinkAr,
                                        NL_LinkEn = q.NlLinkEn,
                                        NL_NameAr = q.NlNameAr,
                                        NL_NameEn = q.NlNameEn,
                                    }).ToListAsync();
                return result;
            }
            else
            {
                var result = await (from q in _context.TblNewsFiles.AsNoTracking()
                                    where q.NewsId != null && q.NlLinkAr.EndsWith(".pdf")
                                    select new oldNewsFilesDTO
                                    {
                                        News_ID = q.NewsId,
                                        NL_LinkAr = q.NlLinkAr,
                                        NL_LinkEn = q.NlLinkEn,
                                        NL_NameAr = q.NlNameAr,
                                        NL_NameEn = q.NlNameEn,
                                    }).Take(int.Parse(_configuration.GetSection("recordsSize").Value)).ToListAsync();
                return result;

            }
        }
        public async Task<List<OldNewsImagesDTO>> GetAllNewsImages()
        {
            if (_configuration.GetSection("recordsSize").Value == "")
            {

                var result = await (from q in _context.TblNews.AsNoTracking()
                                    where q.NewsIsPublished == true && q.NewsVisible == true

                                    select new OldNewsImagesDTO
                                    {
                                        news_id = q.NewsId,
                                        BriefAr = q.NewsBriefAr,
                                        BriefEn = q.NewsBriefEn,
                                        NameAr = q.NewsNameAr,
                                        NameEn = q.NewsNameEn,
                                        News_IconLink = q.NewsIconLink,
                                        PublishDate = q.NewsPublishDate,

                                    }).ToListAsync();
                return result;
            }
            else
            {
                var result = await (from q in _context.TblNews.AsNoTracking()
                                    where q.NewsIsPublished == true && q.NewsVisible == true

                                    select new OldNewsImagesDTO
                                    {
                                        news_id = q.NewsId,
                                        BriefAr = q.NewsBriefAr,
                                        BriefEn = q.NewsBriefEn,
                                        NameAr = q.NewsNameAr,
                                        NameEn = q.NewsNameEn,
                                        News_IconLink = q.NewsIconLink,
                                        PublishDate = q.NewsPublishDate,

                                    }).Take(int.Parse(_configuration.GetSection("recordsSize").Value)).ToListAsync();
                return result;
            }
        }
    }
}
