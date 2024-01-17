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
    public class New_News_Repo : GenericRepository<CapmasTestContext, News>, INew_News_Repo
    {
        private readonly CapmasTestContext _context;

        public New_News_Repo(CapmasTestContext context)
        {
            _context = context;
        }
        public async Task<List<New_News_DTO>> GetAllNews()
        {
            var result = await (from q in _context.News.AsNoTracking()
                                select new New_News_DTO
                                {
                                    id = q.Id,
                                    //content = q.Content,
                                    publish_date = q.PublishDate,
                                    title = q.Title,
                                }).ToListAsync();
            return result;

        }
    }
}
